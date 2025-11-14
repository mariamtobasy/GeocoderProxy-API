using System.Text.Json.Serialization;

namespace GeocoderProxy.Models
{
    public class GeocodeRequest
    {
        [JsonPropertyName("address")]
        public string Address { get; set; }

        [JsonPropertyName("consignee_tel")]
        public string ConsigneeTel { get; set; }

        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("dest_city")]
        public string DestCity { get; set; }

        [JsonPropertyName("dest_country")]
        public string DestCountry { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}

