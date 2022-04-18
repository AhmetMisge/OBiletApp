using Microsoft.Extensions.Configuration;
using OBiletAPP.Dtos.Request.BusLocation;
using OBiletAPP.Dtos.Response.BusLocation;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using OBiletAPP.Dtos.Request.Session;
using OBiletAPP.Dtos.Response.Session;
using OBiletAPP.Dtos.Response.Journey;
using OBiletAPP.Dtos.Request.Journey;

namespace OBiletAPP.Clients
{
    public class OBiletClient
    {
        private HttpClient _client;

        private readonly string _baseUrl;
        private readonly string _token;

        private readonly IConfiguration _configuration;

        public OBiletClient(
            HttpClient client,
            IConfiguration configuration)
        {
            _client = client;
            _configuration = configuration;
            _baseUrl = "https://v2-api.obilet.com/api";
            _token = "JEcYcEMyantZV095WVc3G2JtVjNZbWx1";
        }

        public async Task<SessionResponse> GetSession()
        {
            _client.DefaultRequestHeaders.Add("Authorization", "Basic " + _token);

            var request = new SessionRequest
            {
                Type = 1,
                Connection = new Connection
                {
                    IpAddress = "165.114.41.21",
                    Port = "5117"
                },
                Browser = new Browser
                {
                    Name = "Chrome",
                    Version = "47.0.0.12"
                }
            };

            var httpResponse = await _client.PostAsJsonAsync(
                "https://v2-api.obilet.com/api/client/getsession", request);

            var result = await httpResponse.Content.ReadFromJsonAsync<SessionResponse>();
            return result;
        }

        public async Task<LocationResponse> GetBusLocation()
        {
            _client.DefaultRequestHeaders.Add("Authorization", "Basic " + _token);

            var request = new LocationRequest
            {
                Data = null,
                DeviceSession = new Dtos.Request.BusLocation.DeviceSession
                {
                    SessionID = "PqtdftjloK3Kpka97+ILDzMa6D9740nggLiTzXiLlzA=",
                    DeviceID = "PqtdftjloK3Kpka97+ILDzMa6D9740nggLiTzXiLlzA="
                },
                Date = "2016-03-11T11:33:00",
                Language = "tr-TR"

            };

            var httpResponse = await _client.PostAsJsonAsync(
                "https://v2-api.obilet.com/api/location/getbuslocations", request);

            var result = await httpResponse.Content.ReadFromJsonAsync<LocationResponse>();

            return result;

        }

        public async Task<JourneyResponse> GetJourney(int originID, int destinationID, string date)
        {
            _client.DefaultRequestHeaders.Add("Authorization", "Basic " + _token);

            var request = new JourneyRequest
            {
                DeviceSession = new Dtos.Request.Journey.DeviceSession
                {
                    SessionId = "HUh+gCZCdaY0re+RHySV4FdGQ6fRWjxmd97y2HRSnaY=",
                    DeviceId = "yDl/pOon17r0axDRHBUg60GGVf+LvTwUCEyZsvnYmlA="
                },
                Date = date,
                Language = "tr-TR",
                Data = new Dtos.Request.Journey.Data
                {
                    OriginId = originID,
                    DestinationId = destinationID,
                    DepartureDate = date
                }
            };

            var httpResponse = await _client.PostAsJsonAsync(
                "https://v2-api.obilet.com/api/journey/getbusjourneys", request);

            var result = await httpResponse.Content.ReadFromJsonAsync<JourneyResponse>();

            return result;
        }
    }
}