using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Models
{
    public interface IOrderRepository
    {
        Order GetOrder(int Id);
        IEnumerable<Order> GetAllOrders();
        Order Add(Order Order);
        Order Update(Order OrderChanges);
        Order Delete(int Id);
        IEnumerable<Customer> GetCustomers();
        IEnumerable<Product> GetProducts();
    }

    public class SQLOrderRepository : IOrderRepository
    {
        private readonly AppDbContext context;
        public SQLOrderRepository(AppDbContext context)
        {
            this.context = context;
        }
        Order IOrderRepository.Add(Order Order)
        {
            context.Orders.Add(Order);
            context.SaveChanges();
            return Order;
            ;
        }
        Order IOrderRepository.Delete(int Id)
        {
            Order Order = context.Orders.Find(Id);
            if (Order != null)
            {
                context.Orders.Remove(Order);
                context.SaveChanges();
            }
            return Order;
        }
        IEnumerable<Order> IOrderRepository.GetAllOrders()
        {
            return context.Orders
                .Include(custInfo => custInfo.Customer).Include(productInfo => productInfo.Product);
            //return context.Orders;
        }
        Order IOrderRepository.GetOrder(int Id)
        {
            return context.Orders.Include(custInfo => custInfo.Customer)
                .Include(productInfo => productInfo.Product).FirstOrDefault(ord => ord.ID == Id);
        }
        Order IOrderRepository.Update(Order OrderChanges)
        {
            var Order = context.Orders.Attach(OrderChanges);
            Order.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return OrderChanges;
        }
        IEnumerable<Customer> IOrderRepository.GetCustomers()
        {
            return context.Customers;
        }
        IEnumerable<Product> IOrderRepository.GetProducts()
        {
            return context.Products;
        }
    }
}
