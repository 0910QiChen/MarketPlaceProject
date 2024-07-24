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
    [Authorize]
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
                cfg.CreateMap<ProductDTO, ProductVM>().
                ForMember(dest => dest.SubCategory, opt => opt.MapFrom(src => src.SubCategory));
                cfg.CreateMap<AttributeDTO, AttributeVM>();
                cfg.CreateMap<ADDTO, ADVM>();
                cfg.CreateMap<CompareDTO, CompareVM>();
                cfg.CreateMap<SearchDTO, SearchVM>();
            });
            productMapper = new Mapper(ProductConfig);
        }

        [HttpGet]
        public ActionResult MainPage()
        {
            var categories = productMapper.Map<List<CategoryVM>>(productService.GetCategories());
            return View(categories);
        }

        [HttpGet]
        public JsonResult GetSubCategories(int categoryID)
        {
            var category = productMapper.Map<CategoryVM>(productService.GetCategory(categoryID));
            var subCategories = category.SubCategories;
            var subCategoryList = subCategories.Select(n => new { id = n.SubCategoryID, name = n.SubCategoryName }).ToList();
            return Json(subCategoryList, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult SearchProducts(int subcategoryID)
        {
            var searchList = productMapper.Map<SearchVM>(productService.GetSearches(subcategoryID));
            return View(searchList);
        }

        [HttpGet]
        public ActionResult CompareProducts(string productIDs)
        {
            var compareList = productMapper.Map<CompareVM>(productService.GetCompares(productIDs));
            if(compareList.Products.Count() < 2)
            {
                TempData["compareFailed"] = "Please select two products to compare!";
                return RedirectToAction("SearchProducts", new { subcategoryID = compareList.SubCategory.SubCategoryID });
            }
            return View(compareList);
        }

        [HttpGet]
        public ActionResult FilterProducts(int subcategoryID, string filters)
        {
            var filterDict = Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<int, string>>(filters);

            var filterList = productMapper.Map<List<ProductVM>>(productService.GetFilters(subcategoryID, filterDict));

            return PartialView("_ProductList", filterList);
        }

        [HttpGet]
        public ActionResult KeySpecs(int productId)
        {
            var keySpecs = productService.GetKeySpecsByProductId(productId);
            var keySpecViewModel = keySpecs.Select(k => new KeySpecVM
            {
                Key = k.Key,
                Value = k.Value
            }).ToList();

            return View(keySpecViewModel);
        }
    }
}