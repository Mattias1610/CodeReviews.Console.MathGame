using System;
using System.Collections.Generic;

namespace Math_Game
{
    internal class Game
    {
        private Random ran = new Random();
        private List<int> scores = new List<int>();

        public void GameStart()
        {
            Console.WriteLine("Welcome to the Math Game!");

            bool play = true;

            while (play)
            {
                Console.WriteLine("\nChoose an option:\n" +
                                  "1. ADDITION\n" +
                                  "2. SUBTRACTION\n" +
                                  "3. MULTIPLICATION\n" +
                                  "4. DIVISION\n" +
                                  "5. VIEW HISTORY\n" +
                                  "6. EXIT");
                Console.Write("Enter your choice (1-6): ");
                string operation = Console.ReadLine();

                switch (operation)
                {
                    case "1":
                    case "2":
                    case "3":
                    case "4":
                        int score = PlayGame(operation);
                        scores.Add(score);
                        Console.WriteLine($"Your score for this round: {score}");
                        break;

                    case "5":
                        ViewHistory();
                        break;

                    case "6":
                        play = false;
                        Console.WriteLine("Thanks for playing!");
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please choose a number between 1 and 6.");
                        break;
                }
            }
        }

        private int PlayGame(string operation)
        {
            bool isRunning = true;
            int score = 0;

            while (isRunning)
            {
                int num1 = ran.Next(0, 100);
                int num2 = operation == "3" ? ran.Next(0, 10) : ran.Next(1, 100);
                int result = 0;
                string operationSymbol = "";

                switch (operation)
                {
                    case "1": // Addition
                        result = num1 + num2;
                        operationSymbol = "+";
                        break;
                    case "2": // Subtraction
                        result = num1 - num2;
                        operationSymbol = "-";
                        break;
                    case "3": // Multiplication
                        result = num1 * num2;
                        operationSymbol = "*";
                        break;
                    case "4": // Division
                        while (num2 == 0 || num1 % num2 != 0)
                        {
                            num1 = ran.Next(0, 100);
                            num2 = ran.Next(1, 10);
                        }
                        result = num1 / num2;
                        operationSymbol = "/";
                        break;
                }

                Console.WriteLine($"\t{num1} {operationSymbol} {num2} = ?");
                int userResult = GetUserInput();

                if (userResult == result)
                {
                    Console.WriteLine("Correct!");
                    score++;
                }
                else
                {
                    Console.WriteLine("Incorrect. Ending this round.");
                    isRunning = false;
                }
            }

            return score;
        }

        private void ViewHistory()
        {
            if (scores.Count == 0)
            {
                Console.WriteLine("No games played yet.");
                return;
            }

            Console.WriteLine("\nHistory of Previous Games:");
            for (int i = 0; i < scores.Count; i++)
            {
                Console.WriteLine($"Game {i + 1}: Score = {scores[i]}");
            }
        }

        private int GetUserInput()
        {
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int result))
                {
                    return result;
                }
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }
}
