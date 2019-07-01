using System;
using System.Collections.Generic;

namespace boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> obj = new List<object>();
            obj.Add(7);
            obj.Add(28);
            obj.Add(-1);
            obj.Add(true);
            obj.Add("chair");
            int sum  = 0;
            foreach (var x in obj){
                if(x is int){
                   sum = sum + (int)x;
                }
                Console.WriteLine(x);
            };
            Console.WriteLine(sum);
            Console.WriteLine("Hello World!");
        }
    }
}
