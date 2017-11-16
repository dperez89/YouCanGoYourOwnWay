using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseYourOwnAdventureStory
{
    class MainStory
    {
        string userInput;
        //member variables
        public MainStory()
        {

        }
        //constructor

        //member methods
        public void MainMenu()
        {
            Console.WriteLine("Welcome to your very own adventure story!", Environment.NewLine, Environment.NewLine);
            Console.WriteLine("In this game, you will choose your actions that will effect the potential outcome of the game.");
            Console.WriteLine("Ultimately you want to try and avoid dying, but don't let the fear of death dissuade you from the thrill of adventure!");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("So.. do you want to play? You can enter the KEYWORD of what you'd like to do.");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("START Game", Environment.NewLine);
            Console.WriteLine("QUIT Game");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("What will you do?:");
            userInput = Console.ReadLine().ToLower();

            if (userInput == "start")
            {
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine("Very well then, let us begin your story!");
                BeginGame();
            }
            else if (userInput == "quit")
            {
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine("Hope to see you again soon!");
            }
            else
            {
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine("Command not recognized, please try again");
                Console.ReadKey();
                Console.Clear();
                MainMenu();
            }
        }
        public void BeginGame()
        {
            Console.Clear();
            Console.WriteLine("The Story...");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("You are taking the role of an adventurer who has just entered into a new land. A true frontier of mysteries, perils, and wonders.");
            Console.WriteLine("However, your journey here is not one of leisure. You have been tasked with traveling to the far side of a dark forest that lay before you.");
            Console.WriteLine("A village at the far edge of the forest eagerly awaits your arrival so that you might lend a hand in protecting them from an invading force");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("You know that navigating this forest will be a test of your character, but you are determined all the same.");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("You slowly take your first steps across the threshold of the forest...");

        }
        public void EndGame()
        {

        }
    }
}
