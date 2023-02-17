using System;
namespace Uppgift_2._
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vilken omvandling vill du göra?");
            Console.WriteLine("1. omvandla från celcius till farenheit");
            Console.WriteLine("2. omvandla från farenheit till celcius");
            string menyval = Console.ReadLine();
            
            switch (menyval)
            {
                case "1":
                    Celcius();
                    break;
                case "2":
                    Farenheit();
                        break;



            }
            static void Celcius()
            {
                int tal1 = 32;
                double tal2 = 1.8;
                Console.WriteLine(" skriv in tal för omvandling från farenheit till celcius");
                int tal = int.Parse(Console.ReadLine());
                Console.WriteLine($"Svaret är{tal1 + (tal * tal2)}grader celcius");
            }
            static void Farenheit()
            {
                int tal3 = 32;
                double tal4 = 1.8;
                Console.WriteLine(" skriv in tal för omvandling från celcius till farenheit");
                int tal = int.Parse(Console.ReadLine());
                Console.WriteLine($"svaret är{(tal - tal3) / tal4} grader Farenheit");

            }
        }
    }
}