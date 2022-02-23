using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace XML_serialization
{
    internal class Program
    {
        static void Main()
        {
            Department department = new Department() { DepartmentName = "Accounting" };
            department.Employees = new List<Employee> {
                new Employee() { EmployeeName = "Petrovna" },
                new Employee() { EmployeeName = "Mar'yaVanna" }
            };

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Department));

            using (FileStream fs = new FileStream("department.xml", FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fs, department);
            }

            using (FileStream fs = new FileStream("department.xml", FileMode.OpenOrCreate))
            {
#nullable enable
                Department? newDepartment = xmlSerializer.Deserialize(fs) as Department;
#nullable disable
                Console.WriteLine($"Department name: {newDepartment.DepartmentName}:");

                foreach (Employee employee in newDepartment.Employees)
                {
                    Console.WriteLine($"Employee name: {employee.EmployeeName}");
                }
            }
        }
    }
}
