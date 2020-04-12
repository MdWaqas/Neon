using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Neon.FinanceBridge.Application.Commands.Customer;
using Neon.FinanceBridge.Domain.Models;
using Neon.FinanceBridge.Domain.Services;

namespace Neon.FinanceBridge.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService customerService;
        private readonly IMediator mediator;
        public CustomerController(ICustomerService customerService)
        {
            this.customerService = customerService;
        }

        // GET: api/Customer
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return customerService.GetAll();
        }

        // GET: api/Customer/5
        [HttpGet("{id}", Name = "Get")]
        public Customer Get(int id)
        {
            return customerService.GetById(id);
        }

        // POST: api/Customer
        [HttpPost]
        public void Post([FromBody] AddCustomerCommand cmd, CancellationToken cancellationToken)
        {
        }

        // PUT: api/Customer/5
        [HttpPut("{id}")]
        public void Put([FromBody] UpdateCustomerCommand cmd, CancellationToken cancellationToken)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete([FromBody] DeleteCustomerCommand cmd, CancellationToken cancellationToken)
        {
        }
    }
}
