using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AtlasCompanyTracker
{
    public static class APIClient
    {
        private static readonly HttpClient client = new HttpClient();

        public static async Task<T> GetAsync<T>(string uri)
        {
            var data = "";
            var response = await client.GetAsync(uri);
            response.EnsureSuccessStatusCode();

            if (response.IsSuccessStatusCode)
                data = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<T>(data);
        }

        public static async Task<T> PostAsync<T>(string uri, T content)
        {
            var response = await client.PostAsJsonAsync(uri, content);
            response.EnsureSuccessStatusCode();
            var data = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(data);
        }

        public static async Task<T> UpdateProductAsync<T>(string uri, int id, T content)
        {
            var response = await client.PutAsJsonAsync($"{uri}{id}", content);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsAsync<T>();
        }

        public static async Task<HttpStatusCode> DeleteProductAsync(string uri, int id)
        {
            HttpResponseMessage response = await client.DeleteAsync($"{uri}{id}");
            return response.StatusCode;
        }
    }
}
