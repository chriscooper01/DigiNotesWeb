using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Registration.Queries
{
    public class SystemQuery : Helper
    {
        public static int Single(string anchor)
        {
            
            
            using (var context = GetContext())
            {
                var model = context.GetTable<Tables.SystemTable>();
                var dbObject = model.FirstOrDefault(x => x.Anchor.Equals(anchor) );
                if (dbObject != null)
                {
                    return dbObject.Id;
                    
                }

            }
            return -1;
        }//END METHOD Single

        public static Tuple<int,string> Single(string firstId, string secondId, string thirdId, string user)
        {
            
            
            using (var context = GetContext())
            {
                var returnObject = new Tuple<int, string>(-1, String.Empty);
              
                    
                    var model = context.GetTable<Tables.SystemTable>();
                    var dbObject = model.FirstOrDefault(x => x.FirstId.Equals(firstId) && x.SecondId.Equals(secondId) && x.ThirdId.Equals(thirdId) && x.User.Equals(user));
                    if (dbObject != null)
                    {
                        returnObject = new Tuple<int, string>(dbObject.Id, dbObject.Anchor);

                    }

                  
              
                return returnObject;
            }
            
        }//END METHOD Single

        public static int Insert(string firstId, string secondId, string thirdId, string anchor, string user)
        {


            using (var context = GetContext())
            {
                var model = context.GetTable<Tables.SystemTable>();
                var dbObject = new Tables.SystemTable() { FirstId = firstId, SecondId = secondId, ThirdId = thirdId, Anchor = anchor, User = user, Created = DateTime.Now };
                model.InsertOnSubmit(dbObject);

                
                    context.SubmitChanges();
               
                return dbObject.Id;
            }
            
        }//END METHOD Insert


        public static int Total()
        {


            using (var context = GetContext())
            {
                var model = context.GetTable<Tables.SystemTable>();
                return model.ToList().Count();

                
            }

        }//END METHOD Insert

    }
}
