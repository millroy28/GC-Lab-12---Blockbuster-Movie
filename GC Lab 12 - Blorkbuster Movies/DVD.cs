using System;
using System.Collections.Generic;
using System.Text;

namespace GC_Lab_12___Blorkbuster_Movies
{
    class DVD : Movie
    {
        public DVD(string title, Genre category, int runtime, List<string> scenes) : base(title, category, runtime, scenes)
        {
        }

        public override void PlayWholeMovie()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Playing...");
            Console.ResetColor();
            foreach (string scene in Scenes)
            {
                Console.WriteLine($"Scene: {scene}");
            }
        }
        public override void Play()
        {
            GetScene("Using the index number, please select a scene to play: ");
        }

        private void GetScene(string phrase)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine(phrase);
                    PrintScenes();
                    int selection = int.Parse(Console.ReadLine());
                    string scene = Scenes[selection];
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Playing...");
                    Console.ResetColor();
                    Console.WriteLine($"Scene: {scene}");
                    break;
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("I'm sorry, that scene does not exist.");
                    Console.ResetColor();
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input. Please enter a number corresponding to a scene in the following list:");
                    Console.ResetColor();
                }
            }

        }
    }
}
