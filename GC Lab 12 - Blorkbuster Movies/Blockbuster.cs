using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Runtime.CompilerServices;
using System.Text;

namespace GC_Lab_12___Blorkbuster_Movies
{
    class Blockbuster
    {
        //field
        private List<Movie> movies;// = new List<Movie>();
        //property
        public List<Movie> Movies
            
        {
            get { return movies; }
            set { movies = value; }
        }
            
        
        public Blockbuster()
        {
            movies = new List<Movie>()
            {
                new DVD("Where Once She Went While Weaving West", Genre.Drama, 137, new List<string>() {"Arrival in Allandale", "She Sweetly Sings Slowly", "Dovetails Do Dally", "Departure", "She Went, Once"}),
                new VHS("Smidgeon the Pidgeon Goes to Newark", Genre.Comedy, 87, new List<string>(){"Smidgeon Finds an Everything Bagel", "Everything is Not as it Seems", "Street Sweeper Attacks", "Mayor Gibson's Speach", "Lousy with Lice!", "Just a Smidge"}),
                new VHS("Race Condition", Genre.Action, 102, new List<string>(){"Dingo Gets a New Deal", "Hacking the Mainframe", "Detectives Knock Five Times", "Run for Your Life", "Race Condition Critical"}),
                new DVD("Stabby Party II", Genre.Horror, 99, new List<string>(){"Sharpest Knife in the Drawer", "She's Not Going to Email You No More", "Let's Get This Party Started", "Feeling Drained"}),
                new VHS("While She Whispers on the Wings of Angels", Genre.Romance, 156, new List<string>() {"Beth's Birthday Boy Bounces", "Where We Went Wrong Was Wanting", "Elbow Macaroni", "Red Rover Ran", "Leave Leaving Like Lovers Like Loving", "Buffalos Buffalo Buffalo Buffalos...", "Every Heart Hears Heavy Hurt Healing", "All That's Done Undone is Done" }),
                new DVD("Gaberdeen", Genre.Drama, 89, new List<string>(){"Remember Wendy...","Pipe Dreams", "Ricky's Back", "School's In", "Time Travel is Lonely", "The Trouble with Dribbles", "Reunion", "Closing Time" })
            };
        }
        
        //= new List<Movie>();         

        
        
        //public static List<string> GenerateMovieList()
        //{

        //List<string> movie1Scenes = new List<string>();

        

        //}
        public void PrintMovies()
        {
            int i = 0;
            foreach (Movie movie in movies)
            {
                Console.WriteLine($"{i}: {movie.Title}");
                i++;
            }
        }
        
        public void CheckOut()
        {
            Console.WriteLine("Welcome to Blorkbuster Honest Movie Rental!");
            Console.WriteLine();
            Console.WriteLine("We have the following titles available to play:");
            PrintMovies();
            int selection = 0;
            while(true)
            {
                try
                {
                    Console.WriteLine("Please select the movie you'd like to see");
                    selection = int.Parse(Console.ReadLine());
                    movies[selection].PrintInfo();
                    break;                    
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("I'm sorry, that wasn't a valid number");
                    Console.ResetColor();
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("I'm sorry, that movie does not exist.");
                    Console.ResetColor();
                }
            }

            bool playAll = GetYesOrNo("Would you like to play the entire movie? y/n");
            if (playAll)
            {
                movies[selection].PlayWholeMovie();
            }
            else
            {
                bool playAnother = true;
                while (playAnother)
                {
                    movies[selection].Play();
                    playAnother = GetYesOrNo("Would you like to play another scene? y/n");

                }

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
