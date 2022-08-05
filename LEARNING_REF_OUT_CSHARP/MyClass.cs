using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEARNING_REF_OUT_CSHARP
{
    internal class MyClass
    {
        public void Swap(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;

            System.Console.WriteLine
                  (string.Format("a = {0} , b = {1}", a, b));
        }

        public void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;

            System.Console.WriteLine
                  (string.Format("a = {0} , b = {1}", a, b));
        }


        public int Sum_Multiply(int a, int b, out int c)
        {
            int sum = a + b;
            
            int multiply = a * b;

            c = multiply;

            return sum;
        }


        //public int Sum_Multiply(int a , int b,out int c)
        //{
        //    int sum = a + b;
        //    int multiply = a * b;

        //    return sum; // compiler error beacuse the parameter c must be assigned to value 
        //}
    }
}
