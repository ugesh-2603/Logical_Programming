namespace Logical_Programming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Choose any one program from below option");
            Console.WriteLine("1.FibonacciSeries\n2.PerfectNumber\n3.PrimeNumber\n4.Reverse_a_number\n5.Coupon_Number");
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
                    int couponLength = 10; // Length of the coupon number

                    // Generate a coupon number
                    int length = Convert.ToInt32(Console.ReadLine());
                    Coupon_Numbers.GenerateCoupon(length);

                    Console.WriteLine("Coupon Number: " + couponLength );
                    break; 





            }
        }
    }
}