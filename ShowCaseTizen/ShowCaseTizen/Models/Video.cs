using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace ShowCaseTizen
{

    public class Video
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("nombre")]
        public string Nombre { get; set; }

        [JsonProperty("descripcion")]
        public string Descripcion { get; set; }

        [JsonProperty("videofile")]
        public Uri Videofile { get; set; }

        [JsonProperty("company")]
        public Uri[] Company { get; set; }

        [JsonProperty("video_url")]
        public object VideoUrl { get; set; }

        [JsonProperty("creado")]
        public DateTimeOffset Creado { get; set; }
    }

    public class VideoJson
    {
        public int count { get; set; }
        public string next { get; set; }
        public string previous { get; set; }
        public List<Video> results { get; set; }
    }
}
