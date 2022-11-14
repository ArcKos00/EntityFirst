using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Entities
{
    public class Project
    {
        public int ProjectId { get; set; }
        public List<EmployeeProject> EmployeeProjects { get; set; } = new List<EmployeeProject>();

        public string? Name { get; set; }

        public decimal Budget { get; set; }

        public DateTime StartedDate { get; set; }
    }
}
