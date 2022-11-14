using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Entities
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public List<EmployeeProject> Projects { get; set; } = new List<EmployeeProject>();

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime HiredDate { get; set; }
        public DateTime DateOfBirdth { get; set; }

        public int OfficeId { get; set; }
        public Office? Office { get; set; }

        public int TitleId { get; set; }
        public Title? TitleTab { get; set; }
    }
}
