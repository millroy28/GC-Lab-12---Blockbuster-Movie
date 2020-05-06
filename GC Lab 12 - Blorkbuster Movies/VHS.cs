using System;
using System.Collections.Generic;
using System.Text;

namespace GC_Lab_12___Blorkbuster_Movies
{
    class VHS : Movie
    {

        public int CurrentTime { get; set; } = 0;


        public VHS(string title, Genre category, int runtime, List<string> scenes) : base(title, category, runtime, scenes)
        {

        }

        public override void PlayWholeMovie()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Playing...");
            Console.ResetColor();
            while (CurrentTime < Scenes.Count)
            {
                string scene = Scenes[CurrentTime];
                Console.WriteLine($"Scene: {scene}");
                CurrentTime++;
            }
            Rewind();
        }
        public override void Play()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Playing...");
            Console.ResetColor();
            string scene = Scenes[CurrentTime];
            Console.WriteLine($"Scene: {scene}");
            CurrentTime++;
            if (CurrentTime == Scenes.Count)
            {
                Rewind();
            }
        }

        public void Rewind()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("End of tape: Auto-rewind...");
            Console.ResetColor();
            CurrentTime = 0;
        }
    }
}
