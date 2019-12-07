

namespace SCTIZEN.Models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public  class Video
    {
        [JsonProperty("id")]
        public long Id { get; set; }

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

  

    
}
