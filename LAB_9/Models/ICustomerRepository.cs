using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Models
{
    public interface ICustomerRepository
    {
        Customer GetCustomer(int Id);
        IEnumerable<Customer> GetAllCustomers();
        Customer Add(Customer customer);
        Customer Update(Customer CustomerChanges);
        Customer Delete(int Id);
    }

    public class SQLCustomerRepository : ICustomerRepository
    {
        private readonly AppDbContext context;
        public SQLCustomerRepository(AppDbContext context)
        {
            this.context = context;
        }
        Customer ICustomerRepository.Add(Customer customer)
        {
            context.Customers.Add(customer);
            context.SaveChanges();
            return customer;
;       }
        Customer ICustomerRepository.Delete(int Id)
        {
            Customer customer = context.Customers.Find(Id);
            if (customer != null)
            {
                context.Customers.Remove(customer);
                context.SaveChanges();
            }
            return customer;
        }
        IEnumerable<Customer> ICustomerRepository.GetAllCustomers()
        {
            return context.Customers;
        }
        Customer ICustomerRepository.GetCustomer(int Id)
        {
            return context.Customers.Find(Id);
        }
        Customer ICustomerRepository.Update(Customer customerChanges)
        {
            var customer = context.Customers.Attach(customerChanges);
            customer.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return customerChanges;
        }
    }
}
