using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Diagnostics;

namespace HelloWorld
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            Stopwatch tmr = new Stopwatch();
            tmr.Start();
            Random rdm = new Random();
            int rdmnbr = rdm.Next(1, 5);
            int rdmnbr2 = rdm.Next(2000, 3000);
            Thread.Sleep(rdmnbr *100);
            return string.Format("You entered: {0}- time taken is {1}", rdmnbr2, tmr.ElapsedMilliseconds);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
        public string getEmployDetails()
        {
            sampleclass sc = new sampleclass {
               firstname = "sam",
               lastname ="sonawane",
               middleinitial ="p",
               old= 42,
            };

            return sc.ToString();
            //return "First name is " + sc.firstname + " last name is" + sc.lastname + " middle initial " + sc.middleinitial + " with age " + sc.old;
        }
    }
}
