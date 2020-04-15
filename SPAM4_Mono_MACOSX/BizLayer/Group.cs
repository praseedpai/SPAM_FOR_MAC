using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using ConfigLayer;
using DbLayer;

namespace AccountLayer
{
   public class Group
   {
       static Group()
       {

       }

       public static void AddGroup(string acode, string adesc,string type,decimal curbal)
       {
           //SPAccess sp = new SPAccess(DbConfig.GetConStr("MAINDB"));
           //sp.Add("@A_CODE", typeof(System.String), acode);
           //sp.Add("@A_DESC", typeof(System.String), adesc);
           //sp.Add("@A_TYPE", typeof(System.String), type);
           //sp.Add("@A_CURRB", typeof(System.Decimal), curbal);

          // sp.ExecuteNonQuery("spCreateFAGroup");

           SQLAccess sq = new SQLAccess(DbConfig.GetConStr("MAINDB"));

           sq.ExecuteNonQuery("INSERT into FAGroup values ('"+acode +"',"+
               "'"+adesc+"'," + "'" +type +"'," + curbal.ToString() +")" );


       }

       public static DataTable GetGroup(string acode)
       {
           SQLAccess sq = new SQLAccess(DbConfig.GetConStr("MAINDB"));
           DataSet ds = sq.Execute("select * from FAGroup  where A_CODE = '" + acode + "'");
                   
           
          
           return ds.Tables[0];
       
       }

       public static void DeleteGroup(string acode)
       {
           SQLAccess sq = new SQLAccess(DbConfig.GetConStr("MAINDB"));
           
           sq.ExecuteNonQuery("Delete from FAGroup  where A_CODE = '" + acode + "'");

            
              
       }

       public static bool Isexist(string acode)
       {
           DataTable dt = GetGroup(acode);
           return dt.Rows.Count > 0;
          
       }

       public static DataTable ListGroup()
       {
           SQLAccess sq = new SQLAccess(DbConfig.GetConStr("MAINDB"));
           DataSet ds = sq.Execute("Select * from FAGroup");
           return ds.Tables[0];
       }

       public static void UpdateGroup(string acode, string adesc, string type, decimal curbal)
       {
          
           SQLAccess sq = new SQLAccess(DbConfig.GetConStr("MAINDB"));
           sq.ExecuteNonQuery("Update  FAGroup set A_DESC='"+acode+"',"+"A_TYPE ='"+type+"',A_CURRB ='"+
               curbal.ToString() + "' where A_CODE = '" + acode + "'");


       }

    }
}
