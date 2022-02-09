using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Source_code.DataBase
{
    public  class ConnectionToDb:DbContext
    {
        #region Connection to DB
        public ConnectionToDb() : base("DataBasePath")
        {

        }
        #endregion

        #region Tables

        #endregion
    }
}
