namespace SchoolProject
{
    public class School
    {
        public List<Student> Students { get; set; } = new List<Student>();
        public List<Teacher> Teachers { get; set; } = new List<Teacher>();
        public List<Course> Courses { get; set; } = new List<Course>();

        public School() { }

        public void ManageStudents() 
        {
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Earn credits");
            Console.WriteLine("3. View Student Information");
            Console.Write("Select an option: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    AddStudent();
                    break;
                case "2":
                    EarnCredits();
                    break;
                case "3":
                    ViewStudentInformation();
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }

        private void AddStudent()
        {
            Console.Write("First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Last Name: ");
            string lastName = Console.ReadLine();
            Console.Write("Date of Birth (yyyy-mm-dd): ");
            DateTime dob = DateTime.Parse(Console.ReadLine());
            Console.Write("Address: ");
            string address = Console.ReadLine();
            Console.Write("Phone Number: ");
            string phoneNumber = Console.ReadLine();
            Console.Write("Enrollment Date (yyyy-mm-dd): ");
            DateTime enrollmentDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Major: ");
            string major = Console.ReadLine();
            Console.Write("GPA: ");
            double gpa = double.Parse(Console.ReadLine());
            Console.Write("Credits Earned: ");
            int creditsEarned = int.Parse(Console.ReadLine());

            Student student = new Student
            {
                Id = Students.Count + 1,
                FirstName = firstName,
                LastName = lastName,
                DateOfBirth = dob,
                Address = address,
                PhoneNumber = phoneNumber,
                EnrollmentDate = enrollmentDate,
                Major = major,
                GPA = gpa,
                CreditsEarned = creditsEarned
            };

            Students.Add(student);
            Console.WriteLine("Student added successfully.");
        }

        private void EarnCredits()
        {
            Console.Write("Student ID: ");
            int studentId = int.Parse(Console.ReadLine());
            Student student = Students.Find(s => s.Id == studentId);

            if (student == null)
            {
                Console.WriteLine("Student not found.");
                return;
            }

            Console.Write("Credits to Add: ");
            int credits = int.Parse(Console.ReadLine());
            student.CreditsEarned += credits;
            Console.WriteLine("Credits added successfully.");
        }

        private void ViewStudentInformation()
        {
            Console.Write("Student ID: ");
            int studentId = int.Parse(Console.ReadLine());
            Student student = Students.Find(s => s.Id == studentId);

            if (student == null)
            {
                Console.WriteLine("Student not found.");
                return;
            }

            Console.WriteLine(student);
        }
    }
}
