
namespace SchoolProject
{
    public class Teacher : Person
    {
        public DateTime HireDate { get; set; }
        public string Department { get; set; }
        public string Specialization { get; set; }
        public decimal Salary { get; set; }

        public override string ToString()
        {
            return ($"{base.ToString()}" +
                    $"Hire Date: {HireDate.ToShortDateString()} \n" +
                    $"Department: {Department} \n" +
                    $"Specialization: {Specialization} \n" +
                    $"Salary: {Salary} \n");
        }
    }
}
