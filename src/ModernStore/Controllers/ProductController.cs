using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNet.Mvc;
using ModernStore.ViewModel;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ModernStore.Controllers
{
    public class ProductController : Controller
    {
        public ProductController()
        {
            Mapper.CreateMap<Product, ProductsViewModel.ProductItem>();
            Mapper.CreateMap<Product, ProductViewModel>();
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            ProductRepository repository = new ProductRepository();
            Product[] products = repository.List();
            ProductsViewModel model = new ProductsViewModel();
            model.Products = Mapper.Map<ProductsViewModel.ProductItem[]>(products);
            model.Count = products.Length;

            return this.View(model);
        }

        public IActionResult Item(int id)
        {
            ProductRepository repository = new ProductRepository();
            Product product = repository.Get(id);
            ProductViewModel model = Mapper.Map<ProductViewModel>(product);
            return this.View(model);
        }
    }
}
