using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAsyncDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            //IAsyncResult[] aysncresult;
            Func<int, string> callws = Work;
            List<IAsyncResult> cookies = new List<IAsyncResult>(); 
            foreach (var item in arr)
            {
                cookies.Add(callws.BeginInvoke(item, null, null));
                //Console.WriteLine(callws.EndInvoke(cookies));
            }            
            
            Console.ReadLine();
            
        }

            //string res= sc.GetData(100);

        static string Work(int i)
        {
            helloWorld.Service1Client sc = new helloWorld.Service1Client();
            string ret = string.Empty;
            try
            {
                ret= sc.GetData(i);
                string s = sc.getEmployDetails();
                Console.WriteLine(s.ToString());
            }
            catch (System.Net.WebException webex)
            {
                Console.WriteLine(webex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return ret;
        }
    }
}
