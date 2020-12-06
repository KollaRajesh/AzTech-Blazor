using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public class EmployeService
    {
        public static Employee GetEmployee()
        {
            return new Employee { id = 1, Name = "xyz", Dept = "abc", Address = "15,east Dr, CA" };
        
        }
    }

    public class Employee
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Dept { get; set; }
        public string Address { get; set; }

    }
}
