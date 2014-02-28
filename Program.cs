using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 12; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                    //This is the master branch

                }
            }
                Console.WriteLine("Enter name: ");
                if(Console.ReadLine().ToUpper() == "Filip".ToUpper())
                {
                    Console.WriteLine("You need a helicopter");
                }
            if (Console.ReadLine().ToUpper() == "Ivan".ToUpper())
               {
                        Console.WriteLine("Cool dude,I respect him");
               }
                    
                        if (Console.ReadLine().ToUpper() == "Lukas".ToUpper())
                        {
                            Console.WriteLine("Good at poker and programming");
                        }

                    }
                }
               
               
          }