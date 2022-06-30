using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    class OrderDetailDAO
    {
        private static OrderDetailDAO instance = null;
        private static readonly object instanceLock = new object();

        private OrderDetailDAO() { }
        public static OrderDetailDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDetailDAO();
                    }
                    return instance;
                }
            }
        }

        public List<OrderDetail> GetOrderDetailByOrderID(string ordID)
        {
            List<OrderDetail> listOrderDetail = new List<OrderDetail>();
            try
            {
                using (var context = new FStoreDBContext())
                {
                    listOrderDetail = context.OrderDetails.Where(o => o.OrderId.Equals(int.Parse(ordID))).ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return listOrderDetail;
        }

        public void DeleteOrderDetail(string orderID, string productID)
        {
            try
            {
                using (var context = new FStoreDBContext())
                {
                    var orderDetail = context.OrderDetails.SingleOrDefault(c => c.ProductId.Equals(int.Parse(productID)) && c.OrderId.Equals(int.Parse(orderID)));
                    context.OrderDetails.Remove(orderDetail);

                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void UpdateOrderDetail(OrderDetail orderDetail)
        {
            try
            {
                using (var context = new FStoreDBContext())
                {
                    context.Entry<OrderDetail>(orderDetail).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void SaveOrderDetail(OrderDetail orderDetail)
        {
            try
            {
                using (var context = new FStoreDBContext())
                {
                    context.OrderDetails.Add(orderDetail);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public OrderDetail CheckDuplicatedOrderDetail(string orderID, string productID)
        {
            OrderDetail orderDetail = new OrderDetail();

            try
            {
                using (var dbContext = new FStoreDBContext())
                {
                    orderDetail = dbContext.OrderDetails.SingleOrDefault
                        (ord => ord.ProductId.Equals(int.Parse(productID)) && ord.OrderId.Equals(int.Parse(orderID)));
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return orderDetail;
        }


    }
}
