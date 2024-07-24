namespace SchoolProject
{
    public class SchoolManagement
    {
        public School School { get; set; }
        public SchoolManagement() {
          
            School = new School();
            LoadTestData loadTestData = new LoadTestData();
            loadTestData.Load(School);
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

            Console.WriteLine($"Name: {teacher.FirstName} {teacher.LastName}");
            Console.WriteLine($"Date of Birth: {teacher.DateOfBirth.ToShortDateString()}");
            Console.WriteLine($"Address: {teacher.Address}");
            Console.WriteLine($"Phone Number: {teacher.PhoneNumber}");
            Console.WriteLine($"Hire Date: {teacher.HireDate.ToShortDateString()}");
            Console.WriteLine($"Department: {teacher.Department}");
            Console.WriteLine($"Specialization: {teacher.Specialization}");
            Console.WriteLine($"Salary: {teacher.Salary}");
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

        private void CreateCourse()
        {
            Console.WriteLine("Enter course details:");

            Course newCourse = new Course();

            Console.Write("Course Name: ");
            newCourse.CourseName = Console.ReadLine();

            Console.Write("Credits: ");
            if (int.TryParse(Console.ReadLine(), out int credits))
            {
                newCourse.Credits = credits;
            }
            else
            {
                Console.WriteLine("Invalid credits format. Course creation cancelled.");
                return;
            }
            Console.Write("Schedule: ");
            newCourse.Schedule = Console.ReadLine();
            Console.Write("Description: ");
            newCourse.Description = Console.ReadLine();
            Console.Write("Status: ");
            newCourse.Status = Console.ReadLine();
            Console.Write("Approval Score: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal score))
            {
                newCourse.ApprovalScore = score;
            }
            else
            {
                Console.WriteLine("Invalid score format. Course creation cancelled.");
                return;
            }
            Console.Write("MinGPA: ");
            if (double.TryParse(Console.ReadLine(), out double minGPA))
            {
                newCourse.MinGPA = minGPA;
            }
            else
            {
                Console.WriteLine("Invalid MinGPA format. Course creation cancelled.");
                return;
            }


            School.Courses.Add(newCourse);

            Console.WriteLine($"Course {newCourse.CourseName} with ID {newCourse.CourseId} created successfully.");
        }

        private void EnrollStudentInCourse()
        {
            Console.Write("Enter student's ID (select from available students): ");
            if (int.TryParse(Console.ReadLine(), out int studentId))
            {
                Student student = School.FindStudent(studentId);
                if (student != null)
                {
                    Console.Write("Enter course ID (select from available courses): ");
                    if (Guid.TryParse(Console.ReadLine(), out Guid courseId))
                    {
                        Course course = School.FindCourse(courseId);
                        if (course != null)
                        {
                            course.EnrollStudent(student);
                        }
                        else
                        {
                            Console.WriteLine($"Course with Id:{courseId} not found. Enrollment cancelled.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid course ID format. Enrollment cancelled.");
                    }
                }
                else
                {
                    Console.WriteLine($"Student with Id: {studentId} not found. Enrollment cancelled.");
                }
            }
            else
            {
                Console.WriteLine("Invalid student ID format. Enrollment cancelled.");
            }
        }

        private void AssignTeacherToCourse()
        {
            Console.Write("Enter teacher's ID (select from available teachers): ");

            if (int.TryParse(Console.ReadLine(), out int teacherId))
            {
                Teacher teacher = School.FindTeacher(teacherId);
                if (teacher != null)
                {
                    Console.Write("Enter course ID (select from available courses): ");
                    if (Guid.TryParse(Console.ReadLine(), out Guid courseId))
                    {
                        Course selectedCourse = School.FindCourse(courseId);
                        if (selectedCourse != null)
                        {
                            selectedCourse.Instructor = teacher;
                            Console.WriteLine("Teacher assigned to course successfully.");
                        }
                        else
                        {
                            Console.WriteLine($"Course with Id: {courseId} not found. Assignment cancelled.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid course ID format. Assignment cancelled.");
                    }
                }
                else
                {
                    Console.WriteLine($"Teacher with Id: {teacherId} not found. Assignment cancelled.");
                }
            }
            else
            {
                Console.WriteLine("Invalid teacher ID format. Assignment cancelled.");
            }
        }

        private void ViewCourseInformation()
        {
            Console.Write("Enter course ID: ");
            if (Guid.TryParse(Console.ReadLine(), out Guid courseId))
            {
                Course course = School.FindCourse(courseId);
                if (course != null)
                {
                    Console.WriteLine(course);
                }
                else
                {
                    Console.WriteLine($"Course with Id:{courseId} not found.");
                }
            }
            else
            {
                Console.WriteLine("Invalid course ID format.");
            }
        }

        public void ManageGrades() 
        {
            Console.WriteLine("Grades");
            Console.WriteLine("1. Grade Course");
            Console.WriteLine("2. List Course Grades");
            Console.WriteLine("3. List Approved Students");
            Console.WriteLine("4. List Failed Students");
            Console.WriteLine("0. Back to Main Menu");
            Console.Write("Select an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    GradeCourse();
                    break;
                case "2":
                    ListCourseGrades();
                    break;
                case "3":
                    ListApprovedStudents();
                    break;
                case "4":
                    ListFailedStudents();
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }

            Console.WriteLine("Press any key to return to the main menu...");
            Console.ReadKey();
        }

        private void GradeCourse()
        {
            Console.Write("Course Id: ");
            Guid courseId = Guid.Parse(Console.ReadLine());
            Course course = School.FindCourse(courseId);

            if (course != null)
            {
                Console.Write("Student Id: ");
                int studentId = int.Parse(Console.ReadLine());
                Student student = School.FindStudent(studentId);

                if (student != null)
                {
                    Console.Write("Score: ");
                    decimal score = decimal.Parse(Console.ReadLine());

                    Grade grade = new Grade
                    {
                        GradeId = Guid.NewGuid(),
                        Course = course,
                        Student = student,
                        Score = score
                    };

                    student.Grade = grade;

                    Console.WriteLine("Grade assigned successfully!");
                }
                else
                {
                    Console.WriteLine($"Student with Id: {studentId} not found.");
                }
            }
            else
            {
                Console.WriteLine("Course not found.");
            }
        }

        private void ListCourseGrades()
        {
            Console.Clear();
            Console.WriteLine("List Course Grades");

            Console.Write("Course Id: ");
            Guid courseId = Guid.Parse(Console.ReadLine());
            ListCourseGrades(courseId);
        }

        private void ListApprovedStudents()
        {
            Console.Clear();
            Console.WriteLine("List Approved Students");
            Console.Write("Course Id: ");
            Guid courseId = Guid.Parse(Console.ReadLine());
            ListCourseGrades(courseId, true);
        }
        private void ListFailedStudents()
        {
            Console.Clear();
            Console.WriteLine("List Failed Students");
            Console.Write("Course Id: ");
            Guid courseId = Guid.Parse(Console.ReadLine());
            ListCourseGrades(courseId, false, true);
        }

        private void ListCourseGrades(Guid courseId, bool listApproved = false, bool listFailed = false)
        {
            Course course = School.FindCourse(courseId);

            if (course != null)
            {
                foreach (var student in course.Students)
                {
                    if (listApproved && IsStudentApproved(student, course.ApprovalScore))
                    {
                        Console.WriteLine($"Approved Student: {student.FirstName} {student.LastName}, Score: {student.Grade.Score}");
                    }
                    else if (listFailed && !IsStudentApproved(student, course.ApprovalScore))
                    {
                        Console.WriteLine($"Failed Student: {student.FirstName} {student.LastName}, Score: {student.Grade.Score}");
                    }
                    else if (!listFailed && !listApproved)
                    {
                        Console.WriteLine($"Student: {student.FirstName} {student.LastName}, Score: {student.Grade.Score}");
                    }
                }
            }
            else
            {
                Console.WriteLine("Course not found.");
            }
        }

        private bool IsStudentApproved(Student student, decimal approvalScore)
        {
            return student.Grade.Score >= approvalScore;
        }
    }
}
