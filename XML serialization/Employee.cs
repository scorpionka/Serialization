using System;
using System.Xml.Serialization;

namespace XML_serialization
{
    [Serializable]
    public class Employee
    {
        [XmlElement(ElementName = "Employee first name")]
        public string EmployeeName { get; set; }
    }
}
