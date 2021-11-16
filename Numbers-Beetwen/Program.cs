using System;

namespace Numbers_Beetwen
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            string command;


        START:
            Console.WriteLine("=== MrMean | NumbersBeetwen ===\n");


            Console.Write("Enter number one:");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter number two:");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine();

            if (num1 > num2)
            {
                Console.WriteLine($"[{num1}] -> ");
                for (int i = num1 - 1; i > num2; i--)
                {
                    Console.WriteLine($" |{i}| ");
                }
                Console.WriteLine($"-> [{num2}]");
            }
            else if (num1 < num2)
            {
                Console.WriteLine($"[{num2}] -> ");
                for (int i = num2 - 1; i > num1; i--)
                {
                    Console.WriteLine($" |{i}| ");
                }
                Console.WriteLine($"-> [{num1}]");
            }
            else
            {
                Console.WriteLine("Unknown error!");
                goto END;
            }

        END:
            Console.Write("\nRestart program? (y/n): ");
            command = Console.ReadLine().ToLower();

            if (command == "y")
            {
                Console.Clear();
                goto START;
            }
            else
            {
                Environment.Exit(0);
            }

            Console.ReadKey();
        }
    }
}
