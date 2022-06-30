using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class ProductRepository : IProductRepository
    {
        public bool CheckProductIdDuplicated(int proID) => ProductDAO.Instance.CheckProductIdDuplicated(proID);

        public void DeleteProduct(Product p) => ProductDAO.Instance.DeleteProduct(p);

        public List<Category> GetCategories() => ProductDAO.Instance.GetCategories();

        public Product GetProductByID(string proID) => ProductDAO.Instance.GetProductByID(proID);

        public List<Product> GetProducts() => ProductDAO.Instance.GetProducts();

        public void SaveProduct(Product p) => ProductDAO.Instance.SaveProduct(p);

        public List<Product> SearchProduct(string keyword, string type) => ProductDAO.Instance.SearchProduct(keyword, type);

        public void UpdateProduct(Product p) => ProductDAO.Instance.UpdateProduct(p);

        public void UpdateProductQuantity(int stockLeft, string productID) => ProductDAO.Instance.UpdateProductQuantity(stockLeft, productID);
    }
}
