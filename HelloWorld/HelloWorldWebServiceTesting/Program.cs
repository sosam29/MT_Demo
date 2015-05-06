using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace HelloWorldWebServiceTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Task> list = new List<Task>();
            var resultlist = new ConcurrentBag<string>();
            webservice.Service1Client  ws = new webservice.Service1Client();
            Console.WriteLine("Starting web service..");
            Console.WriteLine(ws.State);
            //t.ContinueWith(ws.GetData(100Y));
            for (int i=0; i<10; i++)
            {
                Task t = new Task(() => {resultlist.Add( ws.GetData(100)); });
                list.Add(t);
                t.Start();
            }
            
            Task.WaitAll(list.ToArray());
            int j =0;
            foreach(Task t in list)
            {
                Console.WriteLine("Task {0} status {1}", t.Id, t.Status);
                Console.WriteLine(resultlist.ElementAt(j));
                j += 1;
            }
            //Console.WriteLine();
            Console.ReadLine();
        }
    }
}
