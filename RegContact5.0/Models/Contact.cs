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

        //Constructor
        public Contact(string name, string title, string telephone)
        {
            this.Name = name;
            this.Title = title;
            this.Telephone = telephone;
        }

        //serialize the object to Json
        public override string ToString()
        {
            return JsonSerializer.Serialize<Contact>(this);
        }
    }
}
