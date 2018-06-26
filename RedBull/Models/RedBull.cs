using System;
using System.Collections.Generic;

namespace RedBullProject
{
    public class RedBull
    {
        string[] validRowArray = { "A", "B", "C", "D", "E", "F", "G", "H" };
        private int Column { set; get; }
        private string Row { set; get; }


        public void StartGame()
        {
            this.GetInput();
        }

        public void GetInput()
        {
            Console.WriteLine("Enter a column location for the pawn to go on with a number 1-8");
            int inputtedColumn = int.Parse(Console.ReadLine());
            this.IsColumnLegit(inputtedColumn);
            Console.WriteLine("Enter a row location for the pawn to go on with a letter A-H");
            string inputtedRow = Console.ReadLine().ToUpper();
            this.IsRowLegit(inputtedRow);
        }

        public void IsColumnLegit(int input)
        {
            if (input > 0 && input < 9)
            {
                
            }
            else 
            {
                Console.WriteLine("That is not a valod input");
                this.GetInput();
            }
        }

        public bool IsRowLegit(string input)
        {
            
            bool valid = false;
            for (int i = 0; i < validRowArray.Length; i++)
            {
                if (validRowArray[i] == input)
                {
                    valid = true;
                    break;
                }
            }
            return valid;
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