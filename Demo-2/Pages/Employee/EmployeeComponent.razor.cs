using BlazorApp.Data;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Pages.Employee
{
    partial class EmployeeComponent 
    {
        [Parameter]
        public string Dept { get; set; }
        protected override void OnInitialized()
        {
            base.OnInitialized();
            var employee = EmployeService.GetEmployee(1);
             Id = employee.Id;
            Name = employee.Name;
            Dept = employee.Dept;
            Address = employee.Address;
        }
    }
}
