using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace DataAccess.Repository
{
    public interface IProductRepository
    {
        void SaveProduct(Product p);
        void DeleteProduct(Product p);
        void UpdateProduct(Product p);
        List<Product> GetProducts();
        List<Category> GetCategories();
        bool CheckProductIdDuplicated(int proID);
        List<Product> SearchProduct(string keyword, string type);
        public Product GetProductByID(string proID);
        public void UpdateProductQuantity(int stockLeft, string productID);
    }
}
