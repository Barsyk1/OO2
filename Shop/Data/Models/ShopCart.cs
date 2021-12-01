using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class ShopCart
    {
        private readonly AppDBContent appDBContent;

        public ShopCart(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }


        public string ShopCartid { get; set; }

        public List<ShopCarItem> listShopItems { get; set; }


        public static ShopCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<AppDBContent>();
            string shopCartId = session.GetString("cartid") ?? Guid.NewGuid().ToString();

            session.SetString("cartid", shopCartId);

            return new ShopCart(context) { ShopCartid = shopCartId };

        }

        public void AddToCart(Car car)
        {
            appDBContent.ShopCarItem.Add(new ShopCarItem
            {
                ShopCarId = ShopCartid,
                car = car,
                price = car.price

            });

            appDBContent.SaveChanges();
            
        }

        public List<ShopCarItem> getShopitems()
        {
            return appDBContent.ShopCarItem.Where(c => c.ShopCarId == ShopCartid).Include(s=>s.car).ToList();
        }

    }
}
