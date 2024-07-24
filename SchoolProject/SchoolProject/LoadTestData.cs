
namespace SchoolProject
{
    public interface ILoadTestData 
    {
        void Load(School school); //TBI
        //void Load(string path); to read .txt, .csv
    }
    public class LoadTestData : ILoadTestData
    {
        public void Load(School school)
        {
            Teacher teacher1 = new Teacher { FirstName = "Steven", LastName = "Williams", Department = "Computer Science" };
            school.AddTeacher(teacher1);

            Course course1 = new Course
            {
                CourseId = new Guid("39836a54-09ac-438f-bdd3-3e5cb0f207eb"),
                CourseName = "Dev Foundamentals",
                Credits = 3,
                Schedule = "MTW 10-11:30AM",
                Description = "Introduction to OOP.",
                Status = "Open",
                ApprovalScore = 90.5m,
                MinGPA = 2.7,
            };

            course1.Instructor = teacher1;
            school.AddCourse(course1);

            Student student1 = new Student
            {
                FirstName = "Andy",
                LastName = "Miller",
                DateOfBirth = new DateTime(2007, 10, 10),
                Address = "123 Main Street",
                PhoneNumber = "70407887",
                EnrollmentDate = new DateTime(2022, 9, 1),
                Major = "Computer Science",
                GPA = 3.85,
                School = school
            };

            Student student2 = new Student
            {
                FirstName = "Lucas",
                LastName = "Sanz",
                DateOfBirth = new DateTime(2006, 6, 3),
                Address = "123 Main Street",
                PhoneNumber = "60612345",
                EnrollmentDate = new DateTime(2023, 1, 15),
                Major = "Electrical Engineering",
                GPA = 2.65,
                CreditsEarned = 80,
                School = school
            };

            course1.Students.Add(student1);
            school.AddStudent(student1);
            course1.Students.Add(student2);
            school.AddStudent(student2);

            Grade grade1 = new Grade
            {
                GradeId = new Guid("ed37d761-9cce-4b2c-9643-f7babac90a97"),
                Student = student1,
                Course = course1,
                Score = 65
            };
            student1.Grade = grade1;

            Grade grade2 = new Grade
            {
                GradeId = new Guid("a21782aa-d6a3-435e-b381-e8079a831ebe"),
                Student = student2,
                Course = course1,
                Score = 48
            };

            student2.Grade = grade2;
        }
    }
}
