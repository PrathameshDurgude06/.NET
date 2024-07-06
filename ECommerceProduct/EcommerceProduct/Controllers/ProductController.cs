
using EcommerceProduct.Services;
using EcommerceProduct.Models;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceProduct.Controllers
{
    public class ProductController : Controller
    {
       private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(); 
        }

        public IActionResult GetAllProd(int id , string title , string description , double unitprice , string url , int qty)
        {
            Product products = new Product();
            products.Id = id;
            products.Title = title; 
            products.Description = description; 
            products.ImageUrl = url;
            products.Quantity = qty;
            ViewData["catlog"] = _productService.GetProducts();
            return View();
        }
        
        public IActionResult GetProdById(int id)
        {
            ViewData["catlog"] = _productService.GetProductById(id);
            return View();
        }            
        
       
    }
}
