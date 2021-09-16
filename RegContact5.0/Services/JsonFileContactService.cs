using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Microsoft.AspNetCore.Hosting;
using RegContact5._0.Models;
using RegContact5._0.Services;

namespace RegContact5._0.Services
{
    public class JsonFileContactService
    {
        // JL The Serive has the job to get us a list of Contacts
        // AND we tell that this service exist in Startup.cs (generated auto)
        public IWebHostEnvironment WebHostEnvironment { get; }

        // Constructor
        public JsonFileContactService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        // Define where to find the JsonFile
        private string JsonFileName
        {
            get
            {
                return Path.Combine(WebHostEnvironment.WebRootPath, "data", "Contact.json");
            }
        }

        // Open, READ and validation of the file
        public List<Contact> GetContact()
        {
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<List<Contact>>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        // Ignores uperandlowercase structure
                        PropertyNameCaseInsensitive = true
                    });
            }
        }

        // Write to Jsonfile, create a method

        // Method to match contact and company
        public List<Contact> GetContactsForCompany(int companyId)
        {
            var contacts = GetContact();
            List<Contact> contactsForCompany = new List<Contact>();

                foreach (var contact in contacts)
                {
                    if (companyId == contact.CompanyId)
                    {
                        contactsForCompany.Add(contact);
                    }
                }
                return contactsForCompany;

        }
    }
}
