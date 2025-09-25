using D.labuda_2;
using System;
using System.Data.SqlTypes;
using static D.labuda_2.structur2;
using static System.Net.Mime.MediaTypeNames;

namespace D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 макс и мин тип
            Console.WriteLine($"byte {byte.MaxValue} {byte.MinValue}");
            Console.WriteLine($"sbyte {sbyte.MaxValue} {sbyte.MinValue}");
            Console.WriteLine($"short {short.MaxValue} {short.MinValue}");
            Console.WriteLine($"ushort {ushort.MaxValue} {ushort.MinValue}");
            Console.WriteLine($"int {int.MaxValue} {int.MinValue}");
            Console.WriteLine($"uint {uint.MaxValue} {uint.MinValue}");
            Console.WriteLine($"long {long.MaxValue} {long.MinValue}");
            Console.WriteLine($"ulong {ulong.MaxValue} {ulong.MinValue}");
            Console.WriteLine($"float {float.MaxValue} {float.MinValue}");
            Console.WriteLine($"double {double.MaxValue} {double.MinValue}");
            Console.WriteLine($"decimal {decimal.MaxValue} {decimal.MinValue}");
            Console.WriteLine($"char {(int)char.MaxValue} {(int)char.MinValue}");
            Console.WriteLine($"bool {1} {0}");
            //2 данные записать и вывести
            structur2.Tg akk;
            akk.name=Console.ReadLine();
            akk.city = Console.ReadLine();
            akk.age = int.Parse(Console.ReadLine());
            akk.pincod = int.Parse(Console.ReadLine());
            Console.WriteLine(akk.name);
            Console.WriteLine(akk.city);
            Console.WriteLine(akk.age);
            Console.WriteLine(akk.pincod);
            //3 заглавные в строчные
            string zag = Console.ReadLine();
            zag = zag.ToLower();
            Console.WriteLine(zag);
            //4 сколько повторок
            string st=Console.ReadLine();
            string podst=Console.ReadLine();
            int count = podst.Split(new[] { st }, StringSplitOptions.None).Length - 1;
            Console.WriteLine(count);
            //5 отпуск или
            int normPrice=int.Parse(Console.ReadLine());
            int salePrice = int.Parse(Console.ReadLine());
            int holidayPrice = int.Parse(Console.ReadLine());
            if (salePrice == 0)
            {
                Console.WriteLine("Не светит отпуск");
            }
            else
            {
                double but = holidayPrice / (normPrice * (salePrice / 100.0));
                Console.WriteLine(Math.Round(but));
            }
            //6
            structur2.Student[] students = {
            new structur2.Student { LastName="Иванов", FirstName="Иван", Category=AlcoholCategory.a,
                         DrinkVolume=2000, FavoriteDrink=new Drink { Name="Пиво", AlcoholPercent=5 } },
            new structur2.Student { LastName="Петров", FirstName="Петр", Category=AlcoholCategory.b,
                         DrinkVolume=500, FavoriteDrink=new Drink { Name="Водка", AlcoholPercent=40 } },
            new structur2.Student { LastName="Галкин", FirstName="Кирилл", Category=AlcoholCategory.c,
                         DrinkVolume=300, FavoriteDrink=new Drink { Name="Вино", AlcoholPercent=10 } },
            new structur2.Student { LastName="Матросов", FirstName="Илья", Category=AlcoholCategory.d,
                         DrinkVolume=150, FavoriteDrink=new Drink { Name="Пиво", AlcoholPercent=4 } },
            new structur2.Student { LastName="Росов", FirstName="Рафик", Category=AlcoholCategory.b,
                         DrinkVolume=60, FavoriteDrink=new Drink { Name="Квас", AlcoholPercent=1 } },
            };
            double totalVolume = 0, totalAlcohol = 0;
            foreach (var s in students)
            {
                totalVolume += s.DrinkVolume;
                totalAlcohol += s.GetPureAlcohol();
            }
            Console.WriteLine($"Общий объем: {totalVolume} мл");
            Console.WriteLine($"Общий алкоголь: {totalAlcohol:F2} мл");

            foreach (var s in students)
            {
               double volPercent = (s.DrinkVolume / totalVolume) * 100;
               double alcPercent = (s.GetPureAlcohol() / totalAlcohol) * 100;
               Console.WriteLine($"{s.LastName}: {volPercent:F1}% жидкости, {alcPercent:F1}% алкоголя");
            }
        Console.ReadKey();

        }
    }
}
