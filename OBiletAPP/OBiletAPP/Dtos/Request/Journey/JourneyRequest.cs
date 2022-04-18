using System.Text.Json.Serialization;

namespace OBiletAPP.Dtos.Request.Journey
{
    public class JourneyRequest
    {
        [JsonPropertyName("device-session")]
        public DeviceSession DeviceSession { get; set; }
        public string Date { get; set; }
        public string Language { get; set; }
        public Data Data { get; set; }

    }

    public class DeviceSession
    {
        [JsonPropertyName("session-id")]
        public string SessionId { get; set; }

        [JsonPropertyName("device-id")]
        public string DeviceId { get; set; }
    }

    public class Data
    {
        [JsonPropertyName("origin-id")]
        public int OriginId { get; set; }

        [JsonPropertyName("destination-id")]
        public int DestinationId { get; set; }

        [JsonPropertyName("departure-date")]
        public string DepartureDate { get; set; }
    }
}
