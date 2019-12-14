using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Services.Abstract;

namespace WebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManufacturerController : ControllerBase
    {
       
        private readonly IManufacturerService _manufacturerService;
        public ManufacturerController(IManufacturerService manufacturerService)
        {
            _manufacturerService = manufacturerService;
        }

        //todo: create a method to return all manufacturers and number of models for these manufacturers


        //todo: Create a method to get manufacturer name by model
        //[HttpGet("[action]")]
        [HttpGet]
        public IActionResult GetManufacturerByModel(string model)
        {
           // _manufacturerService.GetManufacturersWithModelCount();
            return Ok(_manufacturerService.GetManufacturerByModel(model));
        }




    }
}