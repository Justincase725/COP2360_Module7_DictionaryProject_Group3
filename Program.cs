using System;

namespace Module7DictionaryProject
{
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

            // 👇 Your custom goodbye
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nThank you for using the Group 3 Dictionary!");
            Console.WriteLine("Developed with care by R.J.N.L.D — ❤️");
            Console.ResetColor();
            Console.WriteLine();
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
            string userInput = Console.ReadLine()?.Trim() ?? string.Empty;

            // Easter Egg by Leopoldo Ramos 🥚
            if (userInput.ToLower() == "rjnld")
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("🌟 You discovered Group 3’s hidden signature!");
                Console.WriteLine("R.J.N.L.D — representing the power of teamwork!");
                Console.WriteLine("Thanks for exploring our project — you’ve got a sharp eye!");
                Console.ResetColor();
                Console.WriteLine();
                return true; // goes back to the menu
            }

            if (int.TryParse(userInput, out int choice))
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
                Console.WriteLine("Invalid input. Enter a number (1-7).");
            }

            return true;
        }
    }
}
