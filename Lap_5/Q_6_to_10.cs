namespace Lap_5;

public class Q_6_to_10
{
    //6- Write a C# program to find the sum of elements in each row of a
    //two-dimensional array.
    
    public void sum_two_dimensional_array()
    {
        Console.WriteLine("============================q6=====================================");
        const int n = 2, m = 3;
        int[,] arr = new int[n,m] 
        {
            {1 , 2 , 3},
            {4 , 5 , 6}
        };
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            long sum = 0;
            for (int j = 0; j < arr.GetLength(1); j++) sum += arr[i, j];
            Console.WriteLine($"sum of row {i+1} is {sum} ");
        }
    }
    
    //7- Write a C# program to find the transpose of a given 2x3 matrix.
    public void transpose()
    {
        Console.WriteLine("============================q7=====================================");
        const int n = 2, m = 3;
        int[,] arr = new int[n,m] 
        {
            {1 , 2 , 3},
            {4 , 5 , 6}
        };

        for (int i = 0; i < m; i++)
        {
            for(int j = 0; j < n; j++) Console.Write($"{arr[j ,i]} ");
            Console.WriteLine();
        }
    }
    
   //8- Write a C# program using a while loop to print the first 10 even numbers.
   public void print_even()
   {
       Console.WriteLine("============================q8=====================================");
       int n = 10 , i = 0;
       while (i <= n)
       {
           Console.WriteLine(i);
           i += 2;
       }
   }
   
   //9- Write a C# program using a do-while loop to print numbers from 10 to 1.
   public void do_while()
   {
       Console.WriteLine("============================q9=====================================");
       int n = 10;
       do
       {
           Console.WriteLine(n--);
       } while (n > 0);
   }
   
//   10- Write a C# program to demonstrate implicit casting from int to double.

    public void implicit_casting_from_int_to_double()
    {
        Console.WriteLine("============================q10=====================================");
        int a = 74;
        double  b = a + .74;
        Console.WriteLine(b);
    }
}