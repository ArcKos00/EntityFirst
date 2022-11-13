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
        public string FirstName { get; set; } = String.Empty;
        public string LastName { get; set; } = String.Empty;
        public DateTime HiredDate { get; set; }
        public DateOnly? DateOfBirdth { get; set; }
        public int OfficeId { get; set; }
        public int TitleId { get; set; }
    }
}
