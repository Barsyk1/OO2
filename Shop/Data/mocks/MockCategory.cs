using Shop.Data.interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.mocks
{
    public class MockCategory : iCarsCategory
    {
        public IEnumerable<Category> AllCategorys
        {
            get{
                return new List<Category> {
                    new Category {categoryname="Электромобили",desc="Современный вид транспорта" },
                    new Category {categoryname="Классические автомобили",desc="Машины с двигателем внутреннего сгорания"}
                };
            }

        }
    }
}
