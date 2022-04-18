using OBiletAPP.Dtos.Request.Journey;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OBiletAPP.Dtos.Response.Journey
{
    public class JourneyResponse
    {
        public string Status { get; set; }

        [JsonPropertyName("data")]
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

    public class Data
    {
        public int Id { get; set; }

        [JsonPropertyName("partner-id")]
        public int PartnerId { get; set; }

        [JsonPropertyName("partner-name")]
        public string PartnerName { get; set; }

        [JsonPropertyName("route-id")]
        public int RouteId { get; set; }

        [JsonPropertyName("bus-type")]
        public string BusType { get; set; }

        [JsonPropertyName("bus-type-name")]
        public string BusTypeName { get; set; }

        [JsonPropertyName("total-seats")]
        public int TotalSeats { get; set; }

        [JsonPropertyName("available-seats")]
        public int AvailableSeats { get; set; }
        public Journey Journey { get; set; }
        public List<Feature> Features { get; set; }

        [JsonPropertyName("origin-location")]
        public string OriginLocation { get; set; }

        [JsonPropertyName("destination-location")]
        public string DestinationLocation { get; set; }

        [JsonPropertyName("is-active")]
        public bool IsActive { get; set; }

        [JsonPropertyName("origin-location-id")]
        public int OriginLocationId { get; set; }

        [JsonPropertyName("destination-location-id")]
        public int DestinationLocationId { get; set; }

        [JsonPropertyName("is-promoted")]
        public bool IsPromoted { get; set; }

        [JsonPropertyName("cancellation-offset")]
        public int? CancellationOffset { get; set; }

        [JsonPropertyName("has-bus-shuttle")]
        public bool HasBusShuttle { get; set; }

        [JsonPropertyName("disable-sales-without-gov-id")]
        public bool DisableSalesWithoutGovId { get; set; }

        [JsonPropertyName("display-offset")]
        public string DisplayOffset { get; set; }

        [JsonPropertyName("partner-rating")]
        public decimal? PartnerRating { get; set; }

        [JsonPropertyName("has-dynamic-pricing")]
        public bool HasDynamicPricing { get; set; }

        [JsonPropertyName("disable-sales-without-hes-code")]
        public bool DisableSalesWithoutHesCode { get; set; }

        [JsonPropertyName("disable-single-seat-selection")]
        public bool DisableSingleSeatSelection { get; set; }

        [JsonPropertyName("change-offset")]
        public int ChangeOffset { get; set; }
        public int? Rank { get; set; }

        [JsonPropertyName("display-coupon-code-input")]
        public bool DisplayCouponCodeInput { get; set; }

        [JsonPropertyName("disable-sales-without-date-of-birth")]
        public bool DisableSalesWithoutDateOfBirth { get; set; }
    }

    public class Stop
    {
        public string Name { get; set; }
        public string Station { get; set; }
        public string Time { get; set; }

        [JsonPropertyName("is-origin")]
        public bool IsOrigin { get; set; }

        [JsonPropertyName("is-destination")]
        public bool IsDestination { get; set; }
    }

    public class Policy
    {
        [JsonPropertyName("max-seats")]
        public int? MaxSeats { get; set; }

        [JsonPropertyName("max-single")]
        public int? MaxSingle { get; set; }

        [JsonPropertyName("max-single-males")]
        public int? MaxSingleMales { get; set; }

        [JsonPropertyName("max-single-females")]
        public int? MaxSingleFemales { get; set; }

        [JsonPropertyName("mixed-genders")]
        public bool MixedGenders { get; set; }

        [JsonPropertyName("gov-id")]
        public bool GovId { get; set; }
        public bool Lht { get; set; }
    }

    public class Journey
    {
        public string Kind { get; set; }
        public string Code { get; set; }
        public List<Stop> Stops { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public DateTime Departure { get; set; }
        public DateTime Arrival { get; set; }
        public string Currency { get; set; }
        public string Duration { get; set; }

        [JsonPropertyName("original-price")]
        public decimal OriginalPrice { get; set; }

        [JsonPropertyName("internet-price")]
        public decimal InternetPrice { get; set; }

        [JsonPropertyName("provider-internet-price")]
        public object ProviderInternetPrice { get; set; }
        public object Booking { get; set; }

        [JsonPropertyName("bus-name")]
        public string BusName { get; set; }
        public Policy Policy { get; set; }
        public List<string> Features { get; set; }
        public object Description { get; set; }
        public object Available { get; set; }
    }

    public class Feature
    {
        public int Id { get; set; }
        public byte? Priority { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        [JsonPropertyName("is-promoted")]
        public bool IsPromoted { get; set; }

        [JsonPropertyName("back-color")]
        public string BackColor { get; set; }

        [JsonPropertyName("fore-color")]
        public string ForeColor { get; set; }
    }


}
