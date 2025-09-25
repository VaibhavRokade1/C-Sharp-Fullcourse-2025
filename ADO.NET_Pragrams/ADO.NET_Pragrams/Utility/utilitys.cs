using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_Pragrams.Utility
{
    public class Utilitys
    {
        // using singleton 
        public static Utilitys utility = null;
        private Utilitys() { }

        public string conString = "Server=(localdb)\\MSSQLLocalDB;Database=Vaibhav;Trusted_Connection=True;";
        public static Utilitys GetUtilInstance() {
            if (utility == null)
            {
                return new Utilitys();
            }
            else {
                return utility;
            }
        }

    }
}
