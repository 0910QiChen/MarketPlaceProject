using AutoMapper;
using MarketPlaceProject.ViewModels;
using ServiceLayer.DTOs;
using ServiceLayer.Interfaces;
using ServiceLayer.Services;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Linq;

namespace MarketPlaceProject.Controllers
{
    public class ProductController : Controller
    {
        public IProductService productService;
        private readonly Mapper productMapper;

        public ProductController()
        {
            productService = new ProductService();
            var ProductConfig = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<CategoryDTO, CategoryVM>();
                cfg.CreateMap<SubCategoryDTO, SubCategoryVM>();
                cfg.CreateMap<ProductDTO, ProductVM>();
                cfg.CreateMap<AttributeDTO, AttributeVM>();
                cfg.CreateMap<ADDTO, ADVM>();
            });
            productMapper = new Mapper(ProductConfig);
        }
        public ActionResult CategoryList()
        {
            var categories = productMapper.Map<List<CategoryVM>>(productService.GetCategories());
            return View(categories);
        }

        public ActionResult GetCategory(int categoryID)
        {
            var category = productMapper.Map<CategoryVM>(productService.GetCategory(categoryID));
            var subCategories = category.SubCategories;
            var names = subCategories.Select(n => n.SubCategoryName).ToList();
            return Json(names, JsonRequestBehavior.AllowGet);
        }
    }
}