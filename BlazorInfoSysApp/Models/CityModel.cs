

using System.Text.Json.Serialization;

namespace BlazorInfoSysApp.Models 
{
    public class City {
        public long Id { get; set; }
        public string?  Name { get; set; }
        public long Code { get; set; }
        public string? Type {get; set;}
        [JsonPropertyName("region_id")]
        public int RegionId {get; set;}
        [JsonPropertyName("province_id")]
        public int ProvinceId { get; set; }
        
    }
}