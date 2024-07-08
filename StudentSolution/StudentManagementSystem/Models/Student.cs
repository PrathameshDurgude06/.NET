using System.ComponentModel.DataAnnotations;

namespace StudentManagementSystem.Models
{
    public class Student
    {
        /*
       1.Student_ID
       2. Student_Name
       3. Student_Email Id
       4. Mobile_number
       5. Student_Address
       6. admission_date
       7. fees
       8. Status(e.g.Active/Inactive)*/
        [Key]
        public int Stubent_Id { get; set; }

        [Required]
        public string Stubent_Name { get; set; }

        [Required]
        public string Stubent_Email { get; set; }

        [Required]
        public string Mobile_Number { get; set; }

        public string Student_Address { get; set; }

        [Required]
        public DateTime Admission_date { get; set; }

        [Required]
        public double Fees { get; set; }

        [Required]
        public String Status { get; set; }

        public Student(){

        }

        public Student(int stubent_Id, string stubent_Name, string stubent_Email, string mobile_Number, string student_Address, DateTime admission_date, double fees, string status)
        {
            Stubent_Id = stubent_Id;
            Stubent_Name = stubent_Name;
            Stubent_Email = stubent_Email;
            Mobile_Number = mobile_Number;
            Student_Address = student_Address;
            this.Admission_date = admission_date;
            this.Fees = fees;
            Status = status;
        }
    }
}
