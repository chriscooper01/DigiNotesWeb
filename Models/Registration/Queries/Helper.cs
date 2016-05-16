using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Registration.Queries
{
    public class Helper
    {
        private static string db = "Data Source={0};Initial Catalog = {1}; User ID = {2}; Password={3}";
        public static string ConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["DigiNote"].ConnectionString;
            }
        }

        protected static DataContext GetContext()
        {

            try
            {
                
                DataContext ContextDatabase = new DataContext(ConnectionString);
                return ContextDatabase;


            }
            catch (Exception e)
            {

            }
            return null;
        }

    }
}
