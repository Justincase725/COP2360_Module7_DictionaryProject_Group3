using System;
using System.Collections.Generic;

namespace Module7DictionaryProject
{
    public class Operations
    {
        public Dictionary<string, List<string>> myDictionary { get; } =
            new Dictionary<string, List<string>>(StringComparer.OrdinalIgnoreCase);

        public void AddEntry()
        {
            Console.Clear();
            Console.WriteLine("=== Add New Entry ===");

            Console.Write("Enter word: ");
            string key = Console.ReadLine()?.Trim() ?? string.Empty;

            if (string.IsNullOrWhiteSpace(key))
            {
                Console.WriteLine("Error: Word cannot be empty.");
                Pause();
                return;
            }

            if (myDictionary.ContainsKey(key))
            {
                Console.WriteLine("Error: This word already exists.");
                Pause();
                return;
            }

            Console.Write("Enter definition: ");
            string definition = Console.ReadLine()?.Trim() ?? string.Empty;

            if (string.IsNullOrWhiteSpace(definition))
            {
                Console.WriteLine("Error: Definition cannot be empty.");
                Pause();
                return;
            }

            myDictionary[key] = new List<string> { definition };
            Console.WriteLine($"Added '{key}' successfully.");
            Pause();
        }

        public void SearchEntry()
        {
            Console.Clear();
            Console.WriteLine("=== Search for Word ===");
            Console.Write("Enter word: ");
            string key = Console.ReadLine()?.Trim() ?? string.Empty;

            if (myDictionary.TryGetValue(key, out var definitions))
            {
                Console.WriteLine($"\n{key} found with {definitions.Count} definition(s):");
                foreach (var def in definitions)
                    Console.WriteLine($"- {def}");
            }
            else
            {
                Console.WriteLine("Word not found.");
            }
            Pause();
        }

        public void UpdateEntry()
        {
            Console.Clear();
            Console.WriteLine("=== Update Entry ===");
            Console.Write("Enter word to update: ");
            string key = Console.ReadLine()?.Trim() ?? string.Empty;

            if (!myDictionary.ContainsKey(key))
            {
                Console.WriteLine("Error: Word not found.");
                Pause();
                return;
            }

            Console.Write("Enter new definition: ");
            string newDefinition = Console.ReadLine()?.Trim() ?? string.Empty;

            if (!string.IsNullOrWhiteSpace(newDefinition))
            {
                myDictionary[key].Add(newDefinition);
                Console.WriteLine($"'{key}' updated successfully.");
            }
            else
            {
                Console.WriteLine("No changes made.");
            }
            Pause();
        }

        public void DeleteEntry()
        {
            Console.Clear();
            Console.WriteLine("=== Delete Entry ===");
            Console.Write("Enter word to delete: ");
            string key = Console.ReadLine()?.Trim() ?? string.Empty;

            if (myDictionary.Remove(key))
            {
                Console.WriteLine($"'{key}' removed successfully.");
            }
            else
            {
                Console.WriteLine("Error: Word not found.");
            }
            Pause();
        }

        public void ViewAllEntries()
        {
            Console.Clear();
            Console.WriteLine("=== View All Entries ===");

            if (myDictionary.Count == 0)
            {
                Console.WriteLine("No entries found.");
            }
            else
            {
                foreach (var entry in myDictionary)
                {
                    Console.WriteLine($"\n{entry.Key}:");
                    foreach (var def in entry.Value)
                        Console.WriteLine($"- {def}");
                }
            }
            Pause();
        }

        public void ExtrasMenu()
        {
            bool back = false;
            while (!back)
            {
                Console.Clear();
                Console.WriteLine("=== EXTRAS MENU ===");
                Console.WriteLine("1. Populate Dictionary (Preset Data)");
                Console.WriteLine("2. Remove All Entries");
                Console.WriteLine("3. Back to Main Menu");
                Console.Write("Enter your choice (1-3): ");

                string choice = Console.ReadLine()?.Trim() ?? string.Empty;

                switch (choice)
                {
                    case "1":
                        PopulateDictionary();
                        break;
                    case "2":
                        ClearDictionary();
                        break;
                    case "3":
                        back = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        Pause();
                        break;
                }
            }
        }

        private void PopulateDictionary()
        {
            Console.Clear();
            Console.WriteLine("=== Populating Dictionary with Turtle Facts ===");

            var sampleData = new Dictionary<string, List<string>>(StringComparer.OrdinalIgnoreCase)
            {
                { "Turtle", new List<string> 
                    { "A reptile with a hard shell that protects it from predators.",
                      "Turtles live in a variety of environments including oceans, rivers, and forests." } 
                },
                { "Shell", new List<string> 
                    { "The protective outer covering of a turtle body.",
                      "It consists of two parts: the upper carapace and the lower plastron." } 
                },
                { "Habitat", new List<string> 
                    { "Turtles can live in both aquatic and terrestrial environments depending on the species." } 
                },
                { "Diet", new List<string> 
                    { "Turtles eat plants, insects, or small fish, depending on whether they are herbivores or carnivores." } 
                },
                { "Lifespan", new List<string> 
                    { "Turtles are known for their longevity, with some living over 100 years." } 
                }
            };

            int added = 0, skipped = 0;

            foreach (var (word, definitions) in sampleData)
            {
                if (myDictionary.ContainsKey(word))
                {
                    skipped++;
                    continue;
                }

                myDictionary[word] = definitions;
                added++;
            }

            Console.WriteLine($"\nPopulation complete: {added} added, {skipped} skipped.");
            Pause();
        }

        private void ClearDictionary()
        {
            Console.Clear();
            Console.WriteLine("=== Clear Dictionary ===");
            Console.Write("Are you sure you want to remove all entries? (Y/N): ");
            string confirm = Console.ReadLine()?.Trim().ToUpper();

            if (confirm == "Y")
            {
                myDictionary.Clear();
                Console.WriteLine("All entries removed successfully.");
            }
            else
            {
                Console.WriteLine("Operation canceled.");
            }
            Pause();
        }

        private static void Pause()
        {
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey(true);
        }
    }
}
