using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Registration" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Registration.svc or Registration.svc.cs at the Solution Explorer and start debugging.
    public class Registration : IRegistration
    {
        public string Register(string firstId, string secondId, string thirdId, string user)
        {
            
            var item = Models.Registration.Queries.SystemQuery.Single(firstId, secondId, thirdId, user);
            if(item.Item1.Equals(-1))
            {
                string anchor = Utilities.Anchor.Create(String.Format("{0}{1}", firstId, thirdId));
                var systemId = Models.Registration.Queries.SystemQuery.Insert(firstId, secondId, thirdId, anchor,user);
                if(systemId>0)
                {
                    Models.Registration.Queries.LogQuery.Insert(systemId, "SystemRecordCreated");
                }
                return anchor;
            }

            return String.Empty;
        }

        public void Log(string anchor, string status)
        {
            var regId = Models.Registration.Queries.SystemQuery.Single(anchor);
            if(regId>0)
            {
                Models.Registration.Queries.LogQuery.Insert(regId, status);
            }
            
        }
    }
}
