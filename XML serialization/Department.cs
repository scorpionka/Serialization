using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace XML_serialization
{
    [Serializable]
    public class Department
    {
        [XmlElement(ElementName = "Department")]
        public string DepartmentName { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
