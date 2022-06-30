using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IOrderRepository
    {
        public List<Order> GetOrders();
        public void DeleteOrder(Order ord);
        public Order GetOrderByOrderID(string ordID);
        public void SaveOrder(Order ord);
        public void UpdateOrder(Order ord);
        public List<Order> GetOrdersByMemberID(string memID);
        public List<Order> GetOrderByDate(DateTime startDate, DateTime endDate);
    }
}
