#pragma warning disable SYSLIB0011

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Binary_serialization
{
    internal class Program
    {
        static void Main()
        {
            Department department = new Department("Accounting");
            department.Employees =  new List<Employee> { new Employee("Petrovna"), new Employee("Mar'yaVanna") };

            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream("department.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, department);
            }

            using (FileStream fs = new FileStream("department.dat", FileMode.OpenOrCreate))
            {
                Department newDepartment = (Department)formatter.Deserialize(fs);

                Console.WriteLine($"Department name: {newDepartment.DepartmentName}:");

                foreach(Employee employee in newDepartment.Employees)
                {
                    Console.WriteLine($"Employee name: {employee.EmployeeName}");
                }
            }
        }
    }
}
