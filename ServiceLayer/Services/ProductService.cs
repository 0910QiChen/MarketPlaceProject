using ServiceLayer.Interfaces;
using ServiceLayer.DTOs;
using DomainLayer.Interfaces;
using DomainLayer.DomainModels;
using RepositoryLayer.Contexts;
using RepositoryLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace ServiceLayer.Services
{
    public class ProductService : IProductService
    {
        MarketContext _context = new MarketContext();

        private readonly IUnitOfWork _unitOfWork;

        private Mapper mapper;

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

        public IEnumerable<ProductDTO> GetAllProducts()
        {
            var products = mapper.Map<List<ProductDTO>>(_unitOfWork.ProductRepo.GetAll());
            return products;
        }
    }
}