namespace NWindApplication.Models
{
    public class RepositoryEmployee
    {
        private NorthwindContext _context; //instation should be done otherwise null pointer exception will come
        public RepositoryEmployee(NorthwindContext context)
        {
            _context = context;
        }

        public List<Employee> AllEmployee()
        {
            return  _context.Employees.ToList();
        }
    }
}
