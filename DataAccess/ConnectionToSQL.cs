﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace DataAccess
{
    public abstract class ConnectionToSQL
    {
        // todos son static porque no voy a instanciar nunca esta clase
        private readonly string strconn;

        public ConnectionToSQL()
        {
            strconn= "Data Source=MSI;Initial Catalog=MarujaQuito;User ID=sa;Password=P@ssw0rd";
        }
        protected SqlConnection GetConnection() 
        { 
            return new SqlConnection(strconn);
        }

 
    }
}
