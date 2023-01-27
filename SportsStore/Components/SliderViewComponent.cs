using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Components
{
    public class SliderViewComponent:ViewComponent
    {
        private IStoreRepository repository;

        public SliderViewComponent(IStoreRepository repo)
        {
            repository = repo;
        }

        public IViewComponentResult Invoke()
        {

            return View(repository.Products
                .Where(p => p.Category.Contains("Slider")).OrderByDescending(p => p.ProductID).Take(4));
        }
    }  
}
