using System;
using System.Collections.Concurrent;
using System.Net;

namespace PerfectCountdown
{
    public class Program
    {
        private static void Main(string[] args)
        {
            

            int start2 = 0;
        
            while (start2 < 1)
                {

                Console.Write("Start number:");
                int start = int.Parse(Console.ReadLine());
                Console.Write("Step number:");
                int step = int.Parse(Console.ReadLine());
                if (start <1)
                {
                    Console.WriteLine("Out-of-range start or step. Try again");
                }
                if (step <1)
                {
                    Console.WriteLine("Out-of-range start or step. Try again");
                }
                if (step>=start)
                {
                    Console.WriteLine("Start must be higher than step. Try again");
                }
                if (start%step != 0)
                {
                    Console.WriteLine("Start not divisible by step. Try again");
                }
                else
                {
                    for (int x = start; x >= 0; x -= step)
                        Console.WriteLine($"{x}");
                    break;
                }
                }
                }

              
            

        }
    }
