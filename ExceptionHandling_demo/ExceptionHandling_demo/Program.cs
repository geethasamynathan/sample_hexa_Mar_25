// See https://aka.ms/new-console-template for more information
using ExceptionHandling_demo;

Console.WriteLine("Hello, World!");


//try
//{
//    int x, y, res;
//    Console.WriteLine("Enter 2 integer values");
//    x = Convert.ToInt32(Console.ReadLine());
//    y = Convert.ToInt32(Console.ReadLine());
//    res = x / y;
//    Console.WriteLine($"Division Result={res}");
//}
//catch(FormatException fe) {
//    Console.WriteLine($"Format exception {fe.Message}");
//}
//catch(DivideByZeroException de)
//{ Console.WriteLine($"Divide By Zero Exception {de.Message}"); 
//}
//catch(Exception e)
//{
//    Console.WriteLine($"General Exception :{e.Message}");
//}
//finally
//{

//    Console.WriteLine("End of the Program");
//}


DemoClass demo = new DemoClass();
try
{
    demo.MethodDivide();
}
catch (Exception ex)
{
    Console.WriteLine("Rethrown Exception: " + ex.TargetSite);
}

//int age;
//Console.WriteLine(" Enter the Age should between 18 to 70");
//age = Convert.ToInt32(Console.ReadLine());
//try
//{
//    if (age < 17 || age >= 70)
//    {
//        throw new Exception("Age should be 18 - 70");
//    }
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}

Console.ReadLine();