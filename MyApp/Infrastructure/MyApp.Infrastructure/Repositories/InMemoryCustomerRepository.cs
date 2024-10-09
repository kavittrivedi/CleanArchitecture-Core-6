using MyApp.Core.Entities;
using MyApp.Core.Interfaces;

namespace MyApp.Infrastructure.Repositories
{
    public class InMemoryCustomerRepository : ICustomerRepository
    {
        private readonly List<Customer> _customers = new List<Customer>();

        public Customer GetCustomerById(int id)
        {
            return _customers.FirstOrDefault(c => c.Id == id);
        }

        public void AddCustomer(Customer customer)
        {
            customer.Id = _customers.Count + 1; // Simple auto-increment
            _customers.Add(customer);
        }
    }
}
