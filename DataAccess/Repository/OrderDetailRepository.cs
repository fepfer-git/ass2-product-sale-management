using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        public OrderDetail CheckDuplicatedOrderDetail(string orderID, string productID)
            => OrderDetailDAO.Instance.CheckDuplicatedOrderDetail(orderID, productID);

        public void DeleteOrderDetail(string orderID, string productID)
            => OrderDetailDAO.Instance.DeleteOrderDetail(orderID, productID);

        public List<OrderDetail> GetOrderDetailByOrderID(string ordID)
            => OrderDetailDAO.Instance.GetOrderDetailByOrderID(ordID);

        public void SaveOrderDetail(OrderDetail orderDetail) => OrderDetailDAO.Instance.SaveOrderDetail(orderDetail);

        public void UpdateOrderDetail(OrderDetail orderDetail) => OrderDetailDAO.Instance.UpdateOrderDetail(orderDetail);
    }
}
