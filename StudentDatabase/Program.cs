using System;
using System.Collections.Generic;

namespace StudentDatabase
{
    class Program
    {
        private static bool message;

        static void Main(string[] args)
        {

            List<string> names = new List<string>() { "Mark","Tommy","Andrew","Maggie","Trent","Kevin","Joshua","Troy","Sean","James","Kate","Jerome"};

            List<string> food = new List<string>() { "Cilantro", "Chicken curry","Sushi","Movie theatre popcorn", "Tacos","Asian Cuisine", "Nalesniki", "Broccoli","Meat", "Sushi","Pizza","Italian Cuisine" };

            List<string> hometown = new List<string>() { "Grand Rapids", "Raleigh, NC", "Grayslake","Montrose","Rochester","Detroit","Northville","Indian River","Eaton Rapids","Toledo","Zeeland","Milwaukee" };






            PrintWholeList(names);
            string input = GetUserInput("which person would you like to learn about?");
            int index = int.Parse(input);
            string name = names[index];
            string input2 = GetUserInput ($"What would you like to learn about {name}? hometown or favoritefood");
           if (input2 == "hometown")
            {
                string ht = hometown[index];
                Console.WriteLine(ht);
            }

            string input3 = GetUserInput($"What would you like to learn about {food}?");
            if (input3 == "food")
            {
                string fd = food[index];
                Console.WriteLine(fd);
            }
        }

       
        private static void PrintWholeList(List<string> items)
        {
            for (int i = 0; i < items.Count; i++)
            {

                Console.WriteLine($"{i}: {items[i]}");
            }
        }

        public static string GetUserInput(string messsage)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine().ToLower().Trim();
            return input;
        }
    }
}
