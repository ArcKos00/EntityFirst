using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkProject.Entity
{
    public class Title
    {
        public int TitleId { get; set; }
        public List<Employee> EmployeeId { get; set; } = new List<Employee>();

        public string? Name { get; set; }
    }
}
