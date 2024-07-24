namespace SchoolProject
{
    public class Grade
    {
        public Guid GradeId { get; set; }
        public Course Course { get; set; }
        public Student Student { get; set; }
        public decimal Score { get; set; }
    }
}
