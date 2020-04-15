using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DbLayer;
using ConfigLayer;

namespace InventoryLayer
{
    public class Unit
    {
         static Unit()
        {
        }

        public static void AddUnit(string code,string desc)
        {
            SQLAccess sqlacess = new SQLAccess(DbConfig.GetConStr("MAINDB"));
            string qry = "insert into Unit values('" + code + "','" + desc + "')";
            if (!sqlacess.ExecuteNonQuery(qry))
            {
                return;
            }
        }

        public static bool Isexist(string code)
        {
            DataTable dt = GetUnit(code);
            return dt.Rows.Count > 0;
        }

        public static DataTable GetUnit(string acode)
        {
            SQLAccess sq = new SQLAccess(DbConfig.GetConStr("MAINDB"));
            string qry = "select * from Unit where ucode = '"+acode+"'";
            DataSet ds = sq.Execute(qry); 
           
            return ds.Tables[0];

        }

        public static DataTable ListUnit()
        {
            SQLAccess sq = new  SQLAccess(DbConfig.GetConStr("MAINDB"));
            string qry = "select * from Unit";
            DataSet ds = sq.Execute(qry);
            return ds.Tables[0];
        }

        public static void UpdateUnit(string code, string desc)
        {
            SQLAccess sq = new SQLAccess(DbConfig.GetConStr("MAINDB"));
            string qry = "update Unit set uname = '" + desc + "' where ucode = '" + code + "'";
            sq.ExecuteNonQuery(qry);
        }

        public static void DeleteUnit(string code)
        {
            SQLAccess sq = new SQLAccess(DbConfig.GetConStr("MAINDB"));
            string qry = "delete from Unit where ucode = '" + code + "'";

            sq.ExecuteNonQuery(qry);

        }


    }
}
