using System;

namespace RedBullProject
{
    public class RedBull
    {
        public void StartGame()
        {
            this.GetInput();
        }

        public void GetInput()
        {
            Console.WriteLine("sdfdsfsd");
            var inputtedValue = Console.ReadLine();
            this.IsLegitInput(inputtedValue);
        }

        public bool IsLegitInput(string input)
        {
            if (input == "A")
            {
                return true;
            }

            return false;
        }


    }



    public class Program
    {

        public static void Main(string[] args)
        {
            RedBull newGame = new RedBull();
            newGame.StartGame();
        }

    }

}