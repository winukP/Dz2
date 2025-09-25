using enUm;
using Structur;
using System;

namespace Tumakov
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            //1
            En.Bank shet1 = En.Bank.Sberegshet;
            En.Bank shet2 = En.Bank.Tekushet;
            Console.WriteLine(shet1);
            Console.WriteLine(shet2);
            //2
            Struuct.Sber akkaunt;
            akkaunt.num = int.Parse(Console.ReadLine());
            akkaunt.tip = Console.ReadLine();
            akkaunt.balans = int.Parse(Console.ReadLine());
            Console.WriteLine(akkaunt.num);
            Console.WriteLine(akkaunt.tip);
            Console.WriteLine(akkaunt.balans);
            //3
            En.Vuz vuz1 = En.Vuz.KGU;
            En.Vuz vuz2 = En.Vuz.KAI;
            En.Vuz vuz3 = En.Vuz.KHTI;
            Struuct.Rabotnik student;
            student.name = Console.ReadLine();
            student.vuz = vuz1;
            Console.WriteLine(student.name);
            Console.WriteLine(student.vuz);
            Console.ReadKey();
        }
    }
}
