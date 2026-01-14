using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace text_strory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            player spelfigur1 = new player();
            {
                spelfigur1.name = "kevin";
                spelfigur1.health = 20;
            };


            Console.WriteLine($"du heter {spelfigur1.name} och har {spelfigur1.health}hp");
            Console.WriteLine("Du vaknar upp i en kall fängelsecell.");
            Console.WriteLine("Det finns en dörr och ett litet fönster");
            Console.WriteLine("Vad vill du göra");
            Console.WriteLine("1) öppna dörren \n2) öppna fönstert \n3) leta runt i rummet");
            
            string input = Console.ReadLine();
            if (input == "1")
            {
                Console.WriteLine("Det är låst");
            }
            else if(input == "2")
            {
                Console.WriteLine("Det är låst");
            }
            else if (input == "3")
            {
                Console.WriteLine("Du hittade en nyckel");
            }


            Console.ReadKey();
        }

        class player
        {
            public string name;
            public int health;
        }
    }
}
