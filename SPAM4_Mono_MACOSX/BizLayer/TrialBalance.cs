using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DbLayer;
using ConfigLayer;

namespace AccountLayer
{
   public class TrialBalance
    {
       public static DataTable TrialTable()
       {
           SQLAccess sq = new SQLAccess(DbConfig.GetConStr("MAINDB"));
           string qry = "select pas.s_desc,total from "+
               "(select j_code ,sum( case  j_drcr "+ 
                                   "when 'DR' then "+
                                     "j_amount "+
                                     "else "+
                                     "-j_amount end) as total from JournalDetail" + 
                                     " group by j_code) test , "+
                    "FaSubgroup pas where test.j_code = pas.s_code";
           DataSet ds = sq.Execute(qry);
           return ds.Tables[0];
       }
    }
}
