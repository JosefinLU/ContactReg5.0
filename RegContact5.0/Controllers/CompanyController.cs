﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RegContact5._0.Models;
using RegContact5._0.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RegContact5._0.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : Controller
    {
        // add properties and constructor

        public JsonFileCompanyService CompanyService { get; }

        public CompanyController(JsonFileCompanyService companyService)
        {
            this.CompanyService = companyService;
        }


        // GET: api/values
        // CompanyController = Compnay in url --> localhost:5001/Company
        [Route("/Company")]
        [HttpGet]
        public List<Company> Get()
        {
            // Getting all the companies
            Console.WriteLine("Andres Canal");
            return CompanyService.GetCompany();
        }





        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
