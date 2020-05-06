using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace GC_Lab_12___Blorkbuster_Movies
{
       
    abstract class Movie
    {   //properties:
        public string Title { get; set; }

        public Genre Category { get; set; }

        public int RunTime { get; set; }
        
        public List<string> Scenes { get; set; }

        public Movie(string title, Genre category, int runtime, List<string> scenes)
        {
            Title = title;
            Category = category;
            RunTime = runtime;
            Scenes = scenes;

        }

        //methods
        public abstract void PlayWholeMovie();
        public abstract void Play();

        public virtual void PrintInfo()
        {
            Console.Clear();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Title: {Title}");
            Console.ResetColor();
            Console.WriteLine($"Category: {Category}");
            Console.WriteLine($"Runtime {RunTime}");
        }

        public void PrintScenes()
        {
            int i = 0;
            foreach(string scene in Scenes)
            {
                Console.WriteLine($"{i}: {scene}");
                i++;
            }
        }




    }
}
