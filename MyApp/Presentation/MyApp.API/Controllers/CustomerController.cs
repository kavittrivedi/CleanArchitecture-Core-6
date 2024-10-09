using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyApp.Application.Services;
using MyApp.Core.Entities;

namespace MyApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly CustomerService _customerService;

        public CustomerController(CustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet("{id}")]
        public ActionResult<Customer> GetCustomerById(int id)
        {
            var customer = _customerService.GetCustomerById(id);
            if (customer == null) return NotFound();
            return Ok(customer);
        }

        [HttpPost]
        public ActionResult AddCustomer(Customer customer)
        {
            _customerService.AddCustomer(customer);
            return Ok();
        }
    }
}
