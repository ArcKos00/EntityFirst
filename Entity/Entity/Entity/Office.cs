using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkProject.Entity
{
    public class Office
    {
        public int OfficeId { get; set; }

        public List<Employee> OfficeEmployees { get; set; } = new List<Employee>();

        public string? Ttitle { get; set; }
        public string? Location { get; set; }
    }
}
