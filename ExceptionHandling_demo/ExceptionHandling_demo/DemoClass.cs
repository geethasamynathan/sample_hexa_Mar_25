using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling_demo
{
    public class DemoClass
    {
        public void MethodDivide()
        {
           
                int a, b;
                Console.WriteLine("Enter the Divisor and Dividend:");
                a = int.Parse(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                int c = a / b;
                Console.WriteLine("The Quotient: " + c);
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("Specific Exception: " + ex.TargetSite);
            //    throw ex;  //--Rethrowing an exception
            //}
            //catch (Exception ex) //--Generalised Exception
            //{
            //    Console.WriteLine("Generalised Exception: " + ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Finally Block of Statement will be executed irrespective of an exception");
            //}
        }
    }
}
