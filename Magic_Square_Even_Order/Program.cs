namespace Magic_Square_Even_Order
{
    class MagicSquare
    {
        public void GenerateMagicSquare(int n)
        {
            int[,] magicSquare = new int[n, n];

            int num = 1;
            int i = 0, j = n / 2;

            while (num <= n * n)
            {
                magicSquare[i, j] = num;

                num++;
                i--;
                j++;

                if (i < 0 && j == n)
                {
                    i += 2;
                    j--;
                }
                else if (i < 0) i = n - 1;
                
                else if (j == n) j = 0;
                
                else if (magicSquare[i, j] != 0)
                {
                    i += 2;
                    j--;
                }
            }
            Console.WriteLine($"The Magic Square of order {n}:");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(magicSquare[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            MagicSquare msq = new MagicSquare();
            msq.GenerateMagicSquare(n);
        }
    }
}

