using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Microsoft.AspNetCore.Hosting;
using RegContact5._0.Models;

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
    }
}
