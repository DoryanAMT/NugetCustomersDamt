using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using NugetCustomersDamt.Models;

namespace NugetCustomersDamt.Services
{
    public class ServiceCustomer
    {
        public async Task<CustomerList> GetCustomerListAsync()
        {
            WebClient client = new WebClient();
            client.Headers["contet-typ"] = "application/json";
            //  COPIAMOS LA URL COMPLETA PARA LOS CUSTOMERS
            string url = "https://northwind-api.miloudi.dev/v1/customers";
            string dataJson = await
                client.DownloadStringTaskAsync(url);
            CustomerList clients =
                JsonConvert.DeserializeObject<CustomerList>(dataJson);
            return clients;
        }
    }
}
