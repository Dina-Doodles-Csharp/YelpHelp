using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YelpHelp
{
    class clsBusinessResults
    {

        [JsonProperty("businesses")]
        public List<Business> BusinessList { get; set; }

        [JsonProperty("total")]
        public string TotalPage { get; set; }

        [JsonProperty("region")]
        public clsRegion Region { get; set; }
    }

    class Business
    {
        [JsonProperty("id")]
        public string BusinessId { get; set; }

        [JsonProperty("alias")]
        public string Alias { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("image_url")]
        public string Image_Url { get; set; }

        [JsonProperty("is_closed")]
        public string Is_Closed { get; set; }

        [JsonProperty("url")]
        public string URL { get; set; }

        [JsonProperty("review_count")]
        public string Review_Count { get; set; }

        [JsonProperty("categories")]
        public List<Category> Categories { get; set; }

        [JsonProperty("rating")]
        public string Rating { get; set; }

        [JsonProperty("coordinates")]
        public clsCoOrdiates CoOrdiates { get; set; }

        [JsonProperty("transactions")]
        public string[] Transactions { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("location")]
        public clsLocation Location { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("display_phone")]
        public string Display_Phone { get; set; }

        [JsonProperty("distance")]
        public string Distance { get; set; }
    }

    public class clsCoOrdiates
    {
        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        [JsonProperty("longitude")]
        public string Longitude { get; set; }
    }

    public class clsLocation
    {
        [JsonProperty("address1")]
        public string Address1 { get; set; }

        [JsonProperty("address2")]
        public string Address2 { get; set; }

        [JsonProperty("address3")]
        public string Address3 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("zip_code")]
        public string Zip_Code { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("display_address")]
        public string[] Display_address { get; set; }
    }

    public class clsRegion
    {
        [JsonProperty("center")]
        public clsCenter Center { get; set; }
    }

    public class clsCenter
    {
        [JsonProperty("longitude")]
        public string Longitude { get; set; }

        [JsonProperty("latitude")]
        public string Latitude { get; set; }
    }
}
