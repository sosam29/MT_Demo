using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Collections.Concurrent;

namespace TheadingDemo
{
    class Program
    {
        //function delegate d1 callwebservice
        string callwebservice()
        {
            webservice.Service1Client ws = new webservice.Service1Client();
            return ws.GetData(100);
        }

        static void Main(string[] args)
        {
           // string[] retval;
            webservice.Service1Client ws = new webservice.Service1Client();
            var lstvalues = new ConcurrentBag<string>();
            Thread t = new Thread(new ThreadStart(() => { ws.GetData(100); }));
            //for (int i = 0; i < 5; i++)
            //{
            //    t = new Thread(new ThreadStart(() => { lstvalues.Add(ws.GetData(100)); }));
                t.Start();
                t.Join();
               
            //}
            //Thread.SpinWait(lstvalues.Count());

            //foreach (string str in lstvalues){
            //    Console.WriteLine(str);
            //}
            Console.ReadLine();
                

            
            
        }
        
    }

    
    
}
