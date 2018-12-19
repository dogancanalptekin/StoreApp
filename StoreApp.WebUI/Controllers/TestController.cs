using StoreApp.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StoreApp.Data.Concrete.EntityFramework;
using System.Threading.Tasks;
using StoreApp.Entity;

namespace StoreApp.WebUI.Controllers
{
    public class TestController : Controller
    {
        IProductRepository _productRepository;
        ICategoryRepository _categoryRepository;
        IOrderRepository _orderRepository;
        IOrderLineRepository _orderLineRepository;

        public TestController()
        {
            _productRepository = new EfProductRepository();
            _categoryRepository = new EfCategoryRepository();
            _orderRepository = new EfOrderRepository();
            _orderLineRepository = new EfOrderLineRepository();
        }

        public ActionResult Index()
        {
            return View(_productRepository.Products);
        }

        public async Task<ActionResult> DeleteProduct(int Id)
        {
            await _productRepository.DeleteProductAsync(Id);
            return RedirectToAction("Index");
        }

        public async Task<ActionResult> SaveProduct(Product product)
        {
            await _productRepository.SaveProductAsync(product);
            return RedirectToAction("Index");
        }
    }
}