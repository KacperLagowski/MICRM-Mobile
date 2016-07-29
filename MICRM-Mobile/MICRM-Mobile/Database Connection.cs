using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.Data;

namespace MICRM_Mobile
{
    class Database_Connection
    {
        public static SqlConnection ConnectionFactory()
        {
            SqlConnectionStringBuilder csb = new SqlConnectionStringBuilder();
            csb.InitialCatalog = "CRM";
            csb.DataSource = @"VMPC049";
            csb.IntegratedSecurity = true;
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = csb.ConnectionString;
            return cnn;
        }
        public static SqlCommand CommandFactory(string sp)
        {
            SqlCommand cmd = new SqlCommand(sp);
            cmd.Connection = Database_Connection.ConnectionFactory();
            cmd.CommandType = CommandType.StoredProcedure;
            return cmd;
        }

    }
}