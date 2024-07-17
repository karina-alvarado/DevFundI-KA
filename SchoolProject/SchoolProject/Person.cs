namespace SchoolProject
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        public Person() { }

        public override string ToString()
        {
            return ($"Name: {FirstName} {LastName} \n" +
                    $"Date of Birth: {DateOfBirth.ToShortDateString()} \n" +
                    $"Address: {Address} \n" +
                    $"Phone Number: {PhoneNumber} \n");

        }
    }
}
