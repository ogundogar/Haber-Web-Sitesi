using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;
using System.Linq;
using SportsStore.Models.ViewModels;

namespace SportsStore.Components
{
    public class Turkiye:ViewComponent
    {
        private IStoreRepository repository;
        

        public Turkiye(IStoreRepository repo)
        {
            repository = repo;
        }

        public IViewComponentResult Invoke()
        {

            return View(repository.Products
                .Where(p => p.Category.Contains("Turkiye")).OrderByDescending(p => p.ProductID).Take(4));
        }
    }
}
