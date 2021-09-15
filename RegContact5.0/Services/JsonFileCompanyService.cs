using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Microsoft.AspNetCore.Hosting;
using RegContact5._0.Models;

namespace RegContact5._0.Services
{
    public class JsonFileCompanyService
    {
        // Constructor for the web/Host
        public JsonFileCompanyService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        // where the JasonFile is located/alt you can hardcode it
        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "Company.json"); }
        }

        // retriving the data, converting the jsontext to product - deserialize (json - object)
        // IEnumerable - Grandparent of List, stuff you can foreach over
        public IEnumerable<Company> GetCompany()
        {
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<Company[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        // Ignores uperandlowercase structure
                        PropertyNameCaseInsensitive = true
                    });
            }
        }
    }
}
