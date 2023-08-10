using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Model
{
    public class Department
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string MainDepartment { get; set; }
        public string Leader { get; set; }
        public string RecordStatus { get; set; }

        public List<Department> DepartmentsRepository { get; set; }
    }
}
