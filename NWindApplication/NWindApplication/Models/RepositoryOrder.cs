using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace NWindApplication.Models
{
    public class RepositoryOrder
    {
        // from each obj o in order collections if the current obj o is custid is equivalent to the parameter skip that collection - LINQ
        private readonly NorthwindContext _context;
        //public int SelectedId { get; set; } // each id
        //public List<SelectListItem> OrderSelectView { get; set; }


        //public RepositoryOrder() { }
        public RepositoryOrder(NorthwindContext context)
        {
            _context = context;
        }
        public Order FindOrderById(int id)
        {
            var order = _context.Orders.Find(id);
            return order;
        }

        //public List<Order> Orders()
        //{
        //    return _context.Orders.ToList();
        //}
        public List<int> GetAllOrderId()
        {
            List<int> orderIds = new List<int>();
            foreach (var order in _context.Orders)
            {
                orderIds.Add(order.OrderId);
            }
            return orderIds;
        }
		public List<OrderDetail> FindOrderDetailByOrderId(int id)
		{
			//Order order = _context.Orders.Find(id);
			//return order.OrderDetails.ToList(); //for every single order there are order details
												//using order object we will fetch order based on the object

                List<Order> ordersWithOrderDetails =_context.Orders.Include(d=>d.OrderDetails).ToList();
                Order order=ordersWithOrderDetails.FirstOrDefault(x=>x.OrderId==id);
                return order.OrderDetails.ToList();
		}

	}
}
