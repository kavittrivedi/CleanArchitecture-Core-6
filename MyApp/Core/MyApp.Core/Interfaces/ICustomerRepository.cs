using MyApp.Core.Entities;

namespace MyApp.Core.Interfaces
{
    public interface ICustomerRepository
    {
        Customer GetCustomerById(int id);
        void AddCustomer(Customer customer);
    }
}
