using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Repository {
    public class OrdersRepository : IAllOrders {
        private readonly AppDbContent appDbContent;
        private readonly ShopCart shopCart;
        public OrdersRepository(AppDbContent appDbContent, ShopCart shopCart) {
            this.appDbContent = appDbContent;
            this.shopCart = shopCart;
        }

        public void createOrder(Order order) {
            order.OrderTime = DateTime.Now;
            appDbContent.Order.Add(order);

            var items = shopCart.ListShopItems;

            foreach (var el in items) {
                var orderDetail = new OrderDetail() {
                    CarId = el.Car.Id,
                    OrderId = order.Id,
                    Price = el.Car.Price,
                };
                appDbContent.OrderDetail.Add(orderDetail);
            }
            appDbContent.SaveChanges();
        }
    }
}
