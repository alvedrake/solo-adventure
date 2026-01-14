using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace text_strory
{
    internal class Program
    {
       


        static void Main(string[] args)
        {


            Player spelfigur1 = new Player("kevin", 20, false);
           

            Player spelfigur2 = new Player("kevin2", 21, false);


            spelfigur1.PrintInfo();
            spelfigur1.TakeDamage(5);
            spelfigur1.PrintInfo();
            spelfigur2.PrintInfo();



            Console.WriteLine("Du vaknar upp i en kall fängelsecell.");
            Console.WriteLine("Det finns en dörr och ett litet fönster");
            Console.WriteLine("Vad vill du göra");
            Console.WriteLine("1) öppna dörren \n2) öppna fönstert \n3) leta runt i rummet");

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "1")
                {
                    Console.WriteLine("Det är låst");
                    if (spelfigur1.hasKey == true)
                    {
                        Console.WriteLine("Dörren gick upp");
                        spelfigur1.hasKey = false;
                        break;
                    }

                }
                else if (input == "2")
                {
                    Console.WriteLine("Det är låst");
                    if (spelfigur1.hasKey == true)
                    {
                        Console.WriteLine("Den fick inte plats");
                    }
                }
                else if (input == "3")
                {
                    Console.WriteLine("Du hittade en nyckel");
                    spelfigur1.hasKey = true;
                }
            }
            Console.WriteLine("game over");


            Console.ReadKey();
        }
    }

    class room
    {

    }
    class Player
    {
        // FÄLT
        public string name;
        public int health;
        public bool hasKey;


        //konstruktor
        public Player(string n, int h, bool k)
        {
            name = n;
            health = h;
            hasKey = k;
        }

        //INSTANSMETODER
        public void PrintInfo()
        {
            Console.WriteLine($"Du heter {name} och du har {health}hp");
        }

        public void TakeDamage(int damage) 
        {
            health = health - damage;
        }
    }
    
}
