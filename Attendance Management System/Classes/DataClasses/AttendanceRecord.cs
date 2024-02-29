using Attendance_Management_System.Classes.DataClasses;

namespace Attendance_Management_System.Classes.DataClasses
{
    public class AttendanceRecord
    {
        public string? Date { get; set; }
        public string? ClassId { get; set; }
        public List<StudentAttendance>? Students { get; set; }
    }
}