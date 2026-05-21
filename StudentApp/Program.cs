using System;
using System.Collections.Generic;

namespace StudentApp
{
    // Student class
    class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime EnrollmentDate { get; set; }

        // Constructor
        public Student(int id, string firstName, string lastName, string email, DateTime enrollmentDate)
        {
            StudentId = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            EnrollmentDate = enrollmentDate;
        }
    }

    class Program
    {
        // List acts like temporary database
        static List<Student> students = new List<Student>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("==================================");
                Console.WriteLine("     STUDENT MANAGEMENT SYSTEM");
                Console.WriteLine("==================================");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. View Students");
                Console.WriteLine("3. Delete Student");
                Console.WriteLine("4. Exit");
                Console.WriteLine("==================================");

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddStudent();
                        break;

                    case "2":
                        ViewStudents();
                        break;

                    case "3":
                        DeleteStudent();
                        break;

                    case "4":
                        Console.WriteLine("Exiting program...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice!");
                        Pause();
                        break;
                }
            }
        }

        // Add student
        static void AddStudent()
        {
            Console.Clear();

            Console.WriteLine("===== ADD STUDENT =====");

            Console.Write("Enter Student ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            string lastName = Console.ReadLine();

            Console.Write("Enter Email: ");
            string email = Console.ReadLine();

            Console.Write("Enter Enrollment Date (yyyy-mm-dd): ");
            DateTime enrollmentDate = Convert.ToDateTime(Console.ReadLine());

            Student student = new Student(
                id,
                firstName,
                lastName,
                email,
                enrollmentDate
            );

            students.Add(student);

            Console.WriteLine("\nStudent added successfully!");
            Pause();
        }

        // View students
        static void ViewStudents()
        {
            Console.Clear();

            Console.WriteLine("===== STUDENT LIST =====");

            if (students.Count == 0)
            {
                Console.WriteLine("No students found.");
            }
            else
            {
                foreach (Student student in students)
                {
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine($"ID: {student.StudentId}");
                    Console.WriteLine($"Name: {student.FirstName} {student.LastName}");
                    Console.WriteLine($"Email: {student.Email}");
                    Console.WriteLine($"Enrollment Date: {student.EnrollmentDate.ToShortDateString()}");
                }
            }

            Pause();
        }

        // Delete student
        static void DeleteStudent()
        {
            Console.Clear();

            Console.WriteLine("===== DELETE STUDENT =====");

            Console.Write("Enter Student ID to delete: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Student foundStudent = students.Find(s => s.StudentId == id);

            if (foundStudent != null)
            {
                students.Remove(foundStudent);
                Console.WriteLine("Student deleted successfully!");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }

            Pause();
        }

        // Pause helper
        static void Pause()
        {
            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
        }
    }
}
