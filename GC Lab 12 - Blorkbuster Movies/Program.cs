using System;
using System.Collections.Generic;

namespace GC_Lab_12___Blorkbuster_Movies
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Blockbuster myStore = new Blockbuster();
            bool contRun = true;
            while (contRun)
            {
                Console.Clear();
                myStore.CheckOut();
                Console.WriteLine();
                contRun = GetYesOrNo("Would you like to view another movie? y/n");
            }


        }
        public static bool GetYesOrNo(string prompt)
        {
            //Prompts user for y/n; returns true for y and false for n
            while (true)
            {
                Console.WriteLine(prompt);
                string input = Console.ReadLine().ToLower();

                if (input == "y")
                    return true;
                else if (input == "n")
                    return false;
                else
                    Console.WriteLine("I'm sorry, I didn't get that.");
            }
        }
    }
}
