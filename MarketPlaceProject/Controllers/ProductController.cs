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

        [HttpGet]
        public ActionResult SearchPage()
        {
            var categories = productMapper.Map<List<CategoryVM>>(productService.GetCategories());
            return View(categories);
        }

        [HttpGet]
        public JsonResult GetCategory(int categoryID)
        {
            var category = productMapper.Map<CategoryVM>(productService.GetCategory(categoryID));
            var subCategories = category.SubCategories;
            var subCategoryList = subCategories.Select(n => new { id = n.SubCategoryID, name = n.SubCategoryName }).ToList();
            return Json(subCategoryList, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult SearchProducts(int subcategoryID)
        {
            var subcategory = productMapper.Map<SubCategoryVM>(productService.GetSubCategory(subcategoryID));
            var attributes = subcategory.Attributes;
            var products = subcategory.Products.Select(p => new
            {
                ProductName = p.ProductName,
                Attributes = p.AttributeDetails
                        .Select(ad => new
                        {
                            AttributeName = attributes.Where(a => a.AttributeID == ad.AttributeID).Select(n => n.AttributeName),
                            Details = ad.Details
                        })
                        .Take(p.AttributeDetails.Count / 2)
            }).ToList();

            return Json(products, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult CompareProducts(string productIDs, int subcategoryID)
        {
            var productIDList = productIDs.Split(',').Select(int.Parse).ToList();

            if (productIDList == null || !productIDList.Any())
            {
                return RedirectToAction("SearchPage");
            }
            var subcategory = productMapper.Map<SubCategoryVM>(productService.GetSubCategory(subcategoryID));
            var attributes = subcategory.Attributes;
            var compareList = subcategory.Products.Where(p => productIDList.Contains(p.ProductID)).Select(product => new
            {
                ProductName = product.ProductName,
                Attributes = product.AttributeDetails.Select(ad => new
                {
                    AttributeName = attributes.Where(a => a.AttributeID == ad.AttributeID).Select(n => n.AttributeName),
                    Details = ad.Details
                })
            }).ToList();

            return View(compareList);
        }
    }
}