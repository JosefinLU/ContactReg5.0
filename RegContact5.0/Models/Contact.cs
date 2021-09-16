using System;
using System.Text.Json;

namespace RegContact5._0.Models
{
    public class Contact
    {
        // properties  getters and setters
        public string Name { get; set; }
        public string Title { get; set; }
        public string Telephone { get; set; }
        public int CompanyId { get; }

        //Constructor
        public Contact(string name, string title, string telephone, int companyId)
        {
            this.Name = name;
            this.Title = title;
            this.Telephone = telephone;
            this.CompanyId = companyId;
        }

        //serialize the object to Json
        public override string ToString()
        {
            return JsonSerializer.Serialize<Contact>(this);
        }
    }
}
