using System.ComponentModel.DataAnnotations;
namespace BOL
{
    public class Student
    {
        public int Student_id {  get; set; }

        public string Student_Name {  get; set; }

        public string Email {  get; set; }

        public string Mobile_No {  get; set; }
        public string Address { get; set; }

        public DateOnly Admission_date { get; set; }

        public double Fees {  get; set; }

        public string Status {  get; set; }

        public Student(int student_id, string studentName, string email, string mobile_No, string address, DateOnly admission_date, double fees, string status)
        {
            Student_id = student_id;
            Student_Name = studentName;
            Email = email;
            Mobile_No = mobile_No;
            Address = address;
            Admission_date = admission_date;
            Fees = fees;
            Status = status;
        }
    }
}
