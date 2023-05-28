using System.Diagnostics;

namespace Logical_Programming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Choose any one program from below option");
            Console.WriteLine("1.FibonacciSeries\n2.PerfectNumber\n3.PrimeNumber\n4.Reverse_a_number\n5.Coupon_Number\n6.Stop_Watch\n7.Vending_Machine\n8.DaysofWeek\n9.Temperature_Conversion\n10.Monthly_Payment");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine(" Please enter how many series you want to generate");
                    int n = Convert.ToInt32(Console.ReadLine());                  
                    Fibonacci_Series.Fibonacciseries(n);

                    break;
               
                case 2:
                    Console.WriteLine(" Please enter the number ");
                    int k = Convert.ToInt32(Console.ReadLine());
                    PerfectNumber.Perfect(k);
                    break;

                case 3:
                    Console.WriteLine("Please enter the number to check if it is a Prime number:");
                    n = Convert.ToInt32(Console.ReadLine());
                    if (PrimeNumber.Prime(n))
                    {
                        Console.WriteLine(n + " is a Prime Number");
                    }
                    else
                    {
                        Console.WriteLine(n + " is not a Prime Number");
                    }
                    Console.WriteLine();
                    break;

                case 4:
                    Console.WriteLine("Please enter the number to Reverse :");
                    n = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Reverse of " + n + " is: " + (Reverse_a_number.ReverseNumber(n)));
                    Console.WriteLine();
                    break;

                case 5:
                    Console.WriteLine("Please enter how many distinct Coupons want to generate?: "); 
                    n = Convert.ToInt32(Console.ReadLine());
                    Coupon_Numbers.coupon_number(n);
                    Console.WriteLine();
                    break;

                case 6:
                    Stop_Watch.stopwatch();
                    Console.WriteLine();
                    break;

                case 7:
                    Console.WriteLine("Enter the amount of change required:");
                    n = Convert.ToInt32(Console.ReadLine());
                    Vending_Machine.Ven_mac(n);
                    Console.WriteLine();
                    break;

                case 8:
                    /*Console.WriteLine("Enter the date: ");
                    int day = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter the month (in Number): ");
                    int month = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter the year: ");
                    int year = Convert.ToInt32(Console.ReadLine());

                    int dayOfWeek = DayOfWeek.DayWeek(day, month, year);
                    string[] days = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
                    string dayName = days[dayOfWeek]; // dayOfWeek is the index into the array

                    Console.WriteLine("The day of the week on the given date (" + day + "/" + month + "/" + year + ") is: " + dayOfWeek + " which is " + dayName + ".");
                    // Implement Day of Week logic here
                    Console.WriteLine();*/
                    break;

                case 9:
                    Console.WriteLine("Please select Conversion From\n1.\tCelsius to Fahrenheit\n\t\tOR\n2.\tFahrenheit to Celsius");
                    n = Convert.ToInt32(Console.ReadLine()); 
                    double temp;
                    switch (n)
                    {
                        case 1:
                            Console.WriteLine("You have selected\t1.\tCelsius to Fahrenheit\nPlease Enter the Temperature in Celisus:");
                            temp = Convert.ToDouble(Console.ReadLine()); 
                            Temperature_Conversion.Cel_to_Far(temp);
                            break;

                        case 2:
                            Console.WriteLine("You have selected\t2.\tFahrenheit to Celsius\nPlease Enter the Temperature in Fahrenheit:");
                            temp = Convert.ToDouble(Console.ReadLine()); 
                            Temperature_Conversion.Far_to_Cel(temp);
                            break;

                        default:
                            Console.WriteLine("Please select a Valid Input. 1 or 2");
                            break;
                    }
                   
                    Console.WriteLine();
                    break;

                case 10:
                    Console.WriteLine("Enter the (V) years to pay off: ");
                    int U = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter the (U) principal loan amount: ");
                    int V = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter the (W) percent interest: ");
                    int W = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("The Monthly Payment AS PER THE GIVEN FORMULA is:" + Monthly_Payment.MonthlyPayment(U, V, W));
                   
                    Console.WriteLine();
                    break;





            }
        }
    }
}