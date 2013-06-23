namespace Minesweeper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Minesweeper
    {
        public static void Main(string[] args)
        {
            string command = string.Empty;
            char[,] field = CreateGameField();
            char[,] bombs = PutBombs();
            int currentPlayerPoints = 0;
            bool explosion = false;
            List<PlayerPoints> champions = new List<PlayerPoints>(6);
            int row = 0;
            int col = 0;
            bool isBomb = true;
            const int MaxSizeOfField = 35;
            bool youWin = false;

            do
            {
                if (isBomb)
                {
                    Console.WriteLine("Let's play Minesweeper. Try you luck to find fields without mines." +
                    "Command 'top' shows raiting, 'restart' starting new game, 'exit' exit from game.");
                    CreateBoardGame(field);
                    isBomb = false;
                }

                Console.Write("Please enter row and colomn: ");
                command = Console.ReadLine().Trim();
                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                    int.TryParse(command[2].ToString(), out col) &&
                        row <= field.GetLength(0) && col <= field.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        Rating(champions);
                        break;
                    case "restart":
                        field = CreateGameField();
                        bombs = PutBombs();
                        CreateBoardGame(field);
                        explosion = false;
                        isBomb = false;
                        break;
                    case "exit":
                        Console.WriteLine("Bye, bye!");
                        break;
                    case "turn":
                        if (bombs[row, col] != '*')
                        {
                            if (bombs[row, col] == '-')
                            {
                                SurroundingBombCount(field, bombs, row, col);
                                currentPlayerPoints++;
                            }

                            if (MaxSizeOfField == currentPlayerPoints)
                            {
                                youWin = true;
                            }
                            else
                            {
                                CreateBoardGame(field);
                            }
                        }
                        else
                        {
                            explosion = true;
                        }

                        break;
                    default:
                        Console.WriteLine(Environment.NewLine + "Error! Invalid command!" + Environment.NewLine);
                        break;
                }

                if (explosion)
                {
                    CreateBoardGame(bombs);
                    Console.Write(Environment.NewLine + "Sorry, you lose! Your score is {0} points. ", currentPlayerPoints);
                    Console.Write("Please enter your Name: ");
                    string currentPlayerName = Console.ReadLine();
                    PlayerPoints currentPlayer = new PlayerPoints(currentPlayerName, currentPlayerPoints);
                    if (champions.Count < 5)
                    {
                        champions.Add(currentPlayer);
                    }
                    else
                    {
                        for (int positionChampion = 0; positionChampion < champions.Count; positionChampion++)
                        {
                            if (champions[positionChampion].Points < currentPlayer.Points)
                            {
                                champions.Insert(positionChampion, currentPlayer);
                                champions.RemoveAt(champions.Count - 1);
                                break;
                            }
                        }
                    }

                    champions.Sort((PlayerPoints firstPlayerResult, PlayerPoints secondPlayerResult) => secondPlayerResult.Name.CompareTo(firstPlayerResult.Name));
                    champions.Sort((PlayerPoints firstPlayerResult, PlayerPoints secondPlayerResult) => secondPlayerResult.Points.CompareTo(firstPlayerResult.Points));
                    Rating(champions);

                    field = CreateGameField();
                    bombs = PutBombs();
                    currentPlayerPoints = 0;
                    explosion = false;
                    isBomb = true;
                }

                if (youWin)
                {
                    Console.WriteLine(Environment.NewLine + "Congratulation! You open 35 boxes without mines.");
                    CreateBoardGame(bombs);
                    Console.WriteLine("Please enter your Name: ");
                    string currentPlayerName = Console.ReadLine();
                    PlayerPoints currentPlayer = new PlayerPoints(currentPlayerName, currentPlayerPoints);
                    champions.Add(currentPlayer);
                    Rating(champions);
                    field = CreateGameField();
                    bombs = PutBombs();
                    currentPlayerPoints = 0;
                    youWin = false;
                    isBomb = true;
                }
            }
            while (command != "exit");
            Console.WriteLine("Made in Bulgaria :)!");
            Console.WriteLine("Bye, bye!");
            Console.Read();
        }

        private static void Rating(List<PlayerPoints> players)
        {
            Console.WriteLine(Environment.NewLine + "Scores: ");
            if (players.Count > 0)
            {
                for (int ratingPosition = 0; ratingPosition < players.Count; ratingPosition++)
                {
                    Console.WriteLine("{0}. {1} --> {2} points", ratingPosition + 1, players[ratingPosition].Name, players[ratingPosition].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Empty raiting" + Environment.NewLine);
            }
        }

        private static void SurroundingBombCount(char[,] field, char[,] bombs, int row, int column)
        {
            char bombsNumber = GetNumbersOfSurroundingBombs(bombs, row, column);
            bombs[row, column] = bombsNumber;
            field[row, column] = bombsNumber;
        }

        private static void CreateBoardGame(char[,] board)
        {
            int boardRows = board.GetLength(0);
            int boardColomns = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < boardRows; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < boardColomns; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreateGameField()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];
            for (int currentBoardRow = 0; currentBoardRow < boardRows; currentBoardRow++)
            {
                for (int currentBoardColomn = 0; currentBoardColomn < boardColumns; currentBoardColomn++)
                {
                    board[currentBoardRow, currentBoardColomn] = '?';
                }
            }

            return board;
        }

        private static char[,] PutBombs()
        {
            int fieldRows = 5;
            int fieldColomns = 10;
            char[,] gameField = new char[fieldRows, fieldColomns];

            for (int currentFieldRow = 0; currentFieldRow < fieldRows; currentFieldRow++)
            {
                for (int currentFieldColumn = 0; currentFieldColumn < fieldColomns; currentFieldColumn++)
                {
                    gameField[currentFieldRow, currentFieldColumn] = '-';
                }
            }

            List<int> fieldBombs = new List<int>();
            while (fieldBombs.Count < 15)
            {
                Random random = new Random();
                int currentBomb = random.Next(50);
                if (!fieldBombs.Contains(currentBomb))
                {
                    fieldBombs.Add(currentBomb);
                }
            }

            foreach (int bombLocation in fieldBombs)
            {
                int bombColomnPosition = bombLocation / fieldColomns;
                int bombRowPosition = bombLocation % fieldColomns;
                if (bombRowPosition == 0 && bombLocation != 0)
                {
                    bombColomnPosition--;
                    bombRowPosition = fieldColomns;
                }
                else
                {
                    bombRowPosition++;
                }

                gameField[bombColomnPosition, bombRowPosition - 1] = '*';
            }

            return gameField;
        }

        private static char GetNumbersOfSurroundingBombs(char[,] bombField, int row, int colomn)
        {
            int countOfSurroundingBombs = 0;
            int fieldRows = bombField.GetLength(0);
            int fieldColomns = bombField.GetLength(1);

            if (row - 1 >= 0)
            {
                if (bombField[row - 1, colomn] == '*')
                {
                    countOfSurroundingBombs++;
                }
            }

            if (row + 1 < fieldRows)
            {
                if (bombField[row + 1, colomn] == '*')
                {
                    countOfSurroundingBombs++;
                }
            }

            if (colomn - 1 >= 0)
            {
                if (bombField[row, colomn - 1] == '*')
                {
                    countOfSurroundingBombs++;
                }
            }

            if (colomn + 1 < fieldColomns)
            {
                if (bombField[row, colomn + 1] == '*')
                {
                    countOfSurroundingBombs++;
                }
            }

            if ((row - 1 >= 0) && (colomn - 1 >= 0))
            {
                if (bombField[row - 1, colomn - 1] == '*')
                {
                    countOfSurroundingBombs++;
                }
            }

            if ((row - 1 >= 0) && (colomn + 1 < fieldColomns))
            {
                if (bombField[row - 1, colomn + 1] == '*')
                {
                    countOfSurroundingBombs++;
                }
            }

            if ((row + 1 < fieldRows) && (colomn - 1 >= 0))
            {
                if (bombField[row + 1, colomn - 1] == '*')
                {
                    countOfSurroundingBombs++;
                }
            }

            if ((row + 1 < fieldRows) && (colomn + 1 < fieldColomns))
            {
                if (bombField[row + 1, colomn + 1] == '*')
                {
                    countOfSurroundingBombs++;
                }
            }

            return char.Parse(countOfSurroundingBombs.ToString());
        }
    }
}
