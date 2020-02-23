using DemoProject.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Reflection;
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

        public GalleryModel GetGalleryModels()
        {
            GalleryModel gallery = new GalleryModel();
            try
            {
                var assembly = IntrospectionExtensions.GetTypeInfo(typeof(MainPage)).Assembly;
                Stream stream = assembly.GetManifestResourceStream("DemoProject.Json.Gallery.json");
                string text = string.Empty;
                using (var reader = new StreamReader(stream))
                {
                    text = reader.ReadToEnd();                    
                }
                gallery = JsonConvert.DeserializeObject<GalleryModel>(text);
            }
            catch(Exception ex)
            {

            }

            return gallery;
        }
    }
}
