using System;
using System.Collections.Generic;
using System.Text;

namespace StudentDatabase
{
    public class Students
    {

        public string Name { get; set; }
        public string FavoriteFood { get; set; }

        public string HomeTown { get; set; }

        public Students(string Name, string FavoriteFood, string HomeTown)
        {
            this.Name = Name;
            this.FavoriteFood = FavoriteFood;
            this.HomeTown = HomeTown;
        }

        public Students() { }

        public void toString()
        {
            Console.WriteLine($"{this.Name}, {this.HomeTown}, {this.FavoriteFood}");
        }
    }
}
