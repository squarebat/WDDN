using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Models
{
    public interface IProductRepository
    {
        Product GetProduct(int Id);
        IEnumerable<Product> GetAllProducts();
        Product Add(Product Product);
        Product Update(Product ProductChanges);
        Product Delete(int Id);
    }

    public class SQLProductRepository : IProductRepository
    {
        private readonly AppDbContext context;
        public SQLProductRepository(AppDbContext context)
        {
            this.context = context;
        }
        Product IProductRepository.Add(Product Product)
        {
            context.Products.Add(Product);
            context.SaveChanges();
            return Product;
            ;
        }
        Product IProductRepository.Delete(int Id)
        {
            Product Product = context.Products.Find(Id);
            if (Product != null)
            {
                context.Products.Remove(Product);
                context.SaveChanges();
            }
            return Product;
        }
        IEnumerable<Product> IProductRepository.GetAllProducts()
        {
            return context.Products;
        }
        Product IProductRepository.GetProduct(int Id)
        {
            return context.Products.Find(Id);
        }
        Product IProductRepository.Update(Product ProductChanges)
        {
            var Product = context.Products.Attach(ProductChanges);
            Product.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return ProductChanges;
        }
    }
}
