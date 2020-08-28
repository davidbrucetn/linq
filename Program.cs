using System;
using System.Collections.Generic;
using System.Linq;

namespace linq
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ex 1
            // Find the words in the collection that start with the letter 'L'
            List<string> fruits = new List<string>()
            {
                "Lemon",
                "Apple",
                "Orange",
                "Lime",
                "Watermelon",
                "Loganberry"
            };

            IEnumerable<string> LFruits = fruits.Where(fruit => fruit.StartsWith("L"));
            foreach (string fruit in LFruits)
            {
                Console.WriteLine($"Fruits starting with L:{fruit}");
            }
            // Ex 2
            // Which of the following numbers are multiples of 4 or 6
            Console.WriteLine("---------------- Multiples of Four or Six ------------------");
            List<int> numbers = new List<int>()
            {
                15,
                8,
                21,
                24,
                32,
                13,
                30,
                12,
                7,
                54,
                48,
                4,
                49,
                96
            };

            IEnumerable<int> fourSixMultiples = numbers.Where(number => (number % 4 == 0) || (number % 6 == 0));
            foreach (int number in fourSixMultiples)
            {
                Console.WriteLine($"Multiple of Four or Six:{number}");
            }
            // Ex 3 Ordering Operations
            // 
            // Order these student names alphabetically, in descending order (Z to A)
            Console.WriteLine("................... Desc Order ...............................");
            List<string> names = new List<string>()
            {
                "Heather",
                "James",
                "Xavier",
                "Michelle",
                "Brian",
                "Nina",
                "Kathleen",
                "Sophia",
                "Amir",
                "Douglas",
                "Zarley",
                "Beatrice",
                "Theodora",
                "William",
                "Svetlana",
                "Charisse",
                "Yolanda",
                "Gregorio",
                "Jean-Paul",
                "Evangelina",
                "Viktor",
                "Jacqueline",
                "Francisco",
                "Tre"
            };

            IEnumerable<string> descend = names.OrderByDescending(name => name);
            foreach (string name in descend)
            {
                Console.WriteLine($"Descending Order: {name}");
            }
            // Ex 4
            // Build a collection of these numbers sorted in ascending order
            Console.WriteLine(".................... Asc Order..................................");
            List<int> diffNumbers = new List<int>()
            {
                15,
                8,
                21,
                24,
                32,
                13,
                30,
                12,
                7,
                54,
                48,
                4,
                49,
                96
            };
            IEnumerable<int> ascNumbers = diffNumbers.OrderBy(number => number);
            foreach (int number in ascNumbers)
            {
                Console.WriteLine($"Asc Order: {number}");
            }

            // Ex 5
            // Aggregate Operations
            // Output how many numbers are in this list
            Console.WriteLine(".................... Aggregate Count ..................................");
            List<int> preAggnumbers = new List<int>()
            {
                15,
                8,
                21,
                24,
                32,
                13,
                30,
                12,
                7,
                54,
                48,
                4,
                49,
                96
            };
            int preAggCount = preAggnumbers.Count();
            Console.WriteLine($"There are {preAggCount} numbers in this list.");
            // Ex 6
            // Aggregate Sum
            // How much money have we made?
            Console.WriteLine(".................... Aggregate Sum ..................................");

            List<double> purchases = new List<double>()
            {
                2340.29,
                745.31,
                21.76,
                34.03,
                4786.45,
                879.45,
                9442.85,
                2454.63,
                45.65
            };
            double purchTotal = purchases.Sum();
            Console.WriteLine($"Purchases Sum {purchTotal}");
            // Ex 7
            // Aggregate Most Expensive
            // What is our most expensive product?
            Console.WriteLine(".................... Aggregate Most Expensive  ..................................");
            List<double> prices = new List<double>()
            {
                879.45,
                9442.85,
                2454.63,
                45.65,
                2340.29,
                34.03,
                4786.45,
                745.31,
                21.76
            };
            double mostExpensive = prices.Max(price => price);
            Console.WriteLine($"Highest Price {mostExpensive}");
            // Ex 8
            // Partition Questions
            Console.WriteLine(".................... Partitioning (Perfect Sq)  ..................................");
            List<int> wheresSquaredo = new List<int>()
            {
                66,
                12,
                8,
                27,
                82,
                34,
                7,
                50,
                19,
                46,
                81,
                23,
                30,
                4,
                68,
                14
            };
            /*
                Store each number in the following List until a perfect square
                is detected.

                Expected output is { 66, 12, 8, 27, 82, 34, 7, 50, 19, 46 } 

                Ref: https://msdn.microsoft.com/en-us/library/system.math.sqrt(v=vs.110).aspx
            */

        }
    }
}