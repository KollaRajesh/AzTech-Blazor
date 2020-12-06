using BlazorApp.Data;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp
{
    public class EmployeComponent :ComponentBase
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Dept { get; set; }
        public string Address { get; set; }

        protected override void OnInitialized()
        {
            base.OnInitialized();
            var employee = EmployeService.GetEmployee();
            id = employee.id;
            Name = employee.Name;
            Dept = employee.Dept;
            Address = employee.Address;
        }
    }
}
