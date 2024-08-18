using Console = System.Console;

namespace Lap_5;

public class Q_11_to_15
{
   //11- Write a C# program to demonstrate explicit casting from double to int.
   public void explicit_casting_from_double_to_int()
   {
      Console.WriteLine("============================q11=====================================");
      double x = 74.74;
      int y = (int)x; // unsave casting 
      Console.WriteLine(y);
   }  
   
   //12- Write a C# program to use the Convert class to convert a string
  // to an integer.

  public void string_to_an_integer()
  {
      Console.WriteLine("============================q12=====================================");
      string num = "74";
      int n = int.Parse(num);
      Console.WriteLine(n);
  }
  
//  13- Write a C# program to cast an Dog object from a parent reference
//      to Animal to a child reference to Dog with check on the type using the is operator.
    public void cast_dog_to_animal()
    {
        Console.WriteLine("============================q13=====================================");
        Animal animal = new Dog();
        Dog dog = new Dog();
        if (animal is Dog)
        {
            dog = (Dog)animal;
            Console.WriteLine("Casting done");
        }
        else
        {
            Console.WriteLine("casting failled");
        }
        
    }
    
   //14- Write a C# program to demonstrate boxing of an integer value.
   public void boxing()
   {
       Console.WriteLine("============================q14=====================================");
       int m = 74;
       object x = m;
       Console.WriteLine(x);
   }
   
   //15- Write a C# program to demonstrate that changes to a boxed value
   // do not affect the original value.
   public void boxing_does_not_affect()
   {
       Console.WriteLine("============================q15=====================================");
       int m = 74;
       object x = m;
       m = 72;
       Console.WriteLine($"obj is {x}");
       Console.WriteLine($"value is {m}");
   }
   
}