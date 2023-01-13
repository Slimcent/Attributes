using AttributesExamples.Models;
using System;

namespace AttributesApp
{
    public static class Application
    {
        public static void Run()
        {
            Employee emp = new();

            Type employeeType = typeof(Employee);

            if (ModelInput.GetInput(employeeType, "Please enter the employee's id", "Id", out string empId))
            {
                emp.Id = Int32.Parse(empId);
            }

            if (ModelInput.GetInput(employeeType, "Please enter the employee's first name", "FirstName", out string firstName))
            {
                emp.FirstName = firstName;
            }

            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine($"Welcome! Employee with Id: {emp.Id} and first name: {emp.FirstName} has been entered successfully!!");
            Console.ResetColor();

            Console.ReadKey();
        }
    }
}
