﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALL
{
    public class DBC
    {

        public SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Rumman\Documents\Hotel.mdf;Integrated Security=True;Connect Timeout=30");

        public SqlConnection getcon()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            else
            {

                con.Close();
                con.Open();
            }
            return con;
        }

        public object ExeScaler(SqlCommand com)
        {
            com.Connection = getcon();
            object obj = -1;
            obj = com.ExecuteScalar();
            con.Close();
            return obj;
        }

        public DataTable ExeReader(SqlCommand com)
        {
            com.Connection = getcon();
            DataTable dt = new DataTable();
            SqlDataReader sdr;
            sdr = com.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            return dt;
        }

        public SqlDataReader sExeReader(SqlCommand com)
        {
            com.Connection = getcon();
            //DataTable dt = new DataTable();
            SqlDataReader sdr;
            sdr = com.ExecuteReader();
            //dt.Load(sdr);
           // con.Close();
            return sdr;
        }







    }
}
