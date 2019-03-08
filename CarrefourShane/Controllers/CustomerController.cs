using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarrefourShane.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarrefourShane.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            var str = "冲突制造1";
            _customerService = customerService;
        }

    }
}