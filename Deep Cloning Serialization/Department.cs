using System;
using System.Collections.Generic;

namespace Deep_Cloning_Serialization
{
    [Serializable]
    public class Department
    {
        public string DepartmentName { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
