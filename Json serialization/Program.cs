using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace Json_serialization
{
    internal class Program
    {
        static async Task Main()
        {
            Department department = new Department() { DepartmentName = "Accounting" };
            department.Employees = new List<Employee> {
                new Employee() { EmployeeName = "Petrovna" },
                new Employee() { EmployeeName = "Mar'yaVanna" }
            };

            using (FileStream fs = new FileStream("department.json", FileMode.OpenOrCreate))
            {
                await JsonSerializer.SerializeAsync<Department>(fs, department);
            }

            using (FileStream fs = new FileStream("department.json", FileMode.OpenOrCreate))
            {
#nullable enable
                Department? newDepartment = await JsonSerializer.DeserializeAsync<Department>(fs);
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
