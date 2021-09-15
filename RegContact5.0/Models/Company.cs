using System;
using System.Text.Json;

namespace RegContact5._0.Models
{
    public class Company
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public Company(string name, string address)
        {
            this.Name = name;
            this.Address = address;
        }
        public override string ToString()
        {
            return JsonSerializer.Serialize<Company>(this);
        }
    }
}
