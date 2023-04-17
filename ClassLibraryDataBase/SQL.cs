using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDataBase
{
    public class SQL
    {

    
        public static string Conect;
        public static DataSet Table(string query)
        {
            DataSet Table = new DataSet();
            SqlConnection con = new SqlConnection(SQL.Conect);
            try
            {
                con.Open();
            }
            catch (Exception)
            {

                return Table;
            }
            try
            {
                
                SqlDataAdapter a = new SqlDataAdapter(query, con);
                a.Fill(Table);
                return Table;
            }
            catch (Exception)
            {

                return Table;
            }

        }

        public static bool Query(string query)
        {
            DataSet Table = new DataSet();

            SqlConnection con = new SqlConnection(SQL.Conect);
            try
            {
                con.Open();
            }
            catch (Exception)
            {

                return false;
            }
            try
            {
                SqlDataAdapter a = new SqlDataAdapter(query, con);
                a.Fill(Table);
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }

        public static DataSet Table(string query, List<SqlParameter> ListSqlParamete)
        {
            DataSet Table = new DataSet();
            SqlConnection con = new SqlConnection(SQL.Conect);
            //try
            //{
                con.Open();
            //}
            //catch (Exception)
            //{
            //
            //    return Table;
            //}
            //try
            //{
                SqlDataAdapter a = new SqlDataAdapter(query, SQL.Conect);
                a.SelectCommand.Parameters.AddRange(ListSqlParamete.ToArray());
                a.Fill(Table);
                return Table;
            //}
            //catch (Exception)
            //{
            //
            //    return Table;
            //}

        }

        public static bool Query(string query, List<SqlParameter> ListSqlParamete)
        {
            DataSet Table = new DataSet();

            SqlConnection con = new SqlConnection(SQL.Conect);
            try
            {
                con.Open();
            }
            catch (Exception)
            {

                return false;
            }
            try
            {
                SqlDataAdapter a = new SqlDataAdapter(query, SQL.Conect);
                a.SelectCommand.Parameters.AddRange(ListSqlParamete.ToArray());
                a.Fill(Table);
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }
    }
}
