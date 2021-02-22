using System;

namespace ArraySelfPractice2D
{
    class Program
    {
        static void Main(string[] args)
        {

            // Practice creating two-dimensional arrays containing different element types and those of different length. 
            int[,] coordinates = new int[2,3];
            string[,] names = new string[2, 3];

            // Try adding elements to those arrays
            coordinates[0, 0] = 10;
            coordinates[0, 1] = 20;
            coordinates[0, 2] = 30;
            coordinates[1, 0] = 100;
            coordinates[1, 1] = 200;
            coordinates[1, 2] = 300;

            names[0, 0] = "Daniel";
            names[0, 1] = "Min";
            names[0, 2] = "Tibbotts";
            names[1, 0] = "Ludwig";
            names[1, 1] = "Van";
            names[1, 2] = "Beethoven";


            // Practice displaying only specific array elements by referring to its indexes 
            Console.WriteLine(coordinates[1,0]);
            Console.WriteLine(names[1, 2]);

            AddBlankLine();

            // Display all elements
            Display2dArray(coordinates);
            AddBlankLine();
            Display2dArray(names);

            Console.ReadLine();
        }


        /// <summary>
        /// Prints the values of a 2 dimensional array to the console
        /// </summary>
        /// <param name="array"></param>
        public static void Display2dArray(dynamic array)
        {
            // Display all elements of the array using nested for loops
            for (int row = 0; row < array.GetLength(0); row++)
            {
                for (int col = 0; col < array.GetLength(1); col++)
                {
                    Console.WriteLine($"The value of row { row } and col { col } is { array[row, col] }");
                }
            }
        }

        public static void AddBlankLine()
        {
            Console.WriteLine();
        }
    }   
}
