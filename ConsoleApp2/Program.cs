using System;
using System.Collections.Generic;
using System.IO;
namespace cccc
{
    class Program
    {
        public static string FaleName = @"D:\cooksBook.txt";
        public static void Main()
        {
            Dictionary<string, string> CookBook = new Dictionary<string, string>();
            CookBook.Add("Crispy Hasselback Potatoes", "\n1. Preheat the oven to 425ºF. \n2. Slice the potatoes. \n3. Season the potatoes(butter, oil, and parsley). \n4. Bake for 1 hour and 15 minutes.");
            CookBook.Add("Roasted Red Pepper Potato Soup", "\n1. Roast bell peppers until blackened all over. \n2. Sauté onions in butter. \n3. Add potatoes, garlic. \n4. Add stock, simmer. \n5. Purée soup. \n6. Add cream, seasonings.");
            CookBook.Add("Smothered Turkey Wings", "\n1. Preheat the oven. \n2. Prep the turkey wings. \n3. Slow roast the turkey wing. \n4. Make the stock. \n5. Strain the stock. \n6. Make the gravy. \n7. Broil the wings to brown them. \n8. Scrape the pan drippings into the gravy. \n9.Serve the turkey wings with gravy.");
            CookBook.Add("Perfect Mashed Potatoes", "\n1. Cook the potatoes. \n2. Prep the butter and cream. \n3. Drain and mash the potatoes.");
            CookBook.Add("Socca", "\n1. Combine socca ingredients(the chickpea flour, 2 tablespoons of olive oil, salt, and water). \n2. Let the batter rest. \n3. Heat nonstick skillet or cast iron. \n4. Cook the socca.");
            CookBook.Add("Seared Ahi Tuna", "\n1. Marinate the tuna steaks(2 tablespoons toasted sesame oil; 2 tablespoons soy sauce(or gluten - free tamari); 1 tablespoon grated fresh ginger; 1 clove garlic, minced1 scallion, thinly sliced (a few slices reserved for garnish); 1 teaspoon fresh lime juice). \n2. Sear the tuna. \n3. Slice and serve.");
            CookBook.Add("Broccoli Apple Soup", "\n1. Prep the broccoli. \n2. Cook the sliced onions and apples in butter. \n3. Add broccoli, stock, cider, thyme, lemon zest. \n4. Purée soup. \n5. Adjust seasonings.");
            CookBook.Add("Easy Cucumber, Peach, and Basil Salad", "\n1. Prep the vegetables. \n2. Make the vinaigrette()blender, combine the oil, vinegar, lime zest and juice, honey, basil, salt and pepper). \n3. Dress the produce.");
            CookBook.Add("\"Kale\"sadilla", "\n1. Sauté bell pepper, onion, add cumin, kale. \n2. Heat the tortilla. \n3. Add cheese and kale filling to tortilla.");
            foreach (KeyValuePair<string, string> kvp in CookBook)
            {
                Console.WriteLine("~~~~~~~ {0} ~~~~~~~, {1}",
                    kvp.Key, kvp.Value);
            }
            EnterDataInFile(CookBook);
            Search(CookBook);
            ReadDataFromAFile(CookBook);
            ChangeName(CookBook);
            Console.ReadLine();
        }
        static void EnterDataInFile(Dictionary<string, string> book)
        {

            if (!File.Exists(FaleName))
            {
                File.Create(FaleName);
            }
            using (StreamWriter writer = new StreamWriter(FaleName))
            {
                foreach (var x in book)
                {
                    writer.Write("\n{0}", x.Key);
                    writer.Write(x.Value);
                }
            }
        }
        static void Search(Dictionary<string, string> book)
        {
            Console.WriteLine("Enter a recipe name: ");
            string Name = Console.ReadLine();

            foreach (var x in book)
            {
                if (x.Key == Name)
                {
                    Console.WriteLine("\n{0}", x.Key);
                    Console.WriteLine(x.Value);
                }
            }
        }
        static void ReadDataFromAFile(Dictionary<string, string> book)
        {
            string Enter = @"F:\3_ask\c#2.txt";
            if (!File.Exists(Enter))
            {
                File.Create(Enter);
            }
            using (StreamReader To_read = new StreamReader(FaleName))
            {
                Console.WriteLine(To_read.ReadToEnd());
            }
            using (StreamWriter writer = new StreamWriter(Enter))
            {
                foreach (var x in book)
                {
                    writer.WriteLine(x.Key);
                }
            }

        }
        static void ChangeName(Dictionary<string, string> book)
        {
            Console.WriteLine("Enter a name which you want to change: ");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter a new name: ");
            string NewName = Console.ReadLine();
            foreach (var name in book)
            {
                if (name.Key == Name)
                {
                    string value = name.Value;
                    book.Remove(name.Key);
                    book[NewName] = value;
                    break;
                }
            }
            EnterDataInFile(book);
        }
    }
    }