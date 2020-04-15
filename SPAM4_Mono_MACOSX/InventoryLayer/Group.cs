using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using ConfigLayer;
using DbLayer;

namespace InventoryLayer
{
    public class Group
    {

        static Group()
        {
        }

        public static void AddGroup(string code,string desc)
        {
            SQLAccess sqlacess = new SQLAccess(DbConfig.GetConStr("MAINDB"));
            string qry = "insert into IGroup values('" + code + "','" + desc + "')";
            if (!sqlacess.ExecuteNonQuery(qry))
            {
                return;
            }
        }

        public static bool Isexist(string code)
        {
            DataTable dt = GetGroup(code);
            return dt.Rows.Count > 0;
        }

        public static DataTable GetGroup(string acode)
        {
            SQLAccess sq = new SQLAccess(DbConfig.GetConStr("MAINDB"));
            string qry = "select * from IGroup where gcode = '"+acode+"'";
            DataSet ds = sq.Execute(qry); 
           
            return ds.Tables[0];

        }

        public static DataTable ListGroup()
        {
            SQLAccess sq = new  SQLAccess(DbConfig.GetConStr("MAINDB"));
            string qry = "select * from IGroup";
            DataSet ds = sq.Execute(qry);
            return ds.Tables[0];
        }

        public static void UpdateGroup(string code, string desc)
        {
            SQLAccess sq = new SQLAccess(DbConfig.GetConStr("MAINDB"));
            string qry = "update IGroup set gname = '" + desc + "' where gcode = '" + code + "'";
            sq.ExecuteNonQuery(qry);
        }

        public static void DeleteGroup(string code)
        {
            SQLAccess sq = new SQLAccess(DbConfig.GetConStr("MAINDB"));
            string qry = "delete from IGroup where gcode = '" + code + "'";

            sq.ExecuteNonQuery(qry);

        }


    }
}
