using ServiceLayer.Interfaces;
using ServiceLayer.DTOs;
using DomainLayer.Interfaces;
using DomainLayer.DomainModels;
using RepositoryLayer.Contexts;
using RepositoryLayer.Repositories;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using System;
using System.Text.RegularExpressions;

namespace ServiceLayer.Services
{
    public class ProductService : IProductService
    {
        private readonly MarketContext _context = new MarketContext();

        private readonly IUnitOfWork _unitOfWork;

        private readonly Mapper mapper;

        public ProductService()
        {
            _unitOfWork = new UnitOfWork(_context);

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Categories, CategoryDTO>();
                cfg.CreateMap<SubCategories, SubCategoryDTO>();
                cfg.CreateMap<Products, ProductDTO>().
                ForMember(dest => dest.SubCategory, opt => opt.MapFrom(src => src.SubCategory));
                cfg.CreateMap<Attributes, AttributeDTO>();
                cfg.CreateMap<AttributeDetails, ADDTO>();
                cfg.CreateMap<KeySpec, KeySpecDTO>();
            });
            mapper = new Mapper(config);
        }

        public IEnumerable<CategoryDTO> GetCategories()
        {
            var categories = mapper.Map<List<CategoryDTO>>(_unitOfWork.CategoryRepo.GetAll());
            return categories;
        }

        public CategoryDTO GetCategory(int id)
        {
            var category = mapper.Map<CategoryDTO>(_unitOfWork.CategoryRepo.getById(id));
            return category;
        }

        public IEnumerable<SubCategoryDTO> GetSubCategories()
        {
            var subcategories = mapper.Map<List<SubCategoryDTO>>(_unitOfWork.SubCateRepo.GetAll());
            return subcategories;
        }

        public SubCategoryDTO GetSubCategory(int id)
        {
            var subcategory = mapper.Map<SubCategoryDTO>(_unitOfWork.SubCateRepo.getById(id));
            return subcategory;
        }

        public ProductDTO GetProduct(int id)
        {
            var product = mapper.Map<ProductDTO>(_unitOfWork.ProductRepo.getById(id));
            return product;
        }

        public SearchDTO GetSearches(int id)
        {
            var categories = mapper.Map<List<CategoryDTO>>(_unitOfWork.CategoryRepo.GetAll());
            var subcategory = mapper.Map<SubCategoryDTO>(_unitOfWork.SubCateRepo.getById(id));
            var searchList = new SearchDTO
            {
                Categories = categories,
                SubCategory = subcategory,
                Products = subcategory.Products,
            };
            return searchList;
        }

        public CompareDTO GetCompares(string idList)
        {
            var productIDList = idList.Split(',').Select(int.Parse).ToList();
            if (productIDList == null || !productIDList.Any())
            {
                return null;
            }
            var product = mapper.Map<ProductDTO>(_unitOfWork.ProductRepo.getById(productIDList[0]));
            var subcategory = mapper.Map<SubCategoryDTO>(_unitOfWork.SubCateRepo.getById(product.SubCategoryID));
            var productList = subcategory.Products.Where(p => productIDList.Contains(p.ProductID));
            var compareList = new CompareDTO
            {
                Categories = mapper.Map<List<CategoryDTO>>(_unitOfWork.CategoryRepo.GetAll()),
                SubCategory = subcategory,
                Products = productList,
            };
            return compareList;
        }

        public List<ProductDTO> GetFilters(int id, Dictionary<int, string> filters)
        {
            if (filters != null)
            {
                var subcategory = mapper.Map<SubCategoryDTO>(_unitOfWork.SubCateRepo.getById(id));
                var products = subcategory.Products;
                var filterList = new List<ProductDTO>();

                for(int i = 0; i < products.Count; i++)
                {
                    bool addToList = true;
                    for (int j = 0; j < filters.Count; j++)
                    {
                        var attributeId = filters.Keys.ElementAt(j);
                        var attribute = subcategory.Attributes.FirstOrDefault(a => a.AttributeID == attributeId);
                        if(attribute.AttributeType == "integer")
                        {
                            var filterValue = int.Parse(filters.Values.ElementAt(j));
                            var attributeDetail = attribute.AttributeDetails.FirstOrDefault(ad => ad.ProductID == products.ElementAt(i).ProductID).Details;
                            int value = int.Parse(Regex.Replace(attributeDetail, @"[^\d]", ""));
                            if(value < filterValue)
                            {
                                addToList = false;
                                break;
                            }
                        }
                        else if (attribute.AttributeType == "float")
                        {
                            var filterValue = float.Parse(filters.Values.ElementAt(j));
                            var attributeDetail = attribute.AttributeDetails.FirstOrDefault(ad => ad.ProductID == products.ElementAt(i).ProductID).Details;
                            float value = float.Parse(Regex.Match(attributeDetail, @"-?\d+(\.\d+)?").Value);
                            if(value < filterValue)
                            {
                                addToList = false;
                                break;
                            }
                        }
                        else
                        {
                            var filterValue = filters.Values.ElementAt(j);
                            var attributeDetail = attribute.AttributeDetails.FirstOrDefault(ad => ad.ProductID == products.ElementAt(i).ProductID).Details;
                            if(attributeDetail != filterValue)
                            {
                                addToList = false;
                                break;
                            }
                        }
                    }
                    if (addToList)
                    {
                        filterList.Add(products.ElementAt(i));
                    }
                }
                return filterList;
            }
            else
            {
                return null;
            }
        }

        public IEnumerable<KeySpecDTO> GetKeySpecsByProductId(int productId)
        {
            var keySpecs = _unitOfWork.KeySpecRepo.GetAll().Where(k => k.ProductID == productId);
            return mapper.Map<IEnumerable<KeySpecDTO>>(keySpecs);
        }
    }
}