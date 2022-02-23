using System.Text.Json.Serialization;

namespace Json_serialization
{
    public class Employee
    {
        [JsonPropertyName("Employee first name")]
        public string EmployeeName { get; set; }
    }
}
