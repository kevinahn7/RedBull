using System;
using System.Collections.Generic;

namespace RedBullProject
{
    public class RedBull
    {
        string[] validRowArray = { "A", "B", "C", "D", "E", "F", "G", "H" };
        private int pawnColumn;
        private string pawnRow;
        private int queenColumn;
        private string queenRow;



        public void SetPawnRow(string location)
        {

            pawnRow = location;
        }

        public string GetPawnRow()
        {

            return pawnRow;
        }

        public void SetPawnColumn(int location)
        {

            pawnColumn = location;
        }

        public int GetPawnColumn()
        {

            return pawnColumn;
        }

        public void SetQueenRow(string location)
        {

            queenRow = location;
        }

        public string GetQueenRow()
        {

            return queenRow;
        }

        public void SetQueenColumn(int location)
        {

            queenColumn = location;
        }

        public int GetQueenColumn()
        {

            return queenColumn;
        }

        public void StartGame()
        {
            GetInputColumnPawn();
            GetInputRowPawn();
        }

        public void GetInputColumnPawn()
        {
            Console.WriteLine("Enter a column location for the pawn to go on with a number 1-8");
            int inputtedColumn = int.Parse(Console.ReadLine());
            if (IsColumnLegit(inputtedColumn))
            {
                PlacePawnColumn(inputtedColumn);
            }
            else
            {
                Console.WriteLine("Enter a valid number!");
                GetInputColumnPawn();
            }
        }

        public void GetInputRowPawn()
        {
            Console.WriteLine("Enter a row location for the pawn to go on with a letter A-H");
            string inputtedRow = Console.ReadLine();
            if (IsRowLegit(inputtedRow))
            {
                PlacePawnRow(inputtedRow);
            }
            else
            {
                Console.WriteLine("Enter a valid number!");
                GetInputRowPawn();
            }
        }

        public void GetInputColumnQueen()
        {
            Console.WriteLine("Enter a column location for the Queen to go on with a number 1-8");
            int inputtedColumn = int.Parse(Console.ReadLine());
            if (IsColumnLegit(inputtedColumn))
            {
                PlaceQueenColumn(inputtedColumn);
            }
            else
            {
                Console.WriteLine("Enter a valid number!");
                GetInputColumnQueen();
            }
        }

        public void GetInputRowQueen()
        {
            Console.WriteLine("Enter a row location for the Queen to go on with a letter A-H");
            string inputtedRow = Console.ReadLine();
            if (IsRowLegit(inputtedRow))
            {
                PlaceQueenRow(inputtedRow);
            }
            else
            {
                Console.WriteLine("Enter a valid number!");
                GetInputRowQueen();
            }
        }

        public bool IsColumnLegit(int input)
        {
            if (input > 0 && input < 9)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsRowLegit(string input)
        {
            bool valid = false;
            for (int i = 0; i < validRowArray.Length; i++)
            {
                if (validRowArray[i] == input.ToUpper())
                {
                    valid = true;
                    break;
                }
            }
            return valid;
        }

        public void PlacePawnColumn(int location)
        {
            SetPawnColumn(location);
        }

        public void PlacePawnRow(string location)
        {
            SetPawnRow(location);
            GetInputColumnQueen();
            GetInputRowQueen();
        }

        public void PlaceQueenColumn(int location)
        {
            SetQueenColumn(location);
        }

        public void PlaceQueenRow(string location)
        {
            SetQueenRow(location);
            CheckIfSameSpot();
        }

        public void CheckIfSameSpot()
        {
            if (pawnColumn == queenColumn && pawnRow == queenRow)
            {
                Console.WriteLine("You picked the same location for the pawn and queen, pick a different one for the queen!");
                GetInputColumnQueen();
                GetInputRowQueen();
            }
            else
            {
                CheckIfQueenAttacks();
            }
        }

        public void CheckIfQueenAttacks()
        {
            if (pawnColumn == queenColumn)
            {
                Console.WriteLine("The queen attacks the pawn horizontally!");
            }
            else if (pawnRow == queenRow)
            {
                Console.WriteLine("The queen attacks the pawn vertically!");
            }
            else if (CheckDiagonal())
            {
                Console.WriteLine("The queen attacks the pawn diagonally!");
            }
            else
            {
                Console.WriteLine("The queen cannot attack the pawn");
            }
            PlayAgain();
        }

        public bool CheckDiagonal()
        {
            bool valid = false;
            int columnDifference = queenColumn - pawnColumn;
            int queenRowPosition = 0;
            int pawnRowPosition = 0;
            for (int x = 0; x < validRowArray.Length; x++)
            {
                if (queenRow.ToUpper() == validRowArray[x])
                {
                    queenRowPosition = x;
                }
                if (pawnRow.ToUpper() == validRowArray[x])
                {
                    pawnRowPosition = x;
                }
            }
            if (columnDifference == (queenRowPosition - pawnRowPosition) || columnDifference == (-1 * (queenRowPosition - pawnRowPosition)))
            {
                valid = true;
            }
            return valid;
        }

        public void PlayAgain()
        {
            Console.WriteLine("Do you want to play this amazing game again? Y or N");
            string response = Console.ReadLine().ToUpper();
            if (response == "Y")
            {
                StartGame();
            }
            else
            {
                Console.WriteLine("Goodbye");
            }
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