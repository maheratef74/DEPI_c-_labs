using System.Threading.Channels;

namespace Lap_5;

public class Q_16_to_22
{
    //16- Write a C# program to pass a boxed value to a method and print it.
    private void print_obj(object obj) => Console.WriteLine(obj);

    public void print_boxing_value()
    {
        Console.WriteLine("============================q16====================================");
        int a = 74;
        object obj = a;
        print_obj(obj);
    }
    
    //17- Write a C# program to demonstrate unboxing of an integer value.
    public void print_unboxing_value()
    {
        Console.WriteLine("============================q17====================================");
        int a = 74;
        object obj = a;
        int x = (int)obj;
        print_obj(x);
    }
    
    //18- Write a C# program to check the type before unboxing.
    public void print_unboxing_value_and_check()
    {
        Console.WriteLine("============================q18====================================");
        object obj = 74;
        if (obj is int)
        {
            int x = (int)obj;
            print_obj(x); 
        }
        else Console.WriteLine("invaild unboxing");
    }
    
    // 19- Write a C# program to handle exceptions during unboxing.
    public void print_unboxing_value_handel_excption()
    {
        Console.WriteLine("============================q19====================================");
        object obj = "maher_74";
        try
        {
            int x = (int)obj;
            print_obj(x);
        }
        catch
        {
            Console.WriteLine("invaild unboxing");
        }
    }
    
    //20- Write a C# program to check if a nullable integer is null.
    public void check_null_integer()
    {
        Console.WriteLine("============================q20====================================");
        int? n = null;
        if(n is null) Console.WriteLine("n is null");
        else Console.WriteLine(n);
    }
    
    //21- Write a C# program to use the ?? operator with a nullable integer.
    public void check_null_integer_using()
    {
        Console.WriteLine("============================q21====================================");
        int? n = null;
        int res = n ?? 0;
        Console.WriteLine(res);
    }
    
    //22- Write a C# program to check if a nullable reference type is null.
    public void check_null_reference()
    {
        Console.WriteLine("============================q22====================================");
        Dog? dog = null;
        if(dog is null) Console.WriteLine("Dog is null");
        else Console.WriteLine(dog);
    }
    
}