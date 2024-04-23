using System;

class menudriven
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("--------------Calculator-------------");
            Console.WriteLine("Press 1 for  Addition");
            Console.WriteLine("Press 2 for Subtraction");
            Console.WriteLine("Press 3 for Multiplication");
            Console.WriteLine("Press 4 for Division");
            Console.WriteLine("Press 9 for Exit the calculator");
            Console.Write("Enter your choice between 1 to 4 and press 9 for exit  :");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            if (choice == 9)
            {
                Console.WriteLine("Exit");
                break;
            }

            Console.Write("Enter the first number: ");
            int a;
            
            if (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                continue;
            }

            Console.Write("Enter the second number: ");
            int b;
            
            if (!int.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                continue;
            }

            int result = 0;
            
            
            switch (choice)
            {
                case 1:
                    result = a + b;
                    Console.WriteLine($"Total: {a} + {b} = {result}");
                    break;
                case 2:
                    result = a - b;
                    Console.WriteLine($"Difference:{a} - {b} = {result}");
                    break;
                case 3:
                    result = a* b;
                    Console.WriteLine($"product: {a} * {b} = {result}");
                    break;
                case 4:
                    if (b == 0)
                    {
                        Console.WriteLine("Cannot divide by zero.");
                        continue;
                    }

                    int quotient = a / b;
                    int remainder = a % b;
                    Console.WriteLine($"quotient :{quotient}, remainder :{remainder}");

                
                  
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                    break;
            }
        }
    }
}
