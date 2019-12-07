using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using SCTIZEN.Utils;
using SCTIZEN.Models;
using Newtonsoft.Json;

namespace SCTIZEN.services
{
    public class RestService : IRestService
    {
        HttpClient _client;


        public RestService()
        {
            _client = new HttpClient();
        }



        public async Task<List<Video>> RefreshDataAsync()
        {

            var uri = new Uri(string.Format(Constants.VideoURL, string.Empty));

            var response = await _client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var Items = JsonConvert.DeserializeObject<List<Video>>(content);                
                return Items;
            }


            return null;

        }



    }
}
