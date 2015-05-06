using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;

namespace HelloWorld
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        [OperationContract]
        string getEmployDetails();
        // TODO: Add your service operations here
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "HelloWorld.ContractType".
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
    [DataContract]
    public class sampleclass
    {
        string fname;
        string lname;
        string mi;
        int age;
        
        [DataMember]
        public string firstname
        { 
            get{ return fname;}
            set {fname = value; }
        }

        [DataMember]
        public string lastname 
        { 
            get{ return lname;}
            set {lname = value; }
        }

        [DataMember]
        public string middleinitial
        { 
            get{ return mi;}
            set {mi = value; }
        }
        [DataMember]
        public int old
        {
            get { return age; }
            set { age = value; }
        }
        
        
        public override string ToString()
        {
            return "First Name is " + this.firstname +" last name is " + this.lastname + " middle initial " + this.middleinitial + " Age " + this.old;
        }
    }
}
