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
using System.Collections.Generic;

namespace Module7DictionaryProject
{
    public class Operations
    {
        public Dictionary<string, List<string>> myDictionary { get; } = new Dictionary<string, List<string>>(StringComparer.OrdinalIgnoreCase);

        public void AddEntry() { }
        public void SearchEntry() { }
        public void UpdateEntry() { }
        public void DeleteEntry() { }
        public void ViewAllEntries() { }
        public void ExtrasMenu() { }
    }

    internal class Program
    {
        private static Operations manager = new Operations();

        static void Main(string[] args)
        {
            Console.Title = "Dictionary Management System";
            bool running = true;
            
            while (running)
            {
                DisplayMenu();
                running = HandleMenuChoice();
                
                if (running)
                {
                    Console.WriteLine("\nPress any key to return to Main Menu...");
                    Console.ReadKey(true);
                }
            }

            Console.WriteLine("\nProgram Exited.");
        }

        private static void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("DICTIONARY MENU");
            Console.WriteLine("=========================");
            Console.WriteLine("1. Add New Word");
            Console.WriteLine("2. Search for Word");
            Console.WriteLine("3. Update Entry");
            Console.WriteLine("4. Delete Entry");
            Console.WriteLine("5. View All Entries");
            Console.WriteLine("6. Extras Menu");
            Console.WriteLine("7. Exit Program");
            Console.WriteLine("-------------------------");
            Console.Write("Enter choice (1-7): ");
        }

        private static bool HandleMenuChoice()
        {
            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        manager.AddEntry();
                        break;
                    case 2:
                        manager.SearchEntry();
                        break;
                    case 3:
                        manager.UpdateEntry();
                        break;
                    case 4:
                        manager.DeleteEntry();
                        break;
                    case 5:
                        manager.ViewAllEntries();
                        break;
                    case 6:
                        manager.ExtrasMenu();
                        break;
                    case 7:
                        return false;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Enter a number.");
            }
            return true;
        }
    }
}

