using BlazorApp.Data;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Pages.Employee
{
    public partial class PersonComponent : ComponentBase
    {
        [Parameter]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        protected override void OnInitialized()
        {
            base.OnInitialized();
            var person = PersonService.GetPerson(1);
            Id = person.Id;
            Name = person.Name;
            Address = person.Address;

        }
    }
}
