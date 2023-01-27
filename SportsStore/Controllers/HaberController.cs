using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SportsStore.Models;
using SportsStore.Models.ViewModels;
using System;
  using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Controllers
{
    [Route("api/[controller]/{action}")]
    [ApiController]
    public class HaberController : ControllerBase
    {
        private IStoreRepository repository;
        List<Product> products = new List<Product>();
        public HaberController(IStoreRepository repo, StoreDbContext ctx)
        {
            repository = repo;
        }  

        [HttpGet]
        public IEnumerable<Product> Dunya()
        {

            products = repository.Products.Where(p => p.Category.Contains("Dunya")).OrderByDescending(p => p.ProductID).ToList();
            return products;
        }
        [HttpGet]
        public IEnumerable<Product> Turkiye()
        {
            List<Product> products = new List<Product>();
            products = repository.Products.Where(p => p.Category.Contains("Turkiye")).OrderByDescending(p => p.ProductID).ToList();
            return products;
        }
        [HttpGet]
        public IEnumerable<Product> Ekonomi()
        {
            List<Product> products = new List<Product>();
            products = repository.Products.Where(p => p.Category.Contains("Ekonomi")).OrderByDescending(p => p.ProductID).ToList();
            return products;
        }
        [HttpGet]
        public IEnumerable<Product> Magazin()
        {
            List<Product> products = new List<Product>();
            products = repository.Products.Where(p => p.Category.Contains("Magazin")).OrderByDescending(p => p.ProductID).ToList();
            return products;
        }
        [HttpGet]
        public IEnumerable<Product> Spor()
        {
            List<Product> products = new List<Product>();
            products = repository.Products.Where(p => p.Category.Contains("Spor")).OrderByDescending(p => p.ProductID).ToList();
            return products;
        }


        [HttpPost]
        public void Ekle([FromForm] Product product)
        {
            repository.CreateProduct(product);
        }

        [HttpPut]
        public void Guncelle([FromForm] Product product)
        {
            repository.CreateProduct(product);
        }

        [HttpDelete]
        public void Sil([FromForm] Product product)
        {
            repository.DeleteProduct(product);
        }





    }
}
