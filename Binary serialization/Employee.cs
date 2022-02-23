using System;

namespace Binary_serialization
{
    [Serializable]
    public class Employee
    {
        public Employee(string employeeName)
        {
            EmployeeName = employeeName;
        }

        public string EmployeeName { get; set; }
    }
}
