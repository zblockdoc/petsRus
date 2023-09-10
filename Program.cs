using System;
using System.Text.Json; // Required for JSON serialization

namespace ProductManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press 1 to add a product");
            Console.WriteLine("Type 'exit' to quit");

            string userInput = Console.ReadLine();

            while (userInput.ToLower() != "exit")
            {
                if (userInput == "1")
                {
                    Console.WriteLine("Choose a product type: ");
                    Console.WriteLine("1 - CatFood");
                    Console.WriteLine("2 - DogLeash");

                    string productChoice = Console.ReadLine();

                    if (productChoice == "1")
                    {
                        Console.Write("Enter CatFood Name: ");
                        string name = Console.ReadLine();

                        Console.Write("Enter CatFood Price: ");
                        decimal price = decimal.Parse(Console.ReadLine());

                        Console.Write("Enter CatFood Quantity: ");
                        int quantity = int.Parse(Console.ReadLine());

                        Console.Write("Enter CatFood Description: ");
                        string description = Console.ReadLine();

                        Console.Write("Enter CatFood Weight (in pounds): ");
                        double weight = double.Parse(Console.ReadLine());

                        Console.Write("Is it Kitten Food? (true or false): ");
                        bool isKittenFood = bool.Parse(Console.ReadLine());

                        // Create a CatFood object
                        CatFood catFood = new CatFood
                        {
                            Name = name,
                            Price = price,
                            Quantity = quantity,
                            Description = description,
                            WeightPounds = weight,
                            KittenFood = isKittenFood
                        };

                        // Serialize and print the CatFood object
                        string catFoodJson = JsonSerializer.Serialize(catFood);
                        Console.WriteLine("CatFood Object:");
                        Console.WriteLine(catFoodJson);
                    }
                    else if (productChoice == "2")
                    {
                        Console.Write("Enter DogLeash Name: ");
                        string name = Console.ReadLine();

                        Console.Write("Enter DogLeash Price: ");
                        decimal price = decimal.Parse(Console.ReadLine());

                        Console.Write("Enter DogLeash Quantity: ");
                        int quantity = int.Parse(Console.ReadLine());

                        Console.Write("Enter DogLeash Description: ");
                        string description = Console.ReadLine();

                        Console.Write("Enter DogLeash Length (in inches): ");
                        int length = int.Parse(Console.ReadLine());

                        Console.Write("Enter DogLeash Material: ");
                        string material = Console.ReadLine();

                        // Create a DogLeash object
                        DogLeash dogLeash = new DogLeash
                        {
                            Name = name,
                            Price = price,
                            Quantity = quantity,
                            Description = description,
                            LengthInches = length,
                            Material = material
                        };

                        // Serialize and print the DogLeash object
                        string dogLeashJson = JsonSerializer.Serialize(dogLeash);
                        Console.WriteLine("DogLeash Object:");
                        Console.WriteLine(dogLeashJson);
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice.");
                    }
                }

                Console.WriteLine("Press 1 to add a product");
                Console.WriteLine("Type 'exit' to quit");
                userInput = Console.ReadLine();
            }
        }
    }

    // Define the base class Product
    class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
    }

    // Define the CatFood class inheriting from Product
    class CatFood : Product
    {
        public double WeightPounds { get; set; }
        public bool KittenFood { get; set; }
    }

    // Define the DogLeash class inheriting from Product
    class DogLeash : Product
    {
        public int LengthInches { get; set; }
        public string Material { get; set; }
    }
}
