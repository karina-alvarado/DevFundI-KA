
using SchoolProject;

public class Program
{
    private static School school = new School();

    public static void Main(string[] args)
    {
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("School Management System");
            Console.WriteLine("1. Students");
            Console.WriteLine("2. Staff");
            Console.WriteLine("3. Courses");
            Console.WriteLine("4. Grades");
            Console.WriteLine("5. Exit");
            Console.Write("Select an option: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    school.ManageStudents();
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    private static void ManageGrades()
    {
        throw new NotImplementedException();
    }

}

