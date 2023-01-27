using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Components
{
    public class MagazinViewComponent:ViewComponent
    {
        private IStoreRepository repository;

        public MagazinViewComponent(IStoreRepository repo)
        {
            repository = repo;
        }

        public IViewComponentResult Invoke()
        {

            return View(repository.Products
                .Where(p => p.Category.Contains("Magazin")).OrderByDescending(p => p.ProductID).Take(6));
        }
    }
}
