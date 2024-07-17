
namespace SchoolProject
{
    public class Course
    {
        public Guid CourseId { get; set; }
        public string CourseName { get; set; }
        public int Credits { get; set; }
        public Teacher Instructor { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();
        public string Schedule { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public decimal ApprovalScore { get; set; }
        public double MinGPA { get; set; }
    }
}
