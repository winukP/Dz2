using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D.labuda_2
{
    internal class structur2
    {
        public struct Tg
        {
            public string name;
            public string city;
            public int age;
            public int pincod;

        }
        public struct Student
        {
            public string LastName, FirstName;
            public AlcoholCategory Category;
            public double DrinkVolume;
            public Drink FavoriteDrink;

            public double GetPureAlcohol() => DrinkVolume * (FavoriteDrink.AlcoholPercent / 100);
        }
        public struct Drink { public string Name; public double AlcoholPercent; }
        public enum AlcoholCategory
        {
            a,
            b, 
            c, 
            d,
        }
    }
}
