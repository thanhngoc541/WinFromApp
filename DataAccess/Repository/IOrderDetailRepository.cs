using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IOrderDetailRepository
    {
        List<OrderDetail> GetOrderDetails();
        OrderDetail GetOrderDetail(int OrderId, int ProductId);
        void InsertOrderDetail(OrderDetail OrderDetail);
        void DeleteOrderDetail(int OrderId, int ProductId);
        void UpdateOrderDetail(OrderDetail OrderDetail);

    }
}
