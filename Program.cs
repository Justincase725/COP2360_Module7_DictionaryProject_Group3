/*
 * COP2360 – Module 7 Group Project
 * Dictionary Management System
 * 
 * Role A – Justin Robinson (Lead / Repo Owner)
 * Role B – Robert Weinberger (Menu Developer)
 * Role C – Nayobe Jean-Louis (CRUD Developer)
 * Role D – Leopoldo Ramos (Extras Developer)
 * Role E – Donovan Zangwill (Display & Documentation)
 * 
 * Purpose:
 * Serves as the main entry point for the program.
 * Initializes the project and confirms that the repository and
 * structure are working before the menu and operations are implemented.
 */

using System;

namespace Module7DictionaryProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "COP2360 Module 7 – Dictionary Management System";
            Console.WriteLine("=== Module 7 Dictionary Project ===");
            Console.WriteLine("Repository and structure setup complete.");
            Console.WriteLine("Project initialized successfully.");
            Console.WriteLine("\nNext: Role B (Robert Weinberger) will implement the menu and switch statement.");
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
