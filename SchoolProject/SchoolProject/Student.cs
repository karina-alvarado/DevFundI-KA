namespace SchoolProject
{
    public class Student : Person
    {
        public DateTime EnrollmentDate { get; set; }
        public string Major { get; set; }
        public double GPA { get; set; }
        public int CreditsEarned { get; set; }
        public School School { get; set; }
        public Grade Grade { get; set; }

        public Student() { }

        public override string ToString()
        {
            return ($"{base.ToString()}" +
                    $"Enrollment Date: {EnrollmentDate.ToShortDateString()} \n" +
                    $"Major: {Major} \n" +
                    $"GPA: {GPA} \n" +
                    $"Credits Earned: {CreditsEarned} \n");
        }
    }   
}
