using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tEST_bd.Db
{
    internal class DbManager
    {
        private static DbManager _instance = null;

        public static DbManager Instance  
        {
            get 
            {
                if (_instance == null) 
                {
                    _instance = new DbManager();
                }
                return _instance;
            }
        }

        public TableWorkers TableWorkers { get; private set; }

        private DbManager() 
        {
            DbConnection dbconection = new DbConnection("194.67.105.79", "mcd_dima_user", "12345", "mcd_dima_db");
            TableWorkers = new TableWorkers(dbconection.Connection);
        }
    }
}
