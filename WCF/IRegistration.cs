using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IRegistration" in both code and config file together.
    [ServiceContract]
    public interface IRegistration
    {
        [OperationContract]
        string Register(string firstId, string secondId, string thirdId, string user);

        [OperationContract]
        void Log(string anchor, string status);
    }
}
