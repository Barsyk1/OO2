using Shop.Data.interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.mocks
{
    public class MockCars : iAllCars
    {
        private readonly iCarsCategory _categoryCars = new MockCategory();

        public IEnumerable<Car> Cars {
            get
            {
                return new List<Car>
                {
                    new Car {
                        name="Tesla",
                        shortDesc="Тесла Модель S является революционным электрическим автомобилем",
                        logDesc="Машина впервые смогла доказать всем, что электромотор обладает огромным превосходством над ДВС, который уже изрядно устарел.",
                        img="/img/Tesla.jpg",
                        price=45000000,
                        isFavorite=true,
                        available=true,
                        Category=_categoryCars.AllCategorys.First()
                    },
                    new Car {
                        name="Chevrolet Tahoe",
                        shortDesc="Рамные полноразмерные внедорожники американской компании General Motors, созданные на агрегатах пикапов.",
                        logDesc="Выпускаются отделениями Chevrolet с 1995 года и GMC с 1992 года, соответственно. Эти же автомобили, но с увеличенной колёсной базой называются Chevrolet Suburban и GMC Yukon XL.",
                        img="/img/Tahoe.jpeg",
                        price=29000000,
                        isFavorite=false,
                        available=true,
                        Category=_categoryCars.AllCategorys.Last()
                    },
                    new Car {
                        name="Ford Mustang",
                        shortDesc="Культовый автомобиль класса Pony Car производства Ford Motor Company",
                        logDesc="На автомобиле размещается не эмблема Ford, а специальная эмблема Mustang. Изначальный вариант 11233 был создан на базе агрегатов семейного седана Ford Falcon.",
                        img="/img/Mustang.jpg",
                        price=35000000,
                        isFavorite=true,
                        available=true,
                        Category=_categoryCars.AllCategorys.Last()
                    },
                    new Car {
                        name="Nissan Leaf",
                        shortDesc="Электромобиль японского концерна Nissan, серийно выпускаемый с весны 2010 года",
                        logDesc="Мировая премьера состоялась на международном Токийском автосалоне в 2009 году. Заказы на модель японские и американские дилеры компании начали принимать 1 апреля 2010 года, сборка первых серийных экземпляров началась в Японии, затем с 2012 года Nissan",
                        img="/img/f.jpeg",
                        price=49000000,
                        isFavorite=false,
                        available=true,
                        Category=_categoryCars.AllCategorys.First()
                    },
                     new Car
                    {
                        name = "Toyota Tundra",
                        shortDesc = "Полноразмерный пикап, выпускаемый Toyota Motor Corporation с 1999 года",
                        logDesc = "отя и сходное по размерам с T100, первое поколение Tundra имело более американский внешний вид и двигатель V8, которого не было у T100.",
                        img = "/img/Tundra.jpeg",
                        price = 49000000,
                        isFavorite = false,
                        available = true,
                        Category = _categoryCars.AllCategorys.Last()
                    },
                    new Car
                    {
                        name = "Peugeot e-208",
                        shortDesc = "Это творение General Motors с французской душой способно преодолеть на одном заряде 380 км пути",
                        logDesc = "Емкость аккумуляторной батареи – 60 кВт*ч: полная зарядка занимает 8 часов от розетки на 220В. При максимальной мощности в 204 л. с. верхний предел скорости составит 150 км/час. ",
                        img = "/img/pejo.jpg",
                        price = 39000000,
                        isFavorite = false,
                        available = true,
                        Category = _categoryCars.AllCategorys.First()
                    }

                };
            }
        }
        public IEnumerable<Car> getFaveCars { get ; set ; }

        public Car getObjectCar(int carid)
        {
            throw new NotImplementedException();
        }
    }
    
    
}
