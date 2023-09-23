using Microsoft.EntityFrameworkCore;

namespace NWindApplication.Models
{
    public class RepositoryCustomer
    {
        private readonly NorthwindContext _context;
        public List<string> GetAllCustomerId()
        {
            List<string> custIds = new List<string>();
            foreach (var customer in _context.Customers)
            {
                custIds.Add(customer.CustomerId);
            }
            return custIds;
        }
        public RepositoryCustomer(NorthwindContext context)
        {
            _context = context;
        }
        public Customer FindCustomerById(string id)
        {
            var order = _context.Customers.Find(id);
            return order;
        }
      
       
        public List<Order> FindCustomersDetailbyOrders(string id) {
            //{
            //    Customer customer = _context.Customers.Find(id);
            //      return customer.Orders.ToList();

            //Customer customer = _context.Customers.Find(id);
            //// return order.OrderQries.ToList();
            //return customer.OrdersQries.ToString();

            //Order order = _context.Orders.Find(id);
            //return order.OrderDetails.ToList();

            List<Customer> ordersWithOrderDetails = _context.Customers.Include(d => d.Orders).ToList();
            Customer cust = ordersWithOrderDetails.FirstOrDefault(x => x.CustomerId == id);
            return cust.Orders.ToList();

           
        }

    }
}
