

using System.Text.Json.Serialization;

namespace BlazorInfoSysApp.Models 
{
    public class Barangay {
        public long Id { get; set; }
        public string?  Name { get; set; }
        public long Code { get; set; }
        public string? Type {get; set;}
        
    }
}