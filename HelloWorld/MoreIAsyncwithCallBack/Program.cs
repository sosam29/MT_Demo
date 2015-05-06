using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreIAsyncwithCallBack
{
    
    class test
    {
         private int Worker( string a, string b)
        {
            Console.WriteLine(a);
            Console.WriteLine(b);
            return a.Length + b.Length;
        }    
        
        static void callback(IAsyncResult ar)
         {
             Func<string, string, int> function = ar.AsyncState as Func<string, string, int>;
             int result = function.EndInvoke(ar);
             Console.WriteLine("Resulted length of String is: " + result );
         }

        public void callMethod()
        {
            Func<string, string, int> function = new Func<string, string, int>(Worker);
            IAsyncResult result = function.BeginInvoke("Samuel", "sonawane", callback, function);
        }
    }

    class program
    {
        static void Main(string[] args)
        {
            test t = new test();
            t.callMethod();
            Console.ReadLine();

        }
    }
}


