using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    class OrderDAO
    {

        private static OrderDAO instance = null;
        private static readonly object instanceLock = new object();

        private OrderDAO() { }
        public static OrderDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDAO();
                    }
                    return instance;
                }
            }
        }

        public List<Order> GetOrders()
        {
            var listOrders = new List<Order>();
            try
            {
                using (var context = new FStoreDBContext())
                {
                    listOrders = context.Orders.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return listOrders;
        }

        public void DeleteOrder(Order ord)
        {
            try
            {
                using (var context = new FStoreDBContext())
                {
                    var order = context.Orders.SingleOrDefault(o => o.OrderId == ord.OrderId);
                    context.Orders.Remove(order);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Order GetOrderByOrderID(string ordID)
        {
            int id = int.Parse(ordID);
            Order order = new Order();
            try
            {
                using (var dbContext = new FStoreDBContext())
                {
                    order = dbContext.Orders.SingleOrDefault(o => o.OrderId == id);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return order;
        }

        public void SaveOrder(Order ord)
        {
            try
            {
                using (var context = new FStoreDBContext())
                {
                    context.Orders.Add(ord);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void UpdateOrder(Order ord)
        {
            try
            {
                using (var context = new FStoreDBContext())
                {
                    context.Entry<Order>(ord).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<Order> GetOrdersByMemberID(string memID)
        {
            int id = int.Parse(memID);
            List<Order> listOrder = null;
            try
            {
                using (var dbContext = new FStoreDBContext())
                {
                    listOrder = dbContext.Orders.Where(o => o.MemberId.Equals(id)).ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return listOrder;
        }

        public List<Order> GetOrderByDate(DateTime startDate, DateTime endDate)
        {
            List<Order> listOrder = null;
            try
            {
                using (var dbContext = new FStoreDBContext())
                {
                    listOrder = dbContext.Orders.Where(ord => ord.OrderDate.CompareTo(startDate) > 0 && ord.OrderDate.CompareTo(endDate) < 0).ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return listOrder;
        }

    }
}
