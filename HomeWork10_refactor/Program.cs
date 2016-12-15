using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10_refactor
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity;
            Console.WriteLine("Please enter array capacity:");
            while (!Int32.TryParse(Console.ReadLine(), out capacity))
            {
                Console.WriteLine("Please enter int");
            }
            int[] array = new int[capacity];

            
            DynamicArray<int> dynArray = new DynamicArray<int>(array, capacity);

            int input = 7;
            int index;
            int add;
            while (input != 8)
            {
                Console.WriteLine("------What do you want to do with your array:");
                Console.WriteLine("------1 - Add, 2 - Insert, 3 - Get, 4 - Remove, 8 - Exit");


                while (!Int32.TryParse(Console.ReadLine(), out input))
                {
                    Console.WriteLine("Please enter int");
                }

                if (input == 1)
                {
                    Console.WriteLine("Enter: value to add");
                    while (!Int32.TryParse(Console.ReadLine(), out add))
                    {
                        Console.WriteLine("Please enter int");
                    }

                    dynArray.Add(add);
                    dynArray.Print();
                    input = 7;
                }
                else if (input == 2)
                {
                    Console.WriteLine("Enter: Index for insert");
                    while (!Int32.TryParse(Console.ReadLine(), out index))
                    {
                        Console.WriteLine("Please enter int");
                    }
                    Console.WriteLine("Enter: value to insert");
                    while (!Int32.TryParse(Console.ReadLine(), out add))
                    {
                        Console.WriteLine("Please enter int");
                    }

                    dynArray.Insert(add, index);
                    dynArray.Print();
                    input = 7;
                }
                else if (input == 3)
                {
                    Console.WriteLine("Enter: Index for get");
                    while (!Int32.TryParse(Console.ReadLine(), out index))
                    {
                        Console.WriteLine("Please enter int");
                    }


                    Console.WriteLine(dynArray.Get(index));
                    dynArray.Print();
                    input = 7;
                }

                else if (input == 4)
                {
                    Console.WriteLine("Enter: Index for remove");
                    while (!Int32.TryParse(Console.ReadLine(), out index))
                    {
                        Console.WriteLine("Please enter int");
                    }

                    dynArray.Remove(index);
                    dynArray.Print();
                    input = 7;
                }

                else if (input == 8)
                {
                    Console.WriteLine("Thanks for trying Array!!!");

                    
                }
            }
        
    }
    }
}
