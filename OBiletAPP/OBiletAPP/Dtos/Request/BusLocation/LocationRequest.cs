using System;
using System.Text.Json.Serialization;

namespace OBiletAPP.Dtos.Request.BusLocation
{
    public class LocationRequest
    {
        public string Data { get; set; }

        [JsonPropertyName("device-session")]
        public DeviceSession DeviceSession { get; set; }
        public string Date { get; set; }
        public string Language { get; set; }
        
    }

    public class DeviceSession
    {
        [JsonPropertyName("session-id")]
        public string SessionID { get; set; }

        [JsonPropertyName("device-id")]
        public string DeviceID { get; set; }
    }
}
