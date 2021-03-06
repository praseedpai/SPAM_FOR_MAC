using System;

using System.Collections.Generic;

using System.Text;

using System.Data;

using Mono.Data.SqliteClient;
 


namespace DbLayer

{

    public class SQLAccess

    {

        private SqliteConnection _con = null;

        private SqliteCommand _cmd = null;

        string _constr;



        public SQLAccess(string constr)

        {

            _constr = constr;

        }



        public DataSet Execute(string SQL)

        {

            _con = new SqliteConnection(_constr);

            _con.Open();

            _cmd = new SqliteCommand(SQL, _con);

            SqliteDataAdapter da = new SqliteDataAdapter(_cmd);

            DataSet ds = new DataSet();

            da.Fill(ds);

            _con.Close();
            _con = null;

            return ds;

        }



        public IDataReader ExecuteQuery(string SQL)

        {

            _con = new SqliteConnection(_constr);

            _con.Open();

            _cmd = new SqliteCommand(SQL, _con);

            SqliteDataReader rs = _cmd.ExecuteReader();

            return rs;

        }

        public bool Close() {
                 if ( _con != null )
                    _con.Close();
               return true;  

        } 



        public bool ExecuteNonQuery(string SQL)

        {

            try

            {

                _con = new SqliteConnection(_constr);

                _con.Open();

                _cmd = new SqliteCommand(SQL, _con);

                _cmd.ExecuteNonQuery();

                _con.Close();
                _con = null;

                return true;

            }

            catch (Exception e)

            {

                e.ToString();

                return false;

            }

        }

      

    }

    

} // DbLayer

