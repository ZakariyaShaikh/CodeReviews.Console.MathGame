using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool exit = true;
            List<int> record = new List<int>();
            while (exit)
            {
                Console.WriteLine("---------------------------\n");
                Console.WriteLine("\nWelcome To The Math Game!!!");
                Console.WriteLine($@"Enter Any Operation As follow 
                     For Addition: a or A or +
                     For Subtraction: s or S or -
                     For Multiplication: m or M or *
                     For Division: d or D or / 
                     For Exit : exit
                     For History : H"
                     );


                string MG = (Console.ReadLine());
                Random num = new Random();
                int num1 = num.Next(0, 100);
                int num2 = num.Next(0, 100);
                string result = "";

                Console.WriteLine($"Choosed Option is :{MG}");
                switch (MG.ToLower().Trim())
                {
                    case "a":
                        Console.WriteLine($@"Number 1 is : {num1} and Number 2 is : {num2} and 
                          enter the answer {num1}+{num2} ");
                        result = Console.ReadLine();
                        if (int.Parse(result) == num1 + num2)
                        {
                            Console.WriteLine("You are corect!!!");
                            record.Add(int.Parse(result));
                        }
                        else
                        {
                            Console.WriteLine("Incorrect answer.....");
                            Console.WriteLine($"{num1 + num2}(Correct Answer)");

                            record.Add(num1 + num2);
                        }

                        break;
                    case "s":
                        Console.WriteLine($@"Number 1 is : {num1} and Number 2 is : {num2} and 
                          enter the answer {num1}-{num2} ");
                        result = Console.ReadLine();
                        if (int.Parse(result) == num1 - num2)
                        {
                            Console.WriteLine("You are corect!!!");
                            record.Add(int.Parse(result));
                        }
                        else
                        {
                            Console.WriteLine("Incorrect answer......");
                            Console.WriteLine($"{num1 - num2}(Correct Answer)");

                            record.Add(num1 - num2);
                        }

                        break;
                    case "m":
                        Console.WriteLine($@"Number 1 is : {num1} and Number 2 is : {num2} and 
                          enter the answer {num1}*{num2} ");
                        result = Console.ReadLine();
                        if (int.Parse(result) == num1 * num2)
                        {
                            Console.WriteLine("You are corect!!!");
                            record.Add(int.Parse(result));
                        }
                        else
                        {
                            Console.WriteLine("Incorrect answer......");
                        }

                        break;
                    case "d":
                        Console.WriteLine($@"Number 1 is : {num1} and Number 2 is : {num2} and 
                          enter the answer {num1}/{num2} ");
                        result = Console.ReadLine();
                        if (Double.Parse(result) == (double)num1 / num2)
                        {
                            Console.WriteLine("You are corect!!!");
                            record.Add(int.Parse(result));
                        }
                        else
                        {
                            Console.WriteLine("Incorrect answer......");
                        }

                        break;
                    case "exit":
                        exit = false;
                        break;
                    case "h":
                        if (record.Count == 0)
                        {
                            Console.WriteLine("No Game played Yet!!!!");
                        }
                        else
                        {
                            foreach (int item in record)
                            {
                                Console.WriteLine($"Your History is ({item})(correct) ");
                            }
                        }
                        break;
                    case "random":

                        string[] Roperators = { "add", "sub", "mul", "div" };
                        string selectedop = Roperators[num.Next(Roperators.Length)];
                        switch ((selectedop))
                        {
                            case "add":
                                Console.WriteLine($@"Number 1 is : {num1} and Number 2 is : {num2} and 
                          enter the answer {num1}+{num2} ");
                                result = Console.ReadLine();
                                if (int.Parse(result) == num1 + num2)
                                {
                                    Console.WriteLine("You are corect!!!");
                                    record.Add(int.Parse(result));
                                }
                                else
                                {
                                    Console.WriteLine("Incorrect answer......");
                                }
                                break;
                            case "sub":
                                Console.WriteLine($@"Number 1 is : {num1} and Number 2 is : {num2} and 
                          enter the answer {num1}-{num2} ");
                                result = Console.ReadLine();
                                if (int.Parse(result) == num1 + num2)
                                {
                                    Console.WriteLine("You are corect!!!");
                                    record.Add(int.Parse(result));
                                }
                                else
                                {
                                    Console.WriteLine("Incorrect answer......");
                                }
                                break;
                            case "mul":
                                Console.WriteLine($@"Number 1 is : {num1} and Number 2 is : {num2} and 
                          enter the answer {num1}*{num2} ");
                                result = Console.ReadLine();
                                if (int.Parse(result) == num1 + num2)
                                {
                                    Console.WriteLine("You are corect!!!");
                                    record.Add(int.Parse(result));
                                }
                                else
                                {
                                    Console.WriteLine("Incorrect answer......");
                                }
                                break;
                            case "div":
                                Console.WriteLine($@"Number 1 is : {num1} and Number 2 is : {num2} and 
                          enter the answer {num1}/{num2} ");
                                result = Console.ReadLine();
                                if (double.Parse(result) == (double)num1 / num2)
                                {
                                    Console.WriteLine("You are corect!!!");
                                    record.Add(int.Parse(result));
                                }
                                else
                                {
                                    Console.WriteLine("Incorrect answer......");
                                }

                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid Character or Symbol....");
                        break;



                }
            }
        }





    }
}
