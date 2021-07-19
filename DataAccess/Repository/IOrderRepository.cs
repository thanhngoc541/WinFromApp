using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IOrderRepository
    {
        List<Order> GetOrders();
        Order GetOrderByID(int Id);
        void InsertOrder(Order Order);
        void DeleteOrder(int Id);
        void UpdateOrder(Order Order);

    }
}
