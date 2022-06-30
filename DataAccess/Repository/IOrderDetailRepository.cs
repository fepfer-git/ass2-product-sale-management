using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IOrderDetailRepository
    {
        public List<OrderDetail> GetOrderDetailByOrderID(string ordID);
        public void DeleteOrderDetail(string orderID, string productID);
        public void UpdateOrderDetail(OrderDetail orderDetail);
        public void SaveOrderDetail(OrderDetail orderDetail);
        public OrderDetail CheckDuplicatedOrderDetail(string orderID, string productID);

    }
}
