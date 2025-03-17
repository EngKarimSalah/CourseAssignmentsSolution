namespace ExercisesPart1Solve
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////postfix and prefix
            //int x , k;
            //x = k = 6;          

            //int y = x++; //postfix
            //int z = ++k; //prefix

            //Console.WriteLine(y + "  " + z); //y=6 , z=7

            ////Even or Odd
            //Console.Write("Enter a number: ");
            //int num = int.Parse(Console.ReadLine());

            //if (num % 2 == 0)
            //    Console.WriteLine("The number is Even.");
            //else
            //    Console.WriteLine("The number is Odd.");


            //Console.WriteLine("-------------------------------------------------");
            ////-------------------------------------------------------


            //////Largest of Three Numbers
            //Console.Write("Enter first number: ");
            //int num1 = int.Parse(Console.ReadLine());

            //Console.Write("Enter second number: ");
            //int num2 = int.Parse(Console.ReadLine());

            //Console.Write("Enter third number: ");
            //int num3 = int.Parse(Console.ReadLine());

            //int largest = num1;

            //if(largest > num2)
            //{
            //    if (largest > num3)
            //        Console.WriteLine("The largest number is:"+largest);
            //}
            //else 
            //{
            //    largest = num2;

            //    if (largest > num3)
            //        Console.WriteLine("The largest number is:" + largest);
            //    else
            //        Console.WriteLine("The largest number is:" + num3);

            //}

            //Console.WriteLine("-------------------------------------------------");

            //////-----------------------------------------------------------

            //////Temperature Converter
            //Console.Write("Enter temperature in Celsius: ");
            //double celsius = double.Parse(Console.ReadLine());

            //double fahrenheit = (celsius * 9 / 5) + 32;

            //Console.WriteLine("Temperature in Fahrenheit: " + fahrenheit);
            //Console.WriteLine("-------------------------------------------------");

            //////----------------------------------------------------------

            //////Simple Discount Calculator
            //Console.Write("Enter the price of the item: ");
            //double price = double.Parse(Console.ReadLine());
            //double discount = 0;

            //double finalPrice;

            //if(price >100)
            //{
            //    discount = (price / 100) * 10;
            //    finalPrice = price - discount;
            //    Console.WriteLine("Final price is:" + finalPrice);

            //}
            //else 
            //{
            //    Console.WriteLine("Final price is:" + price);

            //}

            //Console.WriteLine("-------------------------------------------------");

            //////-------------------------------------------------------------

            //////Grading System
            //Console.Write("Enter student score: ");
            //int score = int.Parse(Console.ReadLine());
            //char grade;

            //if (score >= 90)
            // grade = 'A';            
            //else if (score >= 80)
            //    grade = 'B';
            //else if (score >= 70)
            //    grade = 'C';
            //else if (score >= 60)
            //    grade = 'D';
            //else
            //    grade = 'F';






            //Console.WriteLine("The student's grade is: " + grade);
            //Console.WriteLine("-------------------------------------------------");

            //////-------------------------------------------------------

            //////Swap Two Numbers
            //Console.Write("Enter first number: ");
            //int a = int.Parse(Console.ReadLine());

            //Console.Write("Enter second number: ");
            //int b = int.Parse(Console.ReadLine());

            //int c;

            //c = a;
            //a = b;
            //b = c;

            //Console.WriteLine("After swapping: First Number = " + a + ", Second Number = " + b);
            //Console.WriteLine("-------------------------------------------------");


            //////------------------------------------------------------------

            //////Days to Weeks and Days Converter
            //Console.Write("Enter number of days: ");
            //int days = int.Parse(Console.ReadLine());

            //int weeks = days / 7;
            //int remainingDays = days % 7;

            //Console.WriteLine( days + " days = " + weeks + " week(s) and " + remainingDays + " day(s)");
            //Console.WriteLine("-------------------------------------------------");

            //////-----------------------------------------------------------

            //////Simple Calculator
            //Console.Write("Enter first number: ");
            //double FirstNumber = double.Parse(Console.ReadLine());

            //Console.Write("Enter operator (+, -, *, /): ");
            //char op = Console.ReadKey().KeyChar;
            //Console.WriteLine();

            //Console.Write("Enter second number: ");
            //double SecondNumber = double.Parse(Console.ReadLine());

            //double result = 0;

            //if (op == '+')
            //    result = FirstNumber + SecondNumber;
            //else if (op == '-')
            //    result = FirstNumber - SecondNumber;
            //else if (op == '*')
            //    result = FirstNumber * SecondNumber;
            //else if (op == '/')
            //{
            //    if (SecondNumber != 0)
            //        result = FirstNumber / SecondNumber;
            //    else
            //    {
            //        Console.WriteLine("Cannot divide by zero!");
            //        return;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid operator!");
            //    return;
            //}

            //Console.WriteLine("Result: " + result );
            //Console.WriteLine("-------------------------------------------------");

            ////-----------------------------------------------

            //Console.WriteLine("Enter your grade :");
            //char Grade = Console.ReadKey().KeyChar;


            //if (Grade == 'A')
            //    Console.WriteLine("Excellent");
            //else if(Grade == 'B')
            //    Console.WriteLine("Good");
            //else if(Grade == 'C')
            //    Console.WriteLine("avg");
            //else
            //    Console.WriteLine("fail");


            //switch(grade)
            //{

            //    case 'A':
            //        Console.WriteLine("Excellent");
            //        break;

            //    case 'B':
            //        Console.WriteLine("good");
            //        break;

            //    case 'C':
            //        Console.WriteLine("avg");
            //        break;

            //    default:
            //        Console.WriteLine("fail");
            //        break;

            //}

            //--------------------------------------------------


            //Console.WriteLine("enter a number ");
            //int n = int.Parse(Console.ReadLine());

            //int counter;

            //for (counter = 0 ; counter <= n ; counter++ )
            //{
            //    Console.WriteLine("Karim");

            //}


            //int num = 20;

            //while(num != 20)
            //{
            //    Console.WriteLine("guess a number again");
            //    num = int.Parse(Console.ReadLine());
            //}

            //int num=0;

            //do
            //{
            //    Console.WriteLine("guess a number ");
            //    num = int.Parse(Console.ReadLine());
            //}
            //while (num != 20);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////






















            while (true)
            {
                Console.Clear();
                Console.WriteLine("\nSelect a Program:");
                Console.WriteLine("1. Simple Calculator");
                Console.WriteLine("2. Basic ATM System");
                Console.WriteLine("3. Geometry Calculator");
                Console.WriteLine("4. Factorial of a Number");
                Console.WriteLine("5. Sum of Even and Odd Numbers");
                Console.WriteLine("6. Scientific Calculator");
                Console.WriteLine("7. Print Triangle Pattern");
                Console.WriteLine("8. Print Pyramid Pattern");
                Console.WriteLine("9. Print Diamond Pattern");
                Console.WriteLine("10. Guess the Number Game");
                Console.WriteLine("0. Exit");

                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: SimpleCalculator(); break;
                    case 2: BasicATM(); break;
                    case 3: GeometryCalculator(); break;
                    case 4: Factorial(); break;
                    case 5: SumEvenOdd(); break;
                    case 6: ScientificCalculator(); break;
                    case 7: PrintTriangle(); break;
                    case 8: PrintPyramid(); break;
                    case 9: PrintDiamond(); break;
                    case 10: GuessGame(); break;
                    case 0: return;
                    default: Console.WriteLine("Invalid Choice! Try again."); break;
                }
                Console.ReadLine();
            }
        }

        // 1. Simple Calculator
        static void SimpleCalculator()
        {
            Console.Write("Enter first number: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Enter operator (+, -, *, /): ");
            char op = Console.ReadKey().KeyChar;
            Console.Write("\nEnter second number: ");
            double num2 = double.Parse(Console.ReadLine());

            switch (op)
            {
                case '+': Console.WriteLine($"Result: {num1 + num2}"); break;
                case '-': Console.WriteLine($"Result: {num1 - num2}"); break;
                case '*': Console.WriteLine($"Result: {num1 * num2}"); break;
                case '/': Console.WriteLine(num2 != 0 ? $"Result: {num1 / num2}" : "Error: Division by zero!"); break;
                default: Console.WriteLine("Invalid operator!"); break;
            }
        }

        // 2. Basic ATM System
        static void BasicATM()
        {
            double balance = 1000;
            while (true)
            {
                Console.WriteLine("\nATM Menu:");
                Console.WriteLine("1. Withdraw");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Check Balance");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter withdrawal amount: ");
                        double withdraw = double.Parse(Console.ReadLine());
                        if (withdraw > balance) Console.WriteLine("Insufficient funds!");
                        else { balance -= withdraw; Console.WriteLine($"Withdrawal successful! New balance: {balance}"); }
                        break;
                    case 2:
                        Console.Write("Enter deposit amount: ");
                        double deposit = double.Parse(Console.ReadLine());
                        balance += deposit;
                        Console.WriteLine($"Deposit successful! New balance: {balance}");
                        break;
                    case 3:
                        Console.WriteLine($"Current Balance: {balance}");
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
        }

        // 3. Geometry Calculator
        static void GeometryCalculator()
        {
            Console.WriteLine("\nChoose a shape:");
            Console.WriteLine("1. Circle");
            Console.WriteLine("2. Square");
            Console.WriteLine("3. Triangle");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter radius: ");
                    double r = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Area: {Math.PI * r * r}, Circumference: {2 * Math.PI * r}");
                    break;
                case 2:
                    Console.Write("Enter side length: ");
                    double s = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Area: {s * s}, Perimeter: {4 * s}");
                    break;
                case 3:
                    Console.Write("Enter base: ");
                    double b = double.Parse(Console.ReadLine());
                    Console.Write("Enter height: ");
                    double h = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Area: {0.5 * b * h}");
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }

        // 4. Factorial
        static void Factorial()
        {
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            long fact = 1;
            for (int i = 1; i <= n; i++) fact *= i;
            Console.WriteLine($"Factorial: {fact}");
        }

        // 5. Sum of Even and Odd Numbers
        static void SumEvenOdd()
        {
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());
            int sumEven = 0, sumOdd = 0;
            for (int i = 1; i <= n; i++)
                if (i % 2 == 0) sumEven += i; else sumOdd += i;
            Console.WriteLine($"Sum of Even: {sumEven}, Sum of Odd: {sumOdd}");
        }

        // 6. Scientific Calculator
        static void ScientificCalculator()
        {
            Console.Write("Choose operation (sin, cos, tan, sqrt, log, pow): ");
            string op = Console.ReadLine();
            Console.Write("Enter number: ");
            double num = double.Parse(Console.ReadLine());

            switch (op)
            {
                case "sin": Console.WriteLine($"Result: {Math.Sin(num)}"); break;
                case "cos": Console.WriteLine($"Result: {Math.Cos(num)}"); break;
                case "tan": Console.WriteLine($"Result: {Math.Tan(num)}"); break;
                case "sqrt": Console.WriteLine($"Result: {Math.Sqrt(num)}"); break;
                case "log": Console.WriteLine($"Result: {Math.Log(num)}"); break;
                case "pow":
                    Console.Write("Enter exponent: ");
                    double exp = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Result: {Math.Pow(num, exp)}");
                    break;
                default: Console.WriteLine("Invalid operation!"); break;
            }
        }

        // 7. Print Triangle Pattern
        static void PrintTriangle()
        {
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
                Console.WriteLine(new string('*', i));
        }

        // 8. Print Pyramid Pattern
        static void PrintPyramid()
        {
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
                Console.WriteLine(new string(' ', n - i) + new string('*', 2 * i - 1));
        }

        // 9. Print Diamond Pattern
        static void PrintDiamond()
        {
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            // Upper part of the diamond
            for (int i = 1; i <= n; i++)
            {
                PrintRow(i, n);
            }

            // Lower part of the diamond
            for (int i = n - 1; i >= 1; i--)
            {
                PrintRow(i,n);
            }



        }

        // 10. Guess Game
        static void GuessGame()
        {
            Random rand = new Random();
            int target = rand.Next(1, 101);
            
            int guess;

            do
            {
                Console.Write("Guess the number (1-100): ");
                guess = int.Parse(Console.ReadLine());

            
                if (guess > target)
                    Console.WriteLine("Try Lower!");
                else if (guess < target)
                    Console.WriteLine("Try Higher!");
                else
                    Console.WriteLine("You Win!");


            } while (guess != target);
        }


        static void PrintRow(int i, int n)
        {

            for (int j = 0; j < n - i; j++)
                Console.Write(" ");

            for (int j = 0; j < 2 * i - 1; j++)
                Console.Write("*");

            Console.WriteLine();
        }


        static void name()
        {
            Console.WriteLine("karim");
        
        }



        static void taskName()
        {



        }

    }
    
}
