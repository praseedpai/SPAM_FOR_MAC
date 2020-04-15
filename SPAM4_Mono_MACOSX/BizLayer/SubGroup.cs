using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using ConfigLayer;
using DbLayer;

namespace AccountLayer
{

    public class SubGroup
    {
       

        public static void AddSubGroup(string scode, string sdesc,string stype,decimal opbal, string drcr,string flag)
        {
            //SPAccess sp = new SPAccess(DbConfig.GetConStr("MAINDB"));
            //sp.Add("@S_CODE", typeof(System.String), scode);
            //sp.Add("@S_DESC", typeof(System.String), sdesc);
            //sp.Add("@S_TYPE", typeof(System.String), stype);
            //sp.Add("@S_OPBAL", typeof(System.String), opbal);
            //sp.Add("@S_DRCR", typeof(System.String), drcr);
            //sp.Add("@S_FLAG", typeof(System.String), flag);
            //sp.ExecuteNonQuery("spCreateFASubGroup");

            SQLAccess sq = new SQLAccess(DbConfig.GetConStr("MAINDB"));

            sq.ExecuteNonQuery("INSERT into FASubGroup values ('" + scode + "'," +
                "'" + sdesc + "'," + "'" + stype + "'," + opbal.ToString() + ",'"+drcr+"','"+flag+"')");




             
        }

        public static DataTable GetSubGroup(String scode)
        {
            //SPAccess sp = new SPAccess(DbConfig.GetConStr("MAINDB"));
            //sp.Add("@S_CODE", typeof(System.String), scode);

            //DataSet ds = sp.Execute("spGetFASubGroup");

            SQLAccess sq = new SQLAccess(DbConfig.GetConStr("MAINDB"));
            DataSet ds = sq.Execute("select * from FASubGroup  where S_CODE = '" + scode + "'");
                   
            return ds.Tables[0];
        }

        public static void DeleteSubGroup(string scode)
        {
           // SPAccess sp = new SPAccess(DbConfig.GetConStr("MAINDB"));
           // sp.Add("@S_CODE", typeof(System.String), scode);
           // sp.ExecuteNonQuery("spDeleteFASubGroup");

            SQLAccess sq = new SQLAccess(DbConfig.GetConStr("MAINDB"));

            sq.ExecuteNonQuery("Delete from FASubGroup  where S_CODE = '" + scode + "'");
        }

        public static bool IsSubGroup(string scode)
        {
            DataTable dt = GetSubGroup(scode);
            return dt.Rows.Count > 0;
        }

        public static DataTable ViewSubGroup()
        {
            //SPAccess sp = new SPAccess(DbConfig.GetConStr("MAINDB"));
            //DataSet ds = sp.Execute("spListFASubGroup");
            //return ds.Tables[0];
            SQLAccess sq = new SQLAccess(DbConfig.GetConStr("MAINDB"));
            DataSet ds = sq.Execute("Select * from FASubGroup");
            return ds.Tables[0];
        }

        public static DataTable GetSubGroupByGroup(string code)
        {
            SQLAccess sq = new SQLAccess(DbConfig.GetConStr("MAINDB"));
            string qry = "select * from FAsubgroup where s_type = '"+code+"' ";
            DataSet ds = sq.Execute(qry);
            return ds.Tables[0];
        }

        public static void UpdateSubGroup(string scode, string sdesc, string stype, decimal opbal, string drcr, string flag)
        {
            //SPAccess sp = new SPAccess(DbConfig.GetConStr("MAINDB"));
            //sp.Add("@S_CODE", typeof(System.String), scode);
            //sp.Add("@S_DESC", typeof(System.String), sdesc);
            //sp.Add("@S_TYPE", typeof(System.String), stype);
            //sp.Add("@S_OPBAL", typeof(System.String), opbal);
            //sp.Add("@S_DRCR", typeof(System.String), drcr);
            //sp.Add("@S_FLAG", typeof(System.String), flag);
            //sp.ExecuteNonQuery("spUpdateFASubGroup");

            SQLAccess sq = new SQLAccess(DbConfig.GetConStr("MAINDB"));
            sq.ExecuteNonQuery("Update  FASubGroup set S_DESC='" + sdesc + "'," + "S_TYPE ='" + stype + "',S_OPBAL ='" +
                opbal.ToString() + "',S_DRCR='"+drcr+"',S_FLAG='" +flag+"'" +"  where S_CODE = '" + scode + "'");

        }
    }
}
