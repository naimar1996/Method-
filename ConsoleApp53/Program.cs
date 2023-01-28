using System.Security.Cryptography;

namespace ConsoleApp53
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int number = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(FindavailableNumber(number));


            //int number = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(Findsumtillnumber(number));

            Console.WriteLine("----");
            double number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----");
            double number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter symbols(>)");
            string comparison = Console.ReadLine();
            switch (comparison)
            {
                case ">":
                    int bigger;
                    Console.WriteLine(number1 > number2);
                    break;

            }


    }
        //static int FindavailableNumber (int number)
        //{
        //    if(number % 7 == 0)
        //    {
        //        return number;
        //    }
        //    while (number % 7 != 0)
        //    {
        //        if (number % 7 > 3)
        //        {
        //            number++;
        //        }
        //        else
        //        {
        //            number--;
        //        }
        //    }
        //    return number; 
        //}


        //static int Findsumtillnumber(int s)
        //{
        //    int sum = 0; 
        //    for ( int n = 0; 0 <= s; n++)
        //    {
        //        sum += n;
        //    }
        //    return sum;
        //}


      
            

    }
