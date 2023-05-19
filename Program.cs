class Program
{
    static void Main(string[] args)
    {
        int number;

        while (true)
        {
            Console.Write("number: ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out number))
            {
                Console.WriteLine("Invalid input. Please enter an integer.");
                continue;
            }

            if (number < 0)
            {
                Console.WriteLine("Invalid Pascal's triangle row number.");
                continue;
            }

            break;
        }

        int[][] pascalsTriangle = GeneratePascalsTriangle(number);

        // Display the Pascal's Triangle
        for (int i = 0; i < number; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write(pascalsTriangle[i][j] + " ");
            }
            Console.WriteLine();
        }
    }

    static int[][] GeneratePascalsTriangle(int number)
    {
        int[][] triangle = new int[number][];

        for (int i = 0; i < number; i++)
        {
            triangle[i] = new int[i + 1];
            triangle[i][0] = 1;

            for (int j = 1; j < i; j++)
            {
                triangle[i][j] = triangle[i - 1][j - 1] + triangle[i - 1][j];
            }

            triangle[i][i] = 1;
        }

        return triangle;
    }
}