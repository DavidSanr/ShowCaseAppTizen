using Newtonsoft.Json;
using System.Net.Http;

namespace ShowCaseTizen
{
    public static class RestService
    {
        public static VideoJson GetVideos()
        {
            HttpClient _client = new HttpClient();

            HttpResponseMessage responseMessage = _client.GetAsync("http://192.241.158.208/api/videos/").Result;

            var response = responseMessage.Content.ReadAsStringAsync().Result;

            return JsonConvert.DeserializeObject<VideoJson>(response);
        }
    }
}
