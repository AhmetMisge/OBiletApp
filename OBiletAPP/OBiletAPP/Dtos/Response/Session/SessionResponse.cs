using System.Text.Json.Serialization;

namespace OBiletAPP.Dtos.Response.Session
{
    public class Data
    {
        [JsonPropertyName("session-id")]
        public string SessionId { get; set; }

        [JsonPropertyName("device-id")]
        public string DeviceId { get; set; }

        public string Affiliate { get; set; }

        [JsonPropertyName("device-type")]
        public int DeviceType { get; set; }

        public string Device { get; set; }
    }

    public class SessionResponse
    {
        public string Status { get; set; }
        public Data Data { get; set; }
        public string Message { get; set; }

        [JsonPropertyName("user-message")]
        public string UserMessage { get; set; }

        [JsonPropertyName("api-request-id")]
        public string ApiRequestId { get; set; }

        public string Controller { get; set; }

        [JsonPropertyName("client-request-id")]
        public string ClientRequestId { get; set; }
    }
}