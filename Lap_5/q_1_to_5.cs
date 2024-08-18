namespace Lap_5;

public class q_1_to_5
{
   private void Swap<T>(ref T x, ref T y)
    {
        T temp = x;
        x = y;
        y = temp;
    }
    
    //2- Write a C# program to declare a one-dimensional array of integers,
  //  initialize it with 5 elements, and print each element using a loop.
  public void one_dimensional_array()
  {
      Console.WriteLine("============================q2=====================================");

      int[] arr = new int[5]  {74 , 22 , 20 , 1 , 2};

      foreach (var item in arr)
      {
          Console.WriteLine(item);
      }
  }
  
  
  //3- Write a C# program to find the sum of all elements in a one-
 // dimensional array of integers.
     public void sum_of_all_elements_in_a_one_dimensional()
     {
         Console.WriteLine("============================q3=====================================");

         int[] arr = new int[5]  {74 , 22 , 20 , 1 , 2};
         int[] prifx = new int[5];
         var sum = 0;
         prifx[0] = arr[0];
         for(int i = 1; i < arr.Length; i++)
         {
             prifx[i] = prifx[i-1] + arr[i];
         }
         // now if you want any range of sum you can output 
         Console.WriteLine(prifx[arr.Length-1]);
     }
 
     
     //4- Write a C# program to reverse the elements of a one-dimensional array.
     public void reverse_the_elements_of_a_one_dimensional_array()
     {
         Console.WriteLine("============================q4=====================================");

         int[] arr = new int[5]  {74 , 22 , 20 , 1 , 2};
         for (int i = 0; i < arr.Length/2; i++)
         {
             Swap(ref arr[i] ,ref arr[arr.Length-1-i]);  // reverse in the same arr not new arr
         }
         foreach (var item in arr) Console.WriteLine(item);
     }
     
    // 5- Write a C# program to declare a two-dimensional array of integers,
    //   initialize it with values, and print each element using nested loops.

    public void two_dimensional_array()
    {
        Console.WriteLine("============================q5=====================================");
        const int n = 2, m = 3;
        int[,] arr = new int[n,m] 
        {
            {1 , 2 , 3},
            {4 , 5 , 6}
        };
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for(int j = 0 ; j < arr.GetLength(1); j++) Console.Write($"{arr[i,j]} ");
            Console.WriteLine();
        }
    }
     
}