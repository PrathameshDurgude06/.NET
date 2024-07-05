using BOL;
using DAL;
using Microsoft.AspNetCore.Mvc;
using SL;

namespace Products.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Products()
        {
            List<Product> products = _productService.GetAll();
            ViewData["catalog"] = products;
            return View();
        }
        [HttpGet]
        public IActionResult ProductById()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ProductById(int pid)
        {
            Product product = _productService.GetById(pid);
            ViewData["xyz"] = product;
            return View();
        }

        [HttpGet]
        public IActionResult Insert()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Insert(int pid,string pname,int qty,double price)
        {
            Product product=new Product(pid,pname,qty,price);
            _productService.Insert(product);
            return View();
        }

        [HttpGet]
        public IActionResult Update()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Update(int pid,string pname,int qty,double price)
        {
          // Product product= _productService.GetById(pid);
          Product product=new Product(pid,pname,qty,price);
            _productService.Update(product);
            return View();
        }

        [HttpGet]
        public IActionResult Delete() {

            return View();
        }

        [HttpPost]
        public IActionResult Delete(int pid)
        {
            _productService.Delete(pid);
            return View();
        }

    }
}
