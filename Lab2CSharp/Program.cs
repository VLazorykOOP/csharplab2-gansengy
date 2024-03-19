namespace Lab2CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void task1(){
                Console.Write("Enter the size of the array: ");
                int size = Convert.ToInt32(Console.ReadLine());

                int[] array = new int[size];

                for (int i = 0; i < size; i++)
                {
                    Console.Write($"Enter the number for element {i}: ");
                    array[i] = Convert.ToInt32(Console.ReadLine());
                }

                int sum = 0;
                foreach (int number in array)
                {
                    sum += number;
                }

                // Check if the sum is two-digit
                if (sum >= 10 && sum <= 99)
                {
                    Console.WriteLine("The sum of array elements is a two-digit number.");
                }
                else
                {
                    Console.WriteLine("The sum of array elements is not a two-digit number.");
                }
            }
            static void task2(){
                Console.Write("Array size: ");
                int n = Convert.ToInt32(Console.ReadLine());

                double[] array = new double[n];

                for (int i = 0; i < n; i++)
                {
                    Console.Write($"{i+1}: ");
                    array[i] = Convert.ToDouble(Console.ReadLine());
                }

                int count = 0;
                for (int i = 0; i < n - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        count++;
                    }
                }

                Console.WriteLine($"Count of elements that are higher than next elements are: {count}");
            }
            static void task3(){
                Console.Write("Enter the size of the square matrix: ");
                int n = int.Parse(Console.ReadLine());

                int[,] matrix = new int[n, n];

                Console.WriteLine("Enter the elements of the matrix:");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write($"Element [{i},{j}]: ");
                        matrix[i, j] = int.Parse(Console.ReadLine());
                    }
                }

                double sum = 0;
                int count = 0;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n-i; j++)
                    {
                        if (matrix[i, j] != 0)
                        {
                            sum += matrix[i, j];
                            count++;
                        }
                    }
                }

                double average = count > 0 ? sum / count : 0;
                Console.WriteLine($"The average of non-zero elements above the secondary diagonal is: {average}");
            }
            static void task4(){
                // Input the size of the jagged array
                Console.Write("Enter the number of rows in the jagged array: ");
                int n = int.Parse(Console.ReadLine());

                // Initialize the jagged array
                int[][] jaggedArray = new int[n][];

                // Input elements for each row of the jagged array
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"Enter the number of elements in row {i + 1}: ");
                    int m = int.Parse(Console.ReadLine());
                    jaggedArray[i] = new int[m];

                    Console.WriteLine($"Enter {m} elements for row {i + 1}:");
                    for (int j = 0; j < m; j++)
                    {
                        jaggedArray[i][j] = int.Parse(Console.ReadLine());
                    }
                }

                // Calculate the sum of negative elements for each column
                int[] columnSums = new int[jaggedArray[0].Length];
                for (int i = 0; i < jaggedArray.Length; i++)
                {
                    for (int j = 0; j < jaggedArray[i].Length; j++)
                    {
                        if (jaggedArray[i][j] < 0)
                        {
                            columnSums[j] += jaggedArray[i][j];
                        }
                    }
                }

                // Output the results
                Console.WriteLine("Sum of negative elements for each column:");
                for (int j = 0; j < columnSums.Length; j++)
                {
                    Console.WriteLine($"Column {j + 1}: {columnSums[j]}");
                }
            }
            while(true){
                Console.WriteLine("  ****  Lab 2  ****  \n\n");
                Console.Write("Press 0 to exit\n");
                Console.Write("Which task would you like to review ? (1-4) : ");
                string? str = Console.ReadLine();
                if ( str == "0") break;
                if (str != null && short.TryParse(str, out short ans))
                {
                    switch (ans)
                {
                    case 1: { task1(); break; }
                    case 2: { task2(); break; }
                    case 3: { task3(); break; }
                    case 4: { task4(); break; }
                    default: { Console.WriteLine("Put the correct number"); break; }
                }
                }
                

            }
        }
    }
}
