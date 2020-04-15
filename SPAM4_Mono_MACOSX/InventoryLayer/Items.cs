using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using ConfigLayer;
using DbLayer;

namespace InventoryLayer
{
    public class Items
    {

        
        static Items()
        {
        }

        public static void AddItem(string code,string desc,string grp,string unit,decimal rate,decimal qty,decimal val,string vendor)
        {
            SQLAccess sqlacess = new SQLAccess(DbConfig.GetConStr("MAINDB"));
            string qry = "insert into ItemMaster values('" + code + "','" + desc + "','"+grp+"','"+unit+"',"+rate+","+qty+","+val+",'"+vendor+"')";
            if (!sqlacess.ExecuteNonQuery(qry))
            {
                return;
            }
        }

        public static bool Isexist(string code)
        {
            DataTable dt = GetItem(code);
            return dt.Rows.Count > 0;
        }

        public static DataTable GetItem(string acode)
        {
            SQLAccess sq = new SQLAccess(DbConfig.GetConStr("MAINDB"));
            string qry = "select * from ItemMaster where itemcode = '" + acode + "' ";
            DataSet ds = sq.Execute(qry); 
           
            return ds.Tables[0];

        }

        public static DataTable GetItemByGroup(string acode)
        {
            SQLAccess sq = new SQLAccess(DbConfig.GetConStr("MAINDB"));
            string qry = "select * from ItemMaster where itemgp = '" + acode + "' ";
            DataSet ds = sq.Execute(qry);

            return ds.Tables[0];

        }

        public static DataTable ListItem()
        {
            SQLAccess sq = new  SQLAccess(DbConfig.GetConStr("MAINDB"));
            string qry = "select * from ItemMaster";
            DataSet ds = sq.Execute(qry);
            return ds.Tables[0];
        }

        public static void UpdateItem(string code, string desc, string grp, string unit, decimal rate, decimal qty, decimal val, string vendor)
        {
            SQLAccess sq = new SQLAccess(DbConfig.GetConStr("MAINDB"));
            string qry = "update ItemMaster set itemdesc = '" + desc + "',itemgp= '" + grp + "',unit = '" + unit + "',rate = " + rate + ",qty = " + qty + ", stockvalue =" + val + ",vendor = '" + vendor + "' where itemcode = '" + code + "'";
            sq.ExecuteNonQuery(qry);
        }

        public static void DeleteItem(string code)
        {
            SQLAccess sq = new SQLAccess(DbConfig.GetConStr("MAINDB"));
            string qry = "delete from ItemMaster where itemcode = '" + code + "'";

            sq.ExecuteNonQuery(qry);

        }

    }
}
