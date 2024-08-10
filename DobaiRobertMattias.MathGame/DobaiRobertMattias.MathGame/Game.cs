using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Game
{
    internal class Game
    {
        public void gameStart()
        {
            Console.WriteLine("So, we will show you some operations and you have to type the correct answer \n");

            bool play = true;

            int num = 0;
            int[] scores = new int[100];




            while (play)
            {
                Console.WriteLine("Choose your operation\n" +
                "1.ADDITION\n" +
                "2.SUBSTRACTION\n" +
                "3.MULTIPLICATION\n" +
                "4. DIVISION\n ");
                Console.WriteLine("Wich one you wanna start with?");
                Console.WriteLine("1/2/3/4");
                string operation = Console.ReadLine();

                int score = 0;
                bool isRunning = true;



                switch (operation)
                {
                    case "1":


                        Console.WriteLine("You chose ADDITION, let's go!");
                        while (isRunning)
                        {

                            Random ran = new Random();
                            int num1 = ran.Next(0, 100);
                            int num2 = ran.Next(0, 100);

                            int result = num1 + num2;
                            Console.WriteLine($"\t {num1} + {num2}=");
                            int userResult = Convert.ToInt32(Console.ReadLine());

                            if (userResult == result)
                            {
                                Console.WriteLine("Correct\t");
                                score++;

                            }
                            else
                            {
                                isRunning = false;
                                Console.WriteLine("Incorrect");


                            }
                        }
                        break;
                    case "2":
                        isRunning = true;

                        Console.WriteLine("You chose SUBSTRACTION, let's go!");
                        while (isRunning)
                        {

                            Random ran = new Random();
                            int num1 = ran.Next(0, 100);
                            int num2 = ran.Next(0, 100);

                            int result = num1 - num2;
                            Console.WriteLine($"\t {num1} - {num2}=");
                            int userResult = Convert.ToInt32(Console.ReadLine());

                            if (userResult == result)
                            {
                                Console.WriteLine("Correct\t");
                                score++;
                            }
                            else
                            {
                                isRunning = false;
                                Console.WriteLine("Incorrect");

                            }
                        }
                        break;
                    case "3":
                        isRunning = true;

                        Console.WriteLine("You chose MULTIPLICATION, let's go!");
                        while (isRunning)
                        {

                            Random ran = new Random();
                            int num1 = ran.Next(0, 100);
                            int num2 = ran.Next(0, 10);

                            int result = num1 * num2;
                            Console.WriteLine($"\t {num1} * {num2}=");
                            int userResult = Convert.ToInt32(Console.ReadLine());

                            if (userResult == result)
                            {
                                Console.WriteLine("Correct\t");
                                score++;
                            }
                            else
                            {
                                isRunning = false;
                                Console.WriteLine("Incorrect");

                            }
                        }
                        break;
                    case "4":
                        isRunning = true;

                        Console.WriteLine("You chose ADDITION, let's go!");
                        while (isRunning)
                        {

                            Random ran = new Random();
                            int num1 = ran.Next(0, 100);
                            int num2 = ran.Next(1, 10);

                            if (num1 % num2 == 0)
                            {
                                int result = num1 / num2;
                                Console.WriteLine($"\t {num1} / {num2}=");
                                int userResult = Convert.ToInt32(Console.ReadLine());

                                if (userResult == result)
                                {
                                    Console.WriteLine("Correct\t");
                                    score++;
                                }
                                else
                                {
                                    isRunning = false;
                                    Console.WriteLine("Incorrect");

                                }
                            }

                            else
                            {
                                num2 = ran.Next(1, 10);
                            }

                        }
                        break;
                }

                scores[num] = score;
                num++;

                Console.WriteLine($"Your score for this round: {score}");
                Console.WriteLine("Wanna play again? Y/N");
                string playAgain = Console.ReadLine()?.ToUpper();

                if (playAgain != "Y")
                {
                    play = false;
                }

            }

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"{i + 1}.Score = {scores[i]}");
            }


        }
    }
}