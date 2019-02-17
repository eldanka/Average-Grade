using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageGrade
{
    class Program
    {
        static void Main(string[] args)
        {
            AppTitle();

            TextColor(ConsoleColor.Blue, "Enter a name of school subject:");

            string subject = Console.ReadLine();

            TextColor(ConsoleColor.Blue, "Let's calculate average grade of "+ subject);

            string input = "0";
            int count = 0;
            int total = 0;
            int currentGrade = 0;

            while(input != "cal")
            {
                TextColor(ConsoleColor.Blue, "Current amount of grades : " + count);
                TextColor(ConsoleColor.Blue, "Last entered grade : " + currentGrade);
                TextColor(ConsoleColor.Blue, "//Enter 'cal' for calculating the average grade//");
                TextColor(ConsoleColor.Blue, "********* Please enter the next grade: *********");
                

                input = Console.ReadLine();
                if(input.Equals("cal"))
                {
                    Console.WriteLine("-------------------------------");
                    double avarageGrade = (double)total / (double)count;
                    double grade = Math.Round(avarageGrade, 0, MidpointRounding.AwayFromZero);
                    switch (grade)
                    {
                            case 5:
                                TextColor(ConsoleColor.Blue, "Your average grade is excellent.");
                                break;
                            case 4:
                                TextColor(ConsoleColor.Blue, "Your average grade is very good.");
                                break;
                            case 3:
                                TextColor(ConsoleColor.Blue, "Your average grade is good");
                                break;
                            case 2:
                                TextColor(ConsoleColor.Blue, "Your average grade is enough.");
                                break;
                            case 1:
                                TextColor(ConsoleColor.Blue, "Your average grade is insufficiently.");
                                break;


                    }
                }
                if (int.TryParse(input, out currentGrade) && currentGrade > 0 && currentGrade < 6)
                {
                    total += currentGrade;
                }
                else
                {
                    if(!(input.Equals("cal")))
                    {
                        TextColor(ConsoleColor.Red, "Please enter a value between 1 and 5");
                    }
                    continue;
                }

                count++;
            }

            Console.Read();

        }

        public static void AppTitle()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("*******************************");
            Console.WriteLine("******** AVERAGE GRADE ********");
            Console.WriteLine("*******************************");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Version 1.0.0 by Eldan Kahrovic");
            Console.ResetColor();
            Console.WriteLine("-------------------------------");
        }

        public static void TextColor(ConsoleColor color, string text)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }


        

    }
}
