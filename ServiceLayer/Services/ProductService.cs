using ServiceLayer.Interfaces;
using ServiceLayer.DTOs;
using DomainLayer.Interfaces;
using DomainLayer.DomainModels;
using RepositoryLayer.Contexts;
using RepositoryLayer.Repositories;
using System.Collections.Generic;
using AutoMapper;

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
                cfg.CreateMap<Products, ProductDTO>();
                cfg.CreateMap<Attributes, AttributeDTO>();
                cfg.CreateMap<AttributeDetails, ADDTO>();
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
    }
}