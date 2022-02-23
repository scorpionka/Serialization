using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Json_serialization
{
    public class Department
    {
        [JsonPropertyName("Department")]
        public string DepartmentName { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
