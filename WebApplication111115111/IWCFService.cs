using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebApplication111115111
{
    [ServiceContract]
    public interface IWCFService
    {
        //two way (not sure)
        [OperationContract (IsOneWay =false)]
        UserClass ViewProfile(string email);

        //one way (not sure)
        [OperationContract (IsOneWay = true)]
        void Register(string name, int age, int weight, string gender, string email, string password);


    }
}
