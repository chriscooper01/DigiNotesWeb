using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Registration.Queries
{
    public class LogQuery : Helper
    {
        public static int Insert(int systemId, string status)
        {
            
            using (var context = GetContext())
            {
                var model = context.GetTable<Tables.LogTable>();

                var dbObject = new Tables.LogTable() { RegistrationId = systemId, Status = status, Created = DateTime.Now };
              
                
                model.InsertOnSubmit(dbObject);
                context.SubmitChanges();
         
         
                return dbObject.Id;

            }

        }//END METHOD Insert
    }
}
