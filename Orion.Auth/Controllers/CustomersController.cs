using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Orion.Auth.Models;
using Microsoft.AspNetCore.Authorization;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Orion.Auth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CustomersController : ControllerBase
    {
        private static readonly List<CustomerModel> customers = new List<CustomerModel>
        {
            new CustomerModel(){ Id = 1, Name = "Customer 1", Address = "Address 1", City = "City 1", Phone = "Phone 1", Email = "Email 1" },
            new CustomerModel(){ Id = 2, Name = "Customer 2", Address = "Address 2", City = "City 2", Phone = "Phone 2", Email = "Email 2" },
            new CustomerModel(){ Id = 3, Name = "Customer 3", Address = "Address 3", City = "City 3", Phone = "Phone 3", Email = "Email 3" },
            new CustomerModel(){ Id = 4, Name = "Customer 4", Address = "Address 4", City = "City 4", Phone = "Phone 4", Email = "Email 4" }
        };

        // GET: api/<CustomersController>
        [HttpGet]
        public IEnumerable<CustomerModel> Get()
        {
            return customers;
        }

        // GET api/<CustomersController>/5
        [HttpGet("{id}")]
        public CustomerModel Get(int id)
        {
            return customers.First(x => x.Id == id);
        }

        // POST api/<CustomersController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CustomersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CustomersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
