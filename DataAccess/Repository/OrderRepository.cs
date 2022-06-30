using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderRepository : IOrderRepository
    {
        public void DeleteOrder(Order ord) => OrderDAO.Instance.DeleteOrder(ord);

        public List<Order> GetOrderByDate(DateTime startDate, DateTime endDate) => OrderDAO.Instance.GetOrderByDate(startDate, endDate);

        public Order GetOrderByOrderID(string ordID) => OrderDAO.Instance.GetOrderByOrderID(ordID);

        public List<Order> GetOrders() => OrderDAO.Instance.GetOrders();

        public List<Order> GetOrdersByMemberID(string memID) => OrderDAO.Instance.GetOrdersByMemberID(memID);

        public void SaveOrder(Order ord) => OrderDAO.Instance.SaveOrder(ord);

        public void UpdateOrder(Order ord) => OrderDAO.Instance.UpdateOrder(ord);
    }
}
