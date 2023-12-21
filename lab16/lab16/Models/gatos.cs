using Newtonsoft.Json;
using System;

namespace lab16.Models
{
    public class Gatos
    {
        public string nombre { get; set; }
        public string caracteristicas { get; set; }
        public string tamano { get; set; }

        [JsonProperty("imagen")]
        public string imagen { get; set; }
    }

    public class GatosResponse
    {
        public Gatos[] Gatos { get; set; }
    }
}
