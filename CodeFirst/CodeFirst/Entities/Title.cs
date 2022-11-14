using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Entities
{
    public class Title
    {
        public int TitleId { get; set; }
        public List<Employee> Employees { get; set; } = new List<Employee>();

        public string? Name { get; set; }
    }
}
