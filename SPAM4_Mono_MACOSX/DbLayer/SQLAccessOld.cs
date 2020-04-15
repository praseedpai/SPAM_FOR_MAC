using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
//using System.Collections.Generic;
//using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DbLayer2
{
    public class SQLAccess
    {
        private SqlConnection _con = null;
        private SqlCommand _cmd = null;
        string _constr;

        public SQLAccess(string constr)
        {
            _constr = constr;
        }

        public DataSet Execute(string SQL)
        {
            _con = new SqlConnection(_constr);
            _con.Open();
            _cmd = new SqlCommand(SQL, _con);
            SqlDataAdapter da = new SqlDataAdapter(_cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            _con.Close();
            return ds;
        }

        public SqlDataReader ExecuteQuery(string SQL)
        {
            _con = new SqlConnection(_constr);
            _con.Open();
            _cmd = new SqlCommand(SQL, _con);
            SqlDataReader rs = _cmd.ExecuteReader();
            _con.Close();
            return rs;
        }

        public bool ExecuteNonQuery(string SQL)
        {
            try
            {
                _con = new SqlConnection(_constr);
                _con.Open();
                _cmd = new SqlCommand(SQL, _con);
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

namespace DbLayer
{
    class SQLAccessOld
    {
    }
}
