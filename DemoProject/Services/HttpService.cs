using DemoProject.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace DemoProject.Services
{
    public class HttpService
    {
        public async Task<List<ClientModel>> GetClientsAsync()
        {
            List<ClientModel> clients = new List<ClientModel>();
            try
            {
                const string Url = "https://jsonplaceholder.typicode.com/users";
                HttpClient _httpClient = new HttpClient();

                var content = await _httpClient.GetStringAsync(Url);
                clients = JsonConvert.DeserializeObject<List<ClientModel>>(content);

            }
            catch (Exception ex)
            {

            }

            return clients;
        }
    }
}
