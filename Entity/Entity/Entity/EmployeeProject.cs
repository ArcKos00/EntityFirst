using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkProject.Entity
{
    public class EmployeeProject
    {
        public int EmployeeProjectId { get; set; }

        public decimal Rate { get; set; }
        public DateTime StartedDate { get; set; }

        public int EmployeeId { get; set; }
        public List<Employee> Employees { get; set; } = new List<Employee>();

        public int ProjectId { get; set; }
        public List<Project> Projects { get; set; } = new List<Project>();
    }
}
