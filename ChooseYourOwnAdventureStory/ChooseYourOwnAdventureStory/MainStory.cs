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
            Console.WriteLine("So.. do you want to play? You can either enter the number of the selection you'd like or enter the KEYWORD of what you'd like to do.");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("START Game", Environment.NewLine);
            Console.WriteLine("QUIT Game");
            userInput = Console.ReadLine().ToLower();

            if (userInput == "start")
            {
                Console.WriteLine("You have started a new game!");
            }
            else if (userInput == "quit")
            {
                Console.WriteLine("You have quit the game!");
            }
            else
            {
                Console.WriteLine("Command not recognized, please try again");
                Console.Clear();
                MainMenu();
            }
        }
        public void BeginGame()
        {

        }
        public void EndGame()
        {

        }
    }
}
