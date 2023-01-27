
using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;
using System.Linq;
using SportsStore.Models.ViewModels;

namespace SportsStore.Components
{
    public class DunyaViewComponent : ViewComponent
    {
        private IStoreRepository repository;

        public DunyaViewComponent(IStoreRepository repo)
        {
            repository = repo;
        }

        public IViewComponentResult Invoke()
        {

            return View(repository.Products
                .Where(p => p.Category.Contains("Dunya")).OrderByDescending(p => p.ProductID).Take(6));
        }
    }
}
