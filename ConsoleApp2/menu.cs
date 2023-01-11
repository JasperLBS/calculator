using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Menu
    {
        private string userInput;
        private bool programRunning;
        public int userChoice;

        public Menu()
        {
            userInput = String.Empty;
            programRunning = true;
            userChoice = 0;
        }

        public void Run()
        {
            Console.WriteLine("Hello and welcome to Calculator");

            while (programRunning)
            {
                PrintMenu();
                userChoice = GetCorrectInput();
                ExecuteChoice(userChoice);
            }

        }

        private void PrintMenu()
        {
            Console.WriteLine("MENU");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraktion");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("Enter \"quit\" to exit");
            Console.Write("Enter choice:");
        }

        int GetCorrectInput()
        {
            int choice;
            userInput = Console.ReadLine();
            if (userInput == "quit")
            {
                programRunning = false;
                return 0;
            }
            else
            {
                choice = int.Parse(userInput);
                return choice;
            }

        }

        void ExecuteChoice(int choiceMade)
        {
            switch (choiceMade)
            {
                //Addition
                case 1:
                    calucator.Addition();
                    break;
                //Subtraktion
                case 2:
                    break;
                //Multiplikation
                case 3:
                    break;
                //Division
                case 4:
                    break;
                default:
                    break;
            }
        }

    }
}