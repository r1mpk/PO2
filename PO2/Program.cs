using System.Globalization;

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
                    Console.WriteLine("1. Leap Year Checker");
                    Console.WriteLine("2. Is a divider?");
                    Console.WriteLine("3. Max");
                    Console.WriteLine("4. Calculator");
                    Console.WriteLine("5. How many roots of quadratic equation");
                    Console.WriteLine("6. BMI");
                    Console.WriteLine("7. 3.8 to switch case");
                    Console.WriteLine("8. Scholarship");
                    Console.WriteLine("9. Figure drawing");
                    Console.WriteLine("10. Factorial");
                    Console.WriteLine("11. How many integers to get over 100");
                    Console.WriteLine("12. Sum until 0");
                    Console.WriteLine("13. Sum of series");
                    Console.WriteLine("14. Perfect number finder");
                    Console.WriteLine("15. Money check");

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
                        case 11:
                            {
                                Tasks.task11();
                                break;
                            }
                        case 12:
                            {
                                Tasks.task12();
                                break;
                            }
                        case 13:
                            {
                                Tasks.task13();
                                break;
                            }
                        case 14:
                            {
                                Tasks.task14();
                                break;
                            }
                        case 15:
                            {
                                Tasks.task15();
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
            int year = int.MaxValue;
            Console.WriteLine("Pass year:");
            while (year == int.MaxValue)
            {
                try
                {
                    year = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Wrong value! Try again");
                }
            }
            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                Console.WriteLine("{0} is a leap year.", year);
            }
            else
            {
                Console.WriteLine("{0} is not a leap year.", year);
            }
            return;
        }
        public static void task2()
        {
            int a = int.MaxValue, b = int.MaxValue;
            Console.WriteLine("Write 1st integer:");
            while (a == int.MaxValue)
            {
                try
                {
                    a = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Wrong value! Try again");
                }
            }
            Console.WriteLine("Write 2nd integer:");
            while (b == int.MaxValue)
            {
                try
                {
                    b = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Wrong value! Try again");
                }
            }
            if (a % b == 0)
            {
                Console.WriteLine("Number {0} is a divider of {1}", b, a);
            }
            else
            {
                Console.WriteLine("Number {0} is not a divider of {1}", b, a);
            }
            return;
        }
        public static void task3()
        {
            Console.WriteLine("Pass 3 numbers.");
            double[] findMax = { 0, 0, 0 };
            int tryTimes = 0;
            while (tryTimes < 3)
            {
                try
                {
                    findMax[0] = Convert.ToDouble(Console.ReadLine());
                    findMax[1] = Convert.ToDouble(Console.ReadLine());
                    findMax[2] = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Wrong value! Try again.");
                }
                finally
                {
                    tryTimes++;
                }
            }
            Console.WriteLine("Highest number is: {0}", findMax.Max());
        }
        public static void task4()
        {
            double a = 0, b = 0;
            string op = "xd";
            int tryTimes = 0;
            while (tryTimes < 3)
            {
                try
                {
                    Console.WriteLine("Pass first number:");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Pass operator (+, -, *, /).");
                    op = Console.ReadLine();
                    Console.WriteLine("Pass second number:");
                    b = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Wrong type! Try again.");
                }
                finally
                {
                    tryTimes++;
                }
            }
            if (op == "+")
            {
                Console.WriteLine("Result: {0}", a + b);
            }
            else if (op == "-")
            {
                Console.WriteLine("Result: {0}", a - b);
            }
            else if (op == "*")
            {
                Console.WriteLine("Result: {0}", a * b);
            }
            else if (op == "/")
            {
                Console.WriteLine("Result: {0}", a / b);
            }
            else
            {
                Console.WriteLine("This is error. This should not appear. Contact developer with explaination how did you get here.");
            }
            return;
        }
        public static void task5()
        {
            int tryAttempts = 0;
            int[] values = { 0, 0, 0 };
            Console.WriteLine("What are the A, B, and C variables of the quadratic function that you want to calculate the number of roots of?");
            Console.WriteLine("Write them down one by one in order provided above.");
            while (tryAttempts < 3)
            {
                try
                {
                    for (int i = 0; i < 3; i++)
                    {
                        values[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Wrong value! Write this one again.");
                }
                finally
                {
                    tryAttempts++;
                }
            }
            int delta = (values[1] * values[1]) - (4 * values[0] * values[2]);
            int howManyRoots = 0;
            if (delta < 0)
            {
                howManyRoots = 0;
            }
            else if (delta == 0)
            {
                howManyRoots = 1;
            }
            else
            {
                howManyRoots = 2;
            }
            Console.WriteLine("The number of square roots of quadratic function {0}x^2+{1}x+{2} is equal to {3}.", values[0], values[1], values[2], howManyRoots);
            return;
        }
        public static void task6()
        {
            float weight = 0;
            float height = 0;
            int tryAttempts = 0;
            //string[] youAre = { "underweight", "of normal weight", "overweight" };
            string[] youAre = { "underweight (Severe thinness)",
                                "underweight (Moderate thinness)",
                                "underweight (Mild thinness)",
                                "of normal weight",
                                "overweight (Pre-obese)",
                                "obese (Class I)",
                                "obese (Class II)",
                                "obese (Class III"};
            int weightStatus = -1;
            float bmi = 0;
            Console.WriteLine("Please write down your weight in kilograms and height in meters in that order.");
            Sup.emptyLine();
            while (tryAttempts < 3)
            {
                try
                {
                    weight = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture.NumberFormat);
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Wrong value! Write it again.");
                }
                finally
                {
                    tryAttempts++;
                }
            }
            Sup.emptyLine();
            while (height == 0)
            {
                try
                {
                    height = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture.NumberFormat);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Wrong value! Write it again.");
                }
            }
            Sup.emptyLine();
            bmi = weight / (height * height);
            /*if(bmi < 18.5)
            {
                weightStatus = 0;
            } else if (bmi >= 25)
            {
                weightStatus = 2;
            } else
            {
                weightStatus = 1;
            }*/
            if (bmi < 16)
                weightStatus = 0;
            else if (bmi < 17)
                weightStatus = 1;
            else if (bmi < 18.5)
                weightStatus = 2;
            else if (bmi < 25)
                weightStatus = 3;
            else if (bmi < 30)
                weightStatus = 4;
            else if (bmi < 35)
                weightStatus = 5;
            else if (bmi < 40)
                weightStatus = 6;
            else
                weightStatus = 7;
            Console.WriteLine("Your BMI is {0}", bmi);
            Console.WriteLine("You are {0}", youAre[weightStatus]);
            return;
        }
        public static void task7()
        {
            Console.WriteLine("Wpisz nr dnia tygodnia");
            string numer = Console.ReadLine();
            int numI = Convert.ToInt32(numer);
            switch (numI - 1)
            {
                case 0: Console.WriteLine("Poniedzialek"); break;
                case 1: Console.WriteLine("Wtorek"); break;
                case 2: Console.WriteLine("Sroda"); break;
                case 3: Console.WriteLine("Czwartek"); break;
                case 4: Console.WriteLine("Piatek"); break;
                case 5: Console.WriteLine("Sobota"); break;
                case 6: Console.WriteLine("Niedziela"); break;
                default: Console.WriteLine("Nie ma takiego dnia tygodnia."); break;
            }
            return;
        }
        public static void task8()
        {
            float avg = 0;
            int[] scholarship = { 0, 350, 550 };
            int v = 0;
            int tryAttempts = 0;
            Console.WriteLine("Pass your marks average:");
            while (tryAttempts < 3)
            {
                try
                {
                    avg = float.Parse(Console.ReadLine()); break;
                }
                catch (Exception e)
                {
                    Console.WriteLine();
                }
                finally
                {
                    tryAttempts++;
                }
            }
            if (avg >= 4.8)
                v = 2;
            else if (avg < 4)
                v = 0;
            else
                v = 1;
            Console.WriteLine("Your scholarship is {0}", scholarship[v]);
            return;
        }
        public static void task9()
        {
            int length = 0, tryAttempts = 0;
            string figure = "-";
            Console.WriteLine("Choose your figure.\n" +
                                "a. *     b. **** c.    * d. ****\n" +
                                "   **       ***       **    *  *\n" +
                                "   ***      **       ***    *  *\n" +
                                "   ****     *       ****    ****\n");
            figure = Console.ReadLine();
            Console.WriteLine("How long should it be (just an integer of length)?");
            while (tryAttempts < 3)
            {
                try
                {
                    length = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception e) { Console.WriteLine("Wrong value! Try again"); }
                finally { tryAttempts++; }
            }
            if (figure == "a")
            {
                for (int i = 0; i < length; i++)
                {
                    for (int j = 0; j < i + 1; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            else if (figure == "b")
            {
                for (int i = 0; i < length; i++)
                {
                    for (int j = 0; j < (length - i); j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            else if (figure == "c")
            {
                for (int i = 0; i < length; i++)
                {
                    for (int j = 1; j < (length - i); j++)
                    {
                        Console.Write(" ");
                    }

                    for (int j = 0; j < i + 1; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            else if (figure == "d")
            {
                for (int i = 1; i <= length; i++)
                {
                    for (int j = 0; j < length; j++)
                    {
                        if (i == 1 || i == length || j == 0 || j == length - 1)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Wrong figure passed.");
            }
            return;
        }
        public static void task10()
        {
            int factorial = 0;
            int result = 1;
            int tryAttempts = 0;
            Console.WriteLine("Pass number of which factorial you want to calculate.");
            while (tryAttempts < 3)
            {
                try
                {
                    factorial = Convert.ToInt32(Console.ReadLine()); break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Wrong value! Try again");
                }
                finally
                {
                    tryAttempts++;
                }
            }
            for (int i = 1; i <= factorial; i++)
            {
                result *= i;
            }
            Console.WriteLine("Factorial of {0} is {1}.", factorial, result);
            return;
        }
        public static void task11()
        {
            int sum = 0, num = 1, count = 0;
            while (sum < 100)
            {
                sum += num;
                num++;
                count++;
            }
            Console.WriteLine(count);
        }
        public static void task12()
        {
            int number = 0, sum = 0;
            Console.WriteLine("Write 0 when you want to stop addition.");
            while (number != 0)
            {
                try
                {
                    number = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Wrong value!");
                }
                sum += number;

            }
            Console.WriteLine(sum);
            return;
        }
        public static void task13()
        {
            int n = 0, sum = 0, tryTimes = 0;
            Console.WriteLine("Write the last integer of series W(n) = 1 - 2 + 3 - 4 + ... n.");
            while (tryTimes < 3)
            {
                try
                {
                    n = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Wrong value! Try again.");
                }
                finally
                {
                    tryTimes++;
                }
            }
            for (int i = 1; i < n + 1; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
                else
                {
                    sum -= i;
                }
            }
            Console.WriteLine(sum);
            return;
        }
        public static void task14()
        {
            int tryAttempts = 0, n = 0, sum = 0, i = 1, j = 1;
            List<int> perfectNumbers = new List<int>();
            Console.WriteLine("Pass maximum number in the range.");
            while (tryAttempts < 3)
            {
                try
                {
                    n = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Wrong value! Write it again.");
                }
                finally
                {
                    tryAttempts++;
                }
            }
            while (i < n + 1)
            {
                sum = 0;
                while (j < i)
                {
                    if (i % j == 0)
                    {
                        sum += j;
                    }
                    j++;
                }
                if (sum == i)
                {
                    perfectNumbers.Add(i);
                }
                i++;
                j = 1;
            }
            Console.WriteLine("Perfect numbers up to {0} are:", n);
            foreach (int num in perfectNumbers)
            {
                Console.WriteLine(num);
            }
            return;
        }
        public static void task15()
        {
            /*int[] coins = { 1, 2, 5 };
            List<int> temp = new List<int> { };
            foreach (int[] v in Sup.GetCombinations(coins, 10, temp))
            {
                foreach (int x in v)
                {
                    Console.Write("{0}, ", x);
                }
                Console.WriteLine();
            }*/
            for (int z1 = 0; z1 <= 10; z1++)
                for (int z2 = 0; z2 <= 5; z2++)
                    for (int z5 = 0; z5 <= 2; z5++)
                        if (z1 * 1 + z2 * 2 + z5 * 5 == 10)
                        {
                            List<int> result = new List<int> { };
                            if(z1 != 0)
                            {
                                for (int i = 0; i < z1; i++)
                                {
                                    result.Add(1);
                                }
                            }
                            if (z2 != 0)
                            {
                                for (int i = 0; i < z2; i++)
                                {
                                    result.Add(2);
                                }
                            }
                            if(z5!= 0)
                            {
                                for (int i = 0; i < z5; i++)
                                {
                                    result.Add(5);
                                }
                            }                                                      
                            foreach (int x in result)
                            {
                                Console.Write("{0}, ", x);
                            }
                            Sup.emptyLine();
                        }
                            
                            
            return;
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
        /*public static IEnumerable<int[]> GetCombinations(int[] set, int sum, List<int> prev)
        {
            for (int i = 0; i < set.Length; i++)
            {
                int left = sum - set[i];
                List<int> rest = new List<int>();
                rest.Add(set[i]);
                rest.AddRange(prev);
                int[] ret = rest.ToArray();
                if (left == 0)
                {
                   
                    yield return ret;
                }
                else
                {
                    foreach (int[] val in GetCombinations(set, left, rest))
                    {
                        yield return val;
                    }
                }
            }
        }*/
    }
}
