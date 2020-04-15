using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DbLayer
{
    /// <summary>
    /// 
    /// </summary>
    internal class TypeTranslator
    {
        private static Hashtable _hash = null;

         static TypeTranslator()
        {
            _hash = new Hashtable(); 
            _hash.Add("System.Int32",DbType.Int32);
            _hash.Add("System.String",DbType.String);
            _hash.Add("System.Double", DbType.Double);
            _hash.Add("System.DateTime", DbType.DateTime);
            _hash.Add("System.Decimal", DbType.Decimal);
  
  
        }

        public static DbType Get( string typename )
        {
            return (DbType)_hash[typename];
        }

    }

    public class SPAccess
    {
        private SqlConnection _con = null;
        private SqlCommand _cmd = null;

       
        string _constr;

        public SPAccess(string constr)
        {
            _constr = constr;
            _cmd = new SqlCommand(); 
        }

        public bool Add(string fieldname, System.Type tp, Object a)
        {
            DbType dbtype = TypeTranslator.Get(tp.ToString());
            _cmd.Parameters.Add(new SqlParameter(fieldname,dbtype));
            _cmd.Parameters[fieldname].Value=a;
            return true;
         }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public DataSet Execute(string SPName)
        {
            _con = new SqlConnection(_constr);
            _con.Open();
            _cmd.Connection = _con;
            _cmd.CommandText = SPName;
            _cmd.CommandType = CommandType.StoredProcedure; 
            SqlDataAdapter da = new SqlDataAdapter(_cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            _con.Close();
            return ds;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="SQL"></param>
        /// <returns></returns>
        public SqlDataReader ExecuteQuery(string SPName)
        {
            _con = new SqlConnection(_constr);
            _con.Open();
            _cmd.Connection = _con;
            _cmd.CommandText = SPName;
            _cmd.CommandType = CommandType.StoredProcedure;  
            SqlDataReader rs = _cmd.ExecuteReader();
            _con.Close();
            return rs;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="SPName"></param>
        /// <returns></returns>
        public bool ExecuteNonQuery(string SPName)
        {
            try
            {
                _con = new SqlConnection(_constr);
                _con.Open();
                _cmd.Connection = _con;
                _cmd.CommandText = SPName;
                _cmd.CommandType = CommandType.StoredProcedure; 
                _cmd.ExecuteNonQuery();
                _con.Close();
                return true;
            }
            catch (Exception e)
            {
                e.ToString();
                return false;
            }
        }



    }
}
