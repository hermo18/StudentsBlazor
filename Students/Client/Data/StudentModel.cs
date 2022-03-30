using System.ComponentModel.DataAnnotations;

namespace Person.Client.Data
{
    public class StudentModel
    {
        [Required]
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentLast { get; set; }
        public int StudentFaults { get; set; }
        public double StudentMark { get; set; }
    }
}
