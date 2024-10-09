using MyApp.Core.Entities;
using MyApp.Core.Interfaces;
using MyApp.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Infrastructure.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly CustomerDbContext _context;

        public CustomerRepository(CustomerDbContext context)
        {
            _context = context;
        }

        public Customer GetCustomerById(int id)
        {
            return _context.Customers.Find(id); // Using EF Core to fetch customer by Id
        }

        public void AddCustomer(Customer customer)
        {
            _context.Customers.Add(customer);   // Add customer to the DbContext
            _context.SaveChanges();             // Save changes to the database
        }
    }
}
