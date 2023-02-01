using System;
namespace MyApp // Note: actual namespace depends on the project name.
{
    class Program
    {
        static int score = 0;
        static int currentScore;
        static string screen = "Normal";
        static string volume = "| ~~~~~~~~~~ | 5";
        static string graphic = "Medium";

        static void Main(string[] args)
        {
            Console.Title = "Little Math Game";
            Console.SetWindowSize(120, 30);
            Console.SetWindowPosition(0, 0);
            Console.SetBufferSize(120, 30);

            MainMenu();
        }

        static void MainMenu()
        {
            Console.WriteLine("Little Math Game");
            Console.WriteLine();
            Console.WriteLine("[P] Play Game");
            Console.WriteLine("[H] High Score");
            Console.WriteLine("[O] Option");
            Console.WriteLine("[Q] Quit Game");
            Console.WriteLine();

            char[] menu = { 'P', 'p', 'H', 'h', 'O', 'o', 'Q', 'q' };

            for (int i = 0; i < 1; i++)
            {
                menu[i] = Convert.ToChar(Console.ReadLine());

                switch (menu[i])
                {
                    case 'P' or 'p':
                        currentScore = 0;
                        PlayGame();
                        break;

                    case 'H' or 'h':
                        HighScore();
                        break;

                    case 'O' or 'o':
                        Option();
                        break;

                    case 'Q' or 'q':
                        QuitGame();
                        break;
                }
            }
        }

        static void PlayGame()
        {
            Console.WriteLine();
            Console.WriteLine("Loading...");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();

            Random randomNum = new Random();
            int num01, num02, correctAnswer, userAnswer;

            string quiting = null;

            while (quiting != ConsoleKey.Q.ToString())
            {
                Console.WriteLine("Game is Playing");
                Console.WriteLine();
                Console.WriteLine("[Q] Back to Main Menu");
                Console.WriteLine();
                Console.WriteLine("Your Score is " + currentScore);

                try
                {
                    num01 = randomNum.Next(0, 10);
                    num02 = randomNum.Next(0, 10);
                    string chooseOperator = randomNum.Next(1, 4).ToString();

                    switch (chooseOperator)
                    {
                        case "1":
                            correctAnswer = num01 + num02;

                            Console.WriteLine("What is " + num01 + " + " + num02);

                            userAnswer = int.Parse(Console.ReadLine());

                            if (correctAnswer == userAnswer)
                            {
                                currentScore += 1;
                                Console.WriteLine("You are right!!");
                                Console.WriteLine();
                                System.Threading.Thread.Sleep(1000);
                                Console.Clear();
                            }
                            else
                            {
                                Console.WriteLine("You are wrong X");
                                Console.WriteLine();
                                System.Threading.Thread.Sleep(1000);
                                Console.Clear();
                            }
                            break;

                        case "2":
                            correctAnswer = num01 - num02;

                            Console.WriteLine("What is " + num01 + " - " + num02);

                            userAnswer = int.Parse(Console.ReadLine());

                            if (correctAnswer == userAnswer)
                            {
                                currentScore += 1;
                                Console.WriteLine("You are right!!");
                                Console.WriteLine();
                                System.Threading.Thread.Sleep(1000);
                                Console.Clear();
                            }
                            else
                            {
                                Console.WriteLine("You are wrong X");
                                Console.WriteLine();
                                System.Threading.Thread.Sleep(1000);
                                Console.Clear();
                            }
                            break;

                        case "3":
                            correctAnswer = num01 * num02;

                            Console.WriteLine("What is " + num01 + " * " + num02);

                            userAnswer = int.Parse(Console.ReadLine());

                            if (correctAnswer == userAnswer)
                            {
                                currentScore += 1;
                                Console.WriteLine("You are right!!");
                                Console.WriteLine();
                                System.Threading.Thread.Sleep(1000);
                                Console.Clear();
                            }
                            else
                            {
                                Console.WriteLine("You are wrong X");
                                Console.WriteLine();
                                System.Threading.Thread.Sleep(1000);
                                Console.Clear();
                            }
                            break;

                        case "4":
                            correctAnswer = num01 / num02;

                            if (num01 > num02)
                            {
                                num01 = randomNum.Next(0, 10);
                                num02 = randomNum.Next(0, 10);
                            }
                            else
                            {

                            }

                            Console.WriteLine("What is " + num01 + " / " + num02);

                            userAnswer = int.Parse(Console.ReadLine());

                            if (correctAnswer == userAnswer)
                            {
                                currentScore += 1;
                                Console.WriteLine("You are right!!");
                                Console.WriteLine();
                                System.Threading.Thread.Sleep(1000);
                                Console.Clear();
                            }
                            else
                            {
                                Console.WriteLine("You are wrong X");
                                Console.WriteLine();
                                System.Threading.Thread.Sleep(1000);
                                Console.Clear();
                            }
                            break;
                    }
                }

                catch (Exception)
                {
                    quiting = ConsoleKey.Q.ToString();
                    Console.WriteLine();
                    Console.WriteLine("Loading...");
                    System.Threading.Thread.Sleep(1000);
                }
            }

            if (quiting != null)
            {
                Console.Clear();
                MainMenu();
            }
        }

        static void HighScore()
        {
            if (score >= currentScore)
            {
                score = score;
            }
            else if (score <= currentScore)
            {
                score = currentScore;
            }

            Console.WriteLine();
            Console.WriteLine("Loading...");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();

            Console.WriteLine("Highscore");
            Console.WriteLine();
            Console.WriteLine("[R] Reset Your High Score");
            Console.WriteLine("[Q] Back to Main Menu");
            Console.WriteLine();
            Console.WriteLine("Your High Score is " + score);
            Console.WriteLine();

            char[] highScoreMenu = { 'R', 'r', 'Q', 'q' };

            for (int i = 0; i < 1; i++)
            {
                highScoreMenu[i] = Convert.ToChar(Console.ReadLine());

                switch (highScoreMenu[i])
                {
                    case 'R' or 'r':
                        score = 0;
                        currentScore = 0;
                        Console.Clear();
                        HighScore();
                        break;

                    case 'Q' or 'q':
                        Console.WriteLine();
                        Console.WriteLine("Loading...");
                        System.Threading.Thread.Sleep(1000);
                        Console.Clear();
                        MainMenu();
                        break;
                }
            }
        }

        static void Option()
        {
            Console.WriteLine();
            Console.WriteLine("Loading...");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();

            Console.WriteLine("Option");
            Console.WriteLine();
            Console.WriteLine("[Q] Back to Main Menu");
            Console.WriteLine();
            Console.WriteLine("Windows Screen > " + screen);
            Console.WriteLine("[B] Biggest");
            Console.WriteLine("[N] Normal");
            Console.WriteLine("[S] Smallest");
            Console.WriteLine();
            Console.WriteLine("Master Volume > " + volume);
            Console.WriteLine("[1 - 5]");
            Console.WriteLine();
            Console.WriteLine("Graphic > " + graphic);
            Console.WriteLine("[H] High");
            Console.WriteLine("[M] Medium");
            Console.WriteLine("[L] Low");
            Console.WriteLine();

            char[] chooseOption = { 'B', 'b', 'N', 'n', 'S', 's', '1', '2', '3', '4', '5', 'H', 'h', 'M', 'm', 'L', 'l', 'Q', 'q' };

            for (int i = 0; i < 1; i++)
            {
                chooseOption[i] = Convert.ToChar(Console.ReadLine());

                switch (chooseOption[i])
                {
                    case 'B' or 'b':
                        screen = "Biggest";
                        Console.SetWindowSize(140, 35);
                        Console.SetWindowPosition(0, 0);
                        Console.SetBufferSize(140, 35);
                        Console.Clear();
                        Option();
                        break;

                    case 'N' or 'n':
                        screen = "Normal";
                        Console.SetWindowSize(120, 30);
                        Console.SetWindowPosition(0, 0);
                        Console.SetBufferSize(120, 30);
                        Console.Clear();
                        Option();
                        break;

                    case 'S' or 's':
                        screen = "Smallest";
                        Console.SetWindowSize(100, 25);
                        Console.SetWindowPosition(0, 0);
                        Console.SetBufferSize(100, 25);
                        Console.Clear();
                        Option();
                        break;

                    case 'H' or 'h':
                        graphic = "High";
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Clear();
                        Option();
                        break;

                    case 'M' or 'm':
                        graphic = "Medium";
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Clear();
                        Option();
                        break;

                    case 'L' or 'l':
                        graphic = "Low";
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Clear();
                        Option();
                        break;

                    case '1':
                        volume = "| ~~         | 1";
                        Option();
                        break;

                    case '2':
                        volume = "| ~~~~       | 2";
                        Option();
                        break;

                    case '3':
                        volume = "| ~~~~~~     | 3";
                        Option();
                        break;

                    case '4':
                        volume = "| ~~~~~~~~   | 4";
                        Option();
                        break;

                    case '5':
                        volume = "| ~~~~~~~~~~ | 5";
                        Option();
                        break;

                    case 'Q' or 'q':
                        Console.WriteLine();
                        Console.WriteLine("Loading...");
                        System.Threading.Thread.Sleep(1000);
                        Console.Clear();
                        MainMenu();
                        break;
                }
            }
        }

        static void QuitGame()
        {
            Console.WriteLine("Game is Quit...");
            System.Threading.Thread.Sleep(1000);
        }
    }
}
