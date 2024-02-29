using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance_Management_System.Classes.DataClasses
{
    public class StudentDataXml
    {
        public string studentId { get; set; }
        public string? name { get; set; }
        public List<string> Classes { get; set; }
    }
}
