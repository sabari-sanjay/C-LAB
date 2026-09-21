using System;
using System.Data;

class Program
{
    static void Main()
    {
        DataTable student = new DataTable("Student");

        student.Columns.Add("StudentID");
        student.Columns.Add("Name");
        student.Columns.Add("Department");

        student.Rows.Add("101", "Arun", "IT");
        student.Rows.Add("102", "Priya", "CSE");
        student.Rows.Add("103", "Kavin", "ECE");

        Console.WriteLine("Student Details");
        Console.WriteLine("------------------------------");

        foreach (DataRow row in student.Rows)
        {
            Console.WriteLine(
                "ID: " + row["StudentID"] +
                ", Name: " + row["Name"] +
                ", Department: " + row["Department"]);
        }

        Console.WriteLine("------------------------------");
        Console.WriteLine("Data retrieved successfully.");
        Console.WriteLine("Working in disconnected environment.");

        Console.ReadKey();
    }
}