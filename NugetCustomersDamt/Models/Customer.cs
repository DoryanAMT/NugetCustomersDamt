using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NugetCustomersDamt.Models
{
    public class Customer
    {
        [JsonProperty("CustomerID")]
        public string IdCustomer { get; set; }
        [JsonProperty("ContactName")]
        public string Contacto { get; set; }
        [JsonProperty("CompanyName")]
        public string Empresa { get; set; }
        [JsonProperty("address")]
        public string Direccion { get; set; }

    }
}
