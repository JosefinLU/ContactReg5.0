using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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
    public class ContactController : Controller
    {

        // Properties and constructor, why is a constructor needed?
        // when use set in this case of?

        public JsonFileContactService ContactService { get; }

        public ContactController(JsonFileContactService contactService)
        {
            this.ContactService = contactService;
        }


        // GET: api/values
        //ContactController
        [Route("/Contact")]
        [HttpGet]
        public List<Contact> Get()
        {
            Console.WriteLine("ContactJL");
            return ContactService.GetContact();
        }


        [Route("/Companies/{CompanyId}")] //localhost:5001/Contact/CompanyName?CompanyName=Shanti
        [HttpGet]
        public List<Contact> Get(int CompanyId)
        {
            // Skicka in den parameter som du lägger i urlen, ex localhost:5001/Companies/1
            return ContactService.GetContactsForCompany(CompanyId);
        }






        // GET api/values/5
        [HttpGet("{id}")]
        /*public string Get(int id)
        {
            return "value";
        }*/

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
