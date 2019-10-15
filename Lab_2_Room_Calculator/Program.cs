using System;

namespace Lab_2_Room_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // setting up variables
            int length;
            int width;
            int area;
            int perimeter;
            string userCheck;
            bool check = true;

            // prompting for user input
            Console.WriteLine("Welcome to the Grand Circus Room Detail Generator!\n");

            while (check == true)
            {
                Console.Write("Enter Length: ");
                length = int.Parse(Console.ReadLine());
                Console.Write("Enter Width: ");
                width = int.Parse(Console.ReadLine());

                // calculating area and perimeter and display it
                area = length * width;
                perimeter = length * 2 + width * 2;

                // display output
                Console.WriteLine("Area: " + area);
                Console.WriteLine("Perimeter: " + perimeter + "\n");

                Console.WriteLine("Continue? (y/n)");
                userCheck = Console.ReadLine().ToLower();
                if (userCheck != "y")
                {
                    check = false;
                }
            }
        }
    }
}
