using System;
using System.Collections.Generic;
using System.IO;

namespace StudentDatabase
{
    class Program
    {

        static void Main(string[] args)
        {

          
            List<string> names = new List<string>() { "Mark","Tommy","Andrew","Maggie","Trent","Kevin","Joshua","Troy","Sean","James","Kate","Jerome"};
            List<Students> students = new List<Students>();
            string filePath = @"Students.txt";
            StreamReader reader = new StreamReader(filePath);

            while(reader.EndOfStream != true)
            {
                string student = reader.ReadLine();
                string[] items = student.Split(',');

                students.Add(new Students(items[0], items[1], items[2]));

            }

            //foreach (Students s in students)
            //{
            //    Console.WriteLine(s.Name);
            //}
            

            
            string userAnwser = "y";
            while (userAnwser == "y")
            {
                PrintWholeList(names);
                string input = GetUserInput("which person would you like to learn about? (1-11)");
                int index = int.Parse(input);
                string name = names[index];
                string input1 = GetUserInput($"What would you like to learn about {name}? hometown or favorite food");

                Students selection = null;
                foreach (Students s in students)
                {
                    if (s.Name == name) selection = s;
                }
                if (input1 == "hometown")
                {
                    Console.WriteLine(selection.HomeTown);
                }
                else if (input1 == "favorite food")
                {
                    Console.WriteLine(selection.FavoriteFood);
                }
                Console.Write("would you like to learn about another student? (y/n) ");
                userAnwser = Console.ReadLine().ToLower();

            }


            //string input3 = GetUserInput($"What would you like to learn about {name}?");
            //if (input3 == "favotite food")
            //{
            //    //string filePath = @"Student.txt";
            //    //StreamReader reader = new StreamReader(filePath);
            //}
        }
       
        private static void PrintWholeList(List<string> items)
        {
            for (int i = 0; i < items.Count; i++)
            {

                Console.WriteLine($"{i}: {items[i]}");
            }
        }

        public static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine().ToLower().Trim();
            return input;
        }

        public static void AddStudent()
        {
            string filePath = "Students.txt";
            Students s = new Students();
            Console.WriteLine("Please input a name");
            s.Name = Console.ReadLine();

            Console.WriteLine("Please input your favorite food");
            s.FavoriteFood = Console.ReadLine();

            Console.WriteLine("Please input your hometown");
            s.HomeTown = Console.ReadLine();

            string line = StudentToString(s);
            Console.WriteLine(line);

            StreamReader reader = new StreamReader(filePath);
            string original = reader.ReadToEnd();

            StreamWriter writer = new StreamWriter(filePath);
            writer.Write(original + line);

            writer.Close();


        }

        public static string StudentToString(Students s)
        {
            string output = $"{s.Name}, {s.FavoriteFood}, {s.HomeTown}";
            return output;
        }
    }
}
