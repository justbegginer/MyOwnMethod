using System;
using MyMethod;
namespace MyOwnMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine().SubstringReturn(0,2);
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}
namespace MyMethod
{
    public static class StringOperation
    {
        public static string SubstringReturn(this String str , int index , int length )
        {
            string result = "";
            for (int counter = 0 ; counter<length ; counter++)
            {
                result += str[index + counter];
            }
            return result;
        }
    }

}
