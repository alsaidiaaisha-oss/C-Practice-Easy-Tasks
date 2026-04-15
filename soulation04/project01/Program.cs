namespace project01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task1//
             Console.WriteLine("Enter a number from 1 to 7.");
             int day = Convert.ToInt32(Console.ReadLine());
             switch (day)
             {
                 case 1:
             Console.WriteLine("Monday");
                     break;
                 case 2:
                     Console.WriteLine("Tuesday");
                     break;
                 case 3:
                     Console.WriteLine("Wednesday");
                     break;
                 case 4:
                     Console.WriteLine("Thursday");
                     break;

                 case 5:
                     Console.WriteLine("Friday");
                     break;

                 case 6:
                     Console.WriteLine("Saturday");
                     break;

                 default:
                     Console.WriteLine("Invalid day number");
                     break;
            //task2
            Console.WriteLine("Enter Number");
             int number = Convert.ToInt32(Console.ReadLine());


             for (int i = 1; i <= 10; i++)
             {
                 Console.WriteLine($"{number} x {i} = {number * i}");
             }


            //task3//
            Console.WriteLine("Enter a positive number:");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number <= 0)
            {
                Console.WriteLine("Please enter a positive number");
            }
            else
            {
                while (number >= 1)
                {
                    Console.WriteLine(number);
                    number--;
                }

                Console.WriteLine("Go!");

                Console.ReadLine();
            }


        }
        }
    }

