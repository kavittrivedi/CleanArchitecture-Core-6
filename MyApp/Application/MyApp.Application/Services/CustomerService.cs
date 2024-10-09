using MyApp.Core.Entities;
using MyApp.Core.Interfaces;
namespace MyApp.Application.Services
{
    public class CustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public Customer GetCustomerById(int id)
        {
            return _customerRepository.GetCustomerById(id);
        }

        public void AddCustomer(Customer customer)
        {
            _customerRepository.AddCustomer(customer);
        }
    }
}
