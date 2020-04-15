using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using ConfigLayer;
using DbLayer;


namespace InventoryLayer
{
    public class Party
    {
         static Party()
        {
        }

         public static void AddParty(string code, string desc, string accode, string add1, string add2, string ph, string fax, string city,string det)
        {
            SQLAccess sqlacess = new SQLAccess(DbConfig.GetConStr("MAINDB"));
            string qry = "insert into party values('" + code + "','" + desc + "','" + accode + "','" + add1 + "','" + add2 + "','" + ph + "','" + fax + "','" + city + "','"+det+"')";
            if (!sqlacess.ExecuteNonQuery(qry))
            {
                return;
            }
        }

        public static bool Isexist(string code)
        {
            DataTable dt = GetParty(code);
            return dt.Rows.Count > 0;
        }

        public static DataTable GetParty(string acode)
        {
            SQLAccess sq = new SQLAccess(DbConfig.GetConStr("MAINDB"));
            string qry = "select * from party where pcode = '" + acode + "'";
            DataSet ds = sq.Execute(qry); 
           
            return ds.Tables[0];

        }

        public static DataTable ListParty()
        {
            SQLAccess sq = new  SQLAccess(DbConfig.GetConStr("MAINDB"));
            string qry = "select * from party";
            DataSet ds = sq.Execute(qry);
            return ds.Tables[0];
        }

        public static void UpdateParty(string code, string desc, string accode, string add1, string add2, string ph, string fax, string city, string det)
        {
            SQLAccess sq = new SQLAccess(DbConfig.GetConStr("MAINDB"));
            string qry = "update party set pname = '" + desc + "',p_acccode= '" + accode + "',address1 = '" + add1 + "',address2 = '" + add2 + "',phone = '" + ph + "', fax = '" + fax + "',city = '" + city + "',otherdetail = '"+ det+"' where pcode = '" + code + "'";
            sq.ExecuteNonQuery(qry);
        }

        public static void DeleteParty(string code)
        {
            SQLAccess sq = new SQLAccess(DbConfig.GetConStr("MAINDB"));
            string qry = "delete from party where pcode = '" + code + "'";

            sq.ExecuteNonQuery(qry);

        }


    }
}
