using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public class EmployeService
    {
        readonly static List<Employee> employees = null;
         static  EmployeService()
        {
             employees = PersonService.GetPersons()
                                         .Select(p=> 
                                                new Employee { Id = p.Id, 
                                                               Name = p.Name,
                                                               Address = p.Address,
                                                               Dept = (p.Id % 2 == 0) ? "abc" : "pqr" }).ToList();
        }
        public static Employee GetEmployee(int id )
        {
            if (id > 0)
                return employees.FirstOrDefault(x => x.Id == id);
            else return new Employee();
        }

        public static List<Employee>  GetEmployees()
        {
            return employees;
        }
    }
    public class Employee:Person
    {
        public string Dept { get; set; }

    }
}
