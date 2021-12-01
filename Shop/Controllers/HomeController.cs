using Microsoft.AspNetCore.Mvc;
using Shop.Data.interfaces;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class HomeController : Controller
    {
        private readonly iAllCars _carRep;
        

        public HomeController(iAllCars carRep)
        {
            _carRep = carRep;
            
        }

        public ViewResult Index()
        {
            var homeCars = new HomeViewModels
            {
                favCars=_carRep.getFaveCars
            };
            return View(homeCars);
        }
    }
}
