namespace SchoolProject
{
    public class SchoolManagement
    {
        public School School { get; set; }
        public SchoolManagement() {
            School = new School();
        }

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
                FirstName = firstName,
                LastName = lastName,
                DateOfBirth = dob,
                Address = address,
                PhoneNumber = phoneNumber,
                EnrollmentDate = enrollmentDate,
                Major = major,
                GPA = gpa,
                CreditsEarned = creditsEarned,
                School = School
            };

            School.AddStudent(student);
        }

        private void EarnCredits()
        {
            Console.Write("Student ID: ");
            int studentId = int.Parse(Console.ReadLine());
            Student student = School.FindStudent(studentId);

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
            Student student = School.FindStudent(studentId);

            if (student == null)
            {
                Console.WriteLine("Student not found.");
                return;
            }

            Console.WriteLine(student);
        }
        public void ManageTeacher()
        {
            Console.WriteLine("1. Add Teacher");
            Console.WriteLine("2. View Teacher Information");
            Console.Write("Select an option: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    AddTeacher();
                    break;
                case "2":
                    ViewTeacherInformation();
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
        private void AddTeacher()
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
            Console.Write("Hire Date (yyyy-mm-dd): ");
            DateTime hireDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Department: ");
            string department = Console.ReadLine();
            Console.Write("Specialization: ");
            string specialization = Console.ReadLine();
            Console.Write("Salary: ");
            decimal salary = decimal.Parse(Console.ReadLine());

            Teacher teacher = new Teacher
            {
                FirstName = firstName,
                LastName = lastName,
                DateOfBirth = dob,
                Address = address,
                PhoneNumber = phoneNumber,
                HireDate = hireDate,
                Department = department,
                Specialization = specialization,
                Salary = salary
            };

            School.AddTeacher(teacher);
            Console.WriteLine("Teacher added successfully.");
        }
        private void ViewTeacherInformation()
        {
            Console.Write("Teacher ID: ");
            int teacherId = int.Parse(Console.ReadLine());
            Teacher teacher = School.FindTeacher(teacherId);

            if (teacher == null)
            {
                Console.WriteLine("Teacher not found.");
                return;
            }

            Console.WriteLine(teacher);
        }
        public void ManageCourse()
        {
            Console.WriteLine("1. Create Course");
            Console.WriteLine("2. Enroll Student in Course");
            Console.WriteLine("3. Assign Teacher to Course");
            Console.WriteLine("4. View Course Information");
            Console.Write("Select an option: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    CreateCourse();
                    break;
                case "2":
                    EnrollStudentInCourse();
                    break;
                case "3":
                    AssignTeacherToCourse();
                    break;
                case "4":
                    ViewCourseInformation();
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
        private void ViewCourseInformation()
        {
            throw new NotImplementedException();
        }

        private void AssignTeacherToCourse()
        {
            throw new NotImplementedException();
        }

        private void EnrollStudentInCourse()
        {
            throw new NotImplementedException();
        }

        private void CreateCourse()
        {
            Console.Write("Course Name: ");
            string courseName = Console.ReadLine();
            Console.Write("Credits: ");
            int credits = int.Parse(Console.ReadLine());
            Console.Write("Schedule: ");
            string schedule = Console.ReadLine();
            Console.Write("Description: ");
            string description = Console.ReadLine();
            Console.Write("Approval Score: ");
            decimal approvalScore = decimal.Parse(Console.ReadLine());
            Console.Write("Minimum GPA: ");
            double minGPA = double.Parse(Console.ReadLine());
            Course course = new Course
            {
                CourseId = Guid.NewGuid(),
                CourseName = courseName,
                Credits = credits,
                Schedule = schedule,
                Description = description,
                ApprovalScore = approvalScore,
                MinGPA = minGPA
            };

            School.AddCourse(course);
            Console.WriteLine("Course created successfully.");
        }
    }
 }
