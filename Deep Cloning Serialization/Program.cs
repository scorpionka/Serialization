using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Deep_Cloning_Serialization
{
    internal static class Program
    {
        static void Main()
        {
            Department department = new Department() { DepartmentName = "Accounting" };
            department.Employees = new List<Employee> {
                new Employee() { EmployeeName = "Petrovna" },
                new Employee() { EmployeeName = "Mar'yaVanna" }
            };

            Department department2 = department;
            Department newDepartment = department.CreateDeepClone();

            if (!Equals(newDepartment, department) && Equals(department2, department))
            {
                Console.WriteLine("Deep cloning was succeful!");
            }

            Console.WriteLine($"Department name: {newDepartment.DepartmentName}:");

            foreach (Employee employee in newDepartment.Employees)
            {
                Console.WriteLine($"Employee name: {employee.EmployeeName}");
            }
        }

        public static T CreateDeepClone<T>(this T obj)
        {
            using (var ms = new MemoryStream())
            {
                XmlSerializer serializer = new XmlSerializer(obj.GetType());
                serializer.Serialize(ms, obj);
                ms.Seek(0, SeekOrigin.Begin);
                return (T)serializer.Deserialize(ms);
            }
        }
    }
}
