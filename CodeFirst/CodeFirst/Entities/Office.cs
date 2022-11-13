using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Entities
{
    public class Office
    {
        public int OfficeId { get; set; }
        public List<Employee> Employees { get; set; } = new List<Employee>();

        public string Ttitle { get; set; } = String.Empty;
        public string Location { get; set; } = String.Empty;
    }
}
