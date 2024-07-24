using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject
{
    public class Course
    {
        public Guid CourseId { get; set; } = Guid.NewGuid();
        public string CourseName { get; set; }
        public int Credits { get; set; }
        public Teacher Instructor { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();
        public string Schedule { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public decimal ApprovalScore { get; set; }
        public double MinGPA { get; set; }

        public void EnrollStudent(Student s)
        {
            if (s.GPA >= MinGPA)
            {
                Students.Add(s);
            }
            else
            {
                Console.WriteLine($"The Student GPA {s.FirstName} {s.LastName} does not accomplish to the Course MinGPA {MinGPA}.");
            }
        }

        public override string ToString()
        {
            StringBuilder information = new StringBuilder();

            information.AppendLine($"Course Name: {CourseName}");
            information.AppendLine($"Credits: {Credits}");
            information.AppendLine($"Teacher: {Instructor.FirstName} {Instructor.LastName}");
            information.AppendLine($"Schedule: {Schedule}");
            information.AppendLine($"Description: {Description}");
            information.AppendLine($"Status: {Status}");
            information.AppendLine($"Approval score: {ApprovalScore}");
            information.AppendLine($"MinGPA: {MinGPA}");

            information.AppendLine("Enrolled Students:");
            foreach (var student in Students)
            {
                information.AppendLine($"- {student.FirstName} {student.LastName}");
            }

            return information.ToString();
        }
    }
}
