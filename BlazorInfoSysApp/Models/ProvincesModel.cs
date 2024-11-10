

using System.Text.Json.Serialization;

namespace BlazorInfoSysApp.Models 
{
    public class Provinces {
        public long Id { get; set; }
        public string?  Name { get; set; }
        public long Code { get; set; }

        [JsonPropertyName("region_id")]
        public int RegionId { get; set; }
    }
}