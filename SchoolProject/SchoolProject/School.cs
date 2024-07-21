namespace SchoolProject
{
    public class School
    {
        public List<Student> Students { get; set; } = new List<Student>();
        public List<Teacher> Teachers { get; set; } = new List<Teacher>();
        public List<Course> Courses { get; set; } = new List<Course>();

        public School() { }

        public void AddStudent(Student s)
        {
            s.Id = Students.Count + 1;
            Students.Add(s);
        }

        public Student FindStudent(int studentId)
        {
            Student student = Students.Find(s => s.Id == studentId);

            if (student == null)
            {
                Console.WriteLine("Student not found.");
            }

            return student;
        }
    }
}
