﻿using SchoolProject;

public class Program
{
    private static SchoolManagement Management = new SchoolManagement();

    public static void Main(string[] args)
    {
        bool exit = false;

        //LoadData() TODO

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
                    Management.ManageStudents();
                    break;
                case "2":
                    Management.ManageTeacher();
                    break;
                case "3":
                    Management.ManageCourse();
                    break;
                case "4":
                    Management.ManageGrades();
                    break;
                case "5":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}
