using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NugetCustomersDamt.Models
{
    public class CustomerList
    {
        [JsonProperty("data")]
        public List<Customer> Customers { get; set; }
    }
}
