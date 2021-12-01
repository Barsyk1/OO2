using Microsoft.EntityFrameworkCore;
using Shop.Data.interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Repository
{
    public class CarRepository : iAllCars
    {
        private readonly AppDBContent appDBContent;

        public CarRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }


        public IEnumerable<Car> Cars => appDBContent.Car.Include(c=>c.Category);

        public IEnumerable<Car> getFaveCars => appDBContent.Car.Where(p => p.isFavorite).Include(c => c.Category);

        public Car getObjectCar(int carid) => appDBContent.Car.FirstOrDefault(p=>p.id==carid);
        
    }
}
