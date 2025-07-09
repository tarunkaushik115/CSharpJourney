using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpJourney.Value___Refernce
{
    //public class ValAndRef
    //{
    //    public static int value = 10;

    //    public static void Test(int val)
    //    {
    //        val++;
    //        Console.WriteLine($" Value in function = {val}");
    //    }

    //    public static void Run()
    //    {
    //        Console.WriteLine("Value = {0}", value);
    //        Test(value);
    //        Console.WriteLine("Updated Value = {0}", value);
    //    }
    //}




    //Reference
    //public class ValAndRef
    //{
    //    public static int value = 10;

    //    public static void Test(ref int val)
    //    {
    //        val++;
    //        Console.WriteLine($" Value in function = {val}");
    //    }

    //    public static void Run()
    //    {
    //        Console.WriteLine("Value = {0}", value);
    //        Test(ref value);
    //        Console.WriteLine("Updated Value = {0}", value);
    //    }
    //}


    //Out
    public class ValAndRef
    {
        public static int value;

        public static void Test(out int val)
        {
            val=10;
            Console.WriteLine($" Value in function = {val}");
        }

        public static void Run()
        {
            Console.WriteLine("Value = {0}", value);
            Test(out value);
            Console.WriteLine("Updated Value = {0}", value);
        }
    }

}
