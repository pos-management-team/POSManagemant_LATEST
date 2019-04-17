using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data;
using System.IO;
using System.Collections.ObjectModel;
using System.Data.Common;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Web.Util;

namespace POSManagemantDAL.Repository
{
    public class CommonDAL
    {
        private SqlTransaction transaction;
        //readonly SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-8UHSCTS\MASUMSQL;Initial Catalog = POS_Management_DB; User ID = sa; Password=123;");       
        // readonly SqlConnection connection = new SqlConnection(@"Data Source=.;Initial Catalog = POS_Management_DB; User ID = sa; Password=123;");  
        readonly SqlConnection connection = new SqlConnection(@"Data Source=.;Initial Catalog = POS_Management_DB; User ID = sa; Password=123;");

        public void BeginTransaction()
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
                transaction = connection.BeginTransaction();
            }
        }

        

        public void CommitTransaction()
        {
            transaction.Commit();
        }

        public void RollBackTransaction()
        {
            transaction.Rollback();
        }

        public DataTable Query(string query)
        {

            SqlCommand command = new SqlCommand { Connection = connection, CommandText = query };
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable datatable = new DataTable();
            adapter.Fill(datatable);
            return datatable;
        }

        public bool Command(string cmd)
        {
            SqlCommand command = new SqlCommand { Connection = connection, CommandText = cmd };
            command.Transaction = transaction;
            return command.ExecuteNonQuery() > 0;
        }
    }    
}