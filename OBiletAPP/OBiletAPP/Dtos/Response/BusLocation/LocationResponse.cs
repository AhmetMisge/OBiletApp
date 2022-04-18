using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OBiletAPP.Dtos.Response.BusLocation
{
    public class LocationResponse
    {
        public string Status { get; set; }
        public List<Data> Data { get; set; }
        public string Message { get; set; }

        [JsonPropertyName("user-message")]
        public string UserMessage { get; set; }

        [JsonPropertyName("api-request-id")]
        public string ApiRequestId { get; set; }
        public string Controller { get; set; }

        [JsonPropertyName("client-request-id")]
        public object ClientRequestId { get; set; }
    }
    public class GeoLocation
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int Zoom { get; set; }
    }

    public class Data
    {
        public int Id { get; set; }

        [JsonPropertyName("parent-id")]
        public int? ParentId { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }

        [JsonPropertyName("geo-location")]
        public GeoLocation GeoLocation { get; set; }
        public int Zoom { get; set; }

        [JsonPropertyName("tz-code")]
        public string TzCode { get; set; }

        [JsonPropertyName("weather-code")]
        public string WeatherCode { get; set; }
        public int? Rank { get; set; }

        [JsonPropertyName("reference-code")]
        public string ReferenceCode { get; set; }
        public string Keywords { get; set; }
    }







    //    public int ID { get; set; }

    //    [JsonPropertyName("parent-id")]
    //    public int ParentID { get; set; }
    //    public bool Type { get; set; }
    //    public string Name { get; set; }

    //    [JsonPropertyName("geo-location")]
    //    public GeoLocation GeoLocation { get; set; }
    //    public int Zoom { get; set; }

    //    [JsonPropertyName("tz-code")]
    //    public string tzCode { get; set; }

    //    [JsonPropertyName("weather-code")]
    //    public string WeatherCode { get; set; }
    //    public int Rank { get; set; }

    //    [JsonPropertyName("reference-code")]
    //    public string ReferenceCode { get; set; }
    //    public string Keywords { get; set; }

    //}
    //public class GeoLocation
    //{
    //    public int Latitude { get; set; }
    //    public int Longtitude { get; set; }
    //    public int Zoom { get; set; }



}
