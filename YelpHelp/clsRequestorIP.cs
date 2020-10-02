using Newtonsoft.Json;
using System.Collections.Generic;

namespace YelpHelp
{
    class clsRequestorIP
    {
        [JsonProperty("ip")]
        public string IP { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("continent_code")]
        public string ContinentCode { get; set; }

        [JsonProperty("continent_name")]
        public string ContinentName { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("country_name")]
        public string CountryName { get; set; }

        [JsonProperty("region_code")]
        public string RegionCode { get; set; }

        [JsonProperty("region_name")]
        public string RegionName { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }

        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        [JsonProperty("longitude")]
        public string Longitude { get; set; }

        [JsonProperty("location")]
        public clsIPLocation Location { get; set; }
    }

    public class clsIPLocation
    {
        [JsonProperty("geoname_id")]
        public string GeoNameId { get; set; }

        [JsonProperty("capital")]
        public string Capital { get; set; }

        [JsonProperty("languages")]
        public List<clsLanguages> LangugesList { get; set; }

        [JsonProperty("country_flag")]
        public string CountryFlag { get; set; }

        [JsonProperty("country_flag_emoji")]
        public string CountryFlagEmoji { get; set; }

        [JsonProperty("country_flag_emoji_unicode")]
        public string CountryFlagEmojiUniCode { get; set; }

        [JsonProperty("calling_code")]
        public string CallingCode { get; set; }

        [JsonProperty("is_eu")]
        public string IsEU { get; set; }
    }

    public class clsLanguages
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("native")]
        public string Native { get; set; }
    }
}
