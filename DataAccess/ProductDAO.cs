using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DataAccess
{
    class ProductDAO
    {
        private static ProductDAO instance = null;
        private static readonly object instanceLock = new object();

        private ProductDAO() { }
        public static ProductDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ProductDAO();
                    }
                    return instance;
                }
            }
        }


        public List<Category> GetCategories()
        {
            var listCategories = new List<Category>();
            try
            {
                using (var context = new FStoreDBContext())
                {
                    listCategories = context.Categories.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return listCategories;
        }

        public List<Product> GetProducts()
        {
            var listProducts = new List<Product>();
            try
            {
                using (var db = new FStoreDBContext())
                {
                    listProducts = db.Products.ToList();
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return listProducts;
        }


        public void SaveProduct(Product p)
        {
            try
            {
                using (var context = new FStoreDBContext())
                {
                    context.Products.Add(p);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void UpdateProduct(Product p)
        {
            try
            {
                using (var context = new FStoreDBContext())
                {
                    context.Entry<Product>(p).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void DeleteProduct(Product p)
        {
            try
            {
                using (var context = new FStoreDBContext())
                {
                    var p1 = context.Products.SingleOrDefault(c => c.ProductId == p.ProductId);
                    context.Products.Remove(p1);

                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Boolean CheckProductIdDuplicated(int proID) {
            Boolean check = false;
            Product product = new Product();
            try
            {
                using (var dbContext = new FStoreDBContext())
                {
                    product = dbContext.Products.SingleOrDefault(m => m.ProductId == proID);
                }
                if (product!= null)
                {
                    check = true;
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return check;
        }

        public Product GetProductByID(string proID)
        {
            int id = int.Parse(proID);
            Product product = new Product();
            try
            {
                using (var dbContext = new FStoreDBContext())
                {
                    product = dbContext.Products.SingleOrDefault(m => m.ProductId == id);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return product;
        }

        public List<Product> SearchProduct (string keyword, string type)
        {
            List<Product> productSearchList = null;
            try
            {
                using (var dbContext = new FStoreDBContext())
                {
                    if ("ProductName".Equals(type))
                    {
                        var result = from p in dbContext.Products
                                 where p.ProductName.Contains(keyword)
                                 select p;
                        productSearchList = result.ToList();
                    }
                    else if ("ProductID".Equals(type))
                    {                   
                        var result = from p in dbContext.Products
                                     where p.ProductId.ToString().Equals(keyword)
                                     select p;
                        productSearchList = result.ToList();
                    }
                    else if ("Price".Equals(type))
                    {
                        decimal productPrice = 0;
                        if (Regex.IsMatch(keyword, @"^\d+$"))
                        {
                            productPrice = decimal.Parse(keyword);
                        }                           
                        var result = from p in dbContext.Products
                                     where ((p.UnitPrice < productPrice * 6/5) && (p.UnitPrice > productPrice * 5 / 6))
                                     select p;
                        productSearchList = result.ToList();
                    }
                    else if ("Stock".Equals(type))
                    {
                        int productStock = 0;
                        if (Regex.IsMatch(keyword, @"^\d+$"))
                        {
                            productStock = int.Parse(keyword);
                        }                        
                        var result = from p in dbContext.Products
                                     where p.UnitsInStock >= productStock
                                     select p;
                        productSearchList = result.ToList();
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            return productSearchList;
        }

        public void UpdateProductQuantity(int stockLeft, string productID)
        {
            try
            {
                using (var dbContext = new FStoreDBContext())
                {
                    var product = dbContext.Products.Where(p => p.ProductId.Equals(int.Parse(productID))).FirstOrDefault();
                    product.UnitsInStock = stockLeft;
                    dbContext.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
