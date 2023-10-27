using System;
using System.Globalization;
using System.Net.NetworkInformation;

namespace main
{
    class main
    {
        static void Main(string[] args)
        {
            int selector = 0;
            while (selector != -1)
            {
                try
                {
                    Sup.emptyLine();
                    Sup.emptyLine();
                    Console.WriteLine("Select program to start:");
                    Console.WriteLine("1. Fahrenheit/Celcius");
                    Console.WriteLine("2. Delta");
                    Console.WriteLine("3. BMI");
                    Console.WriteLine("4. ++x*2");
                    Console.WriteLine("5. x *= y * 2");
                    Console.WriteLine("6. x = (y -= 2)");
                    Console.WriteLine("7. Console.WriteLine(\"++y\")");
                    Console.WriteLine("8. Logic Gates");
                    Console.WriteLine("9. Multisample task");
                    Console.WriteLine("10. Population density");
                    Console.WriteLine("Write any other symbol to close the program.");
                    Sup.emptyLine();
                    selector = Convert.ToInt32(Console.ReadLine());
                    Sup.emptyLine();
                    Sup.emptyLine();

                    switch (selector)
                    {
                        case 1:
                            {
                                Tasks.task1();
                                break;
                            }
                        case 2:
                            {
                                Tasks.task2();
                                break;
                            }
                        case 3:
                            {
                                Tasks.task3();
                                break;
                            }
                        case 4:
                            {
                                Tasks.task4();
                                break;
                            }
                        case 5:
                            {
                                Tasks.task5();
                                break;
                            }
                        case 6:
                            {
                                Tasks.task6();
                                break;
                            }
                        case 7:
                            {
                                Tasks.task7();
                                break;
                            }
                        case 8:
                            {
                                Tasks.task8();
                                break;
                            }
                        case 9:
                            {
                                Tasks.task9();
                                break;

                            }
                        case 10:
                            {
                                Tasks.task10();
                                break;
                            }
                        default:
                            {
                                selector = -1;
                                break;
                            }
                    }
                }
                catch (Exception ex)
                {
                    selector = -1;
                }

            }

        }
    }
    class Tasks
    {
        public static void task1()
        {
           
        }
        public static void task2()
        {
            
        }
        public static void task3()
        {
            
        }
        public static void task4()
        {
            
        }
        public static void task5()
        {
            
        }
        public static void task6()
        {
            
        }
        public static void task7()
        {
            
        }
        public static void task8()
        {
            
        }
        public static void task9()
        {
            
        }
        public static void task10()
        {
            
        }
    }
    class Sup
    {
        public static void emptyLine()
        {
            Console.WriteLine(" ");
        }
        public static void answerInCodeComment()
        {
            Console.WriteLine("Answer to the question is inside the code.");
        }
    }
}
