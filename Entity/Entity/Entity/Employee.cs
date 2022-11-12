using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkProject.Entity
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateOnly BirdthDate { get; set; }
        public DateTime? HiredDate { get; set; }

        public int Officeld { get; set; }
        public Office? OfficeForWork { get; set; }

        public int TitleId { get; set; }
        public Title? EmployeeTitle { get; set; }
    }
}
