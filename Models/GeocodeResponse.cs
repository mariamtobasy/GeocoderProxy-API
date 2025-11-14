using System.Text.Json.Serialization;

namespace GeocoderProxy.Models
{
    public class GeocodeResponse
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("predicted_address_quality")]
        public string PredictedAddressQuality { get; set; }

        [JsonPropertyName("best_geocode_accuracy_category")]
        public string BestGeocodeAccuracyCategory { get; set; }

        [JsonPropertyName("best_geocode_source")]
        public string BestGeocodeSource { get; set; }

        [JsonPropertyName("best_latitude")]
        public double BestLatitude { get; set; }

        [JsonPropertyName("best_longitude")]
        public double BestLongitude { get; set; }
    }
}
