using System;
using System.Collections.Generic;

namespace Binary_serialization
{
    [Serializable]
    public class Department
    {
        public Department(string departmentName)
        {
            DepartmentName = departmentName;
        }

        public string DepartmentName { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
