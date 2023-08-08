using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Model
{
    public class Employee
    {
        public string FullName { get; set; }

        public int TabelNumber { get; set; }

        public string Department { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime DateReception { get; set; }
        public DateTime? DateDismissal { get; set; }
        public string RecordStatus { get; set; }

        public List<Employee> EmployeesRepository { get; set; }
    }
}
