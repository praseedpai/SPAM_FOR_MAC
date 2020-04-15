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
   public class PandL
    {
        public static DataTable ProfitAndLoss1()
        {
            SQLAccess sq = new SQLAccess(DbConfig.GetConStr("MAINDB"));
            string qry = "select pas.s_desc,total from " +
                "(select j_code ,sum( case  j_drcr " +
                                    "when 'DR' then " +
                                      "j_amount " +
                                      "else " +
                                      "-j_amount end) as total from JournalDetail" +
                                      " group by j_code) test , " +
                     "FaSubgroup pas where test.j_code = pas.s_code and convert(int,pas.s_type) >= 50 and convert(int,pas.s_type) < 75";
            DataSet ds = sq.Execute(qry);
            return ds.Tables[0];
        }


        public static DataTable ProfitAndLoss2()
        {
            SQLAccess sq = new SQLAccess(DbConfig.GetConStr("MAINDB"));
            string qry = "select pas.s_desc,total from " +
                "(select j_code ,sum( case  j_drcr " +
                                    "when 'DR' then " +
                                      "j_amount " +
                                      "else " +
                                      "-j_amount end) as total from JournalDetail" +
                                      " group by j_code) test , " +
                     "FaSubgroup pas where test.j_code = pas.s_code and convert(int,pas.s_type) >= 75 and convert(int,pas.s_type) <= 99";
            DataSet ds = sq.Execute(qry);
            return ds.Tables[0];
        }
    }
}
