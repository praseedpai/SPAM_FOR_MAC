using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DbLayer;
using ConfigLayer;

namespace AccountLayer
{
#if false
   public class LedgerBalance
    {
        public static DataTable LedgerTable(string jcode)
        {
            SQLAccess sq = new SQLAccess(DbConfig.GetConStr("MAINDB"));
            string qry = "select jm.J_ID,jd.J_CODE,jd.J_DRCR , jd.J_AMOUNT,S_DESC,jm.j_date " +
                "from JournalDetail jd,FaSubGroup fas,journalMaster jm " +
                "where fas.s_code=jd.j_code and jm.j_id = jd.j_id  and " +
                "jm.j_id in ( select j_id from journaldetail where j_code = '"+jcode+"') " +
                " order by j_id ,j_amount desc";
            
            DataSet ds = sq.Execute(qry);
            DataTable dt = ds.Tables[0];
            DataTable ct = dt.Clone();
            ct.Rows.Clear();

            int rc = dt.Rows.Count;

            int ic = 0;

            while (ic < rc)
            {
                DataRow dr = dt.Rows[ic];
                string journalid = dr["J_ID"].ToString().Trim();
                string j_code = dr["J_CODE"].ToString().Trim();

                if (j_code.Trim() == jcode.Trim())
                {
                    ic++;

                    DataRow dr2 = dt.Rows[ic];

                    while ((ic < rc) && (journalid == dr2["J_ID"].ToString().Trim()))
                    {
                        DataRow drct = ct.NewRow();
                        drct["J_ID"] = dr2["J_ID"];
                        drct["J_CODE"] = dr2["J_CODE"];
                        drct["J_DRCR"] = dr2["J_DRCR"].ToString();
                        drct["J_AMOUNT"] = Convert.ToDouble(dr2["J_AMOUNT"]);
                        drct["S_DESC"] = dr2["S_DESC"];
                        drct["J_DATE"] = dr2["J_DATE"];
                        ct.Rows.Add(drct);
 
                       
                        ic++;
                        if ( ic < rc )
                           dr2 = dt.Rows[ic];

                    }
                }
                else
                {
                    
                    ic++;

                    DataRow dr2 = dt.Rows[ic];

                    while ((ic < rc) && (journalid == dr2["J_ID"].ToString().Trim()))
                    {
                        if (dr2["J_CODE"].ToString().Trim() == jcode)
                        {
                            DataRow rct = ct.NewRow();
                            rct["J_ID"] = dr2["J_ID"];
                            rct["J_CODE"] = dr["J_CODE"];
                            rct["J_DRCR"] = (dr2["J_DRCR"].ToString()=="DR") ? "CR":"DR";
                            rct["J_AMOUNT"] = Convert.ToDouble(dr2["J_AMOUNT"]);
                            rct["S_DESC"] = dr["S_DESC"];
                            rct["J_DATE"] = dr2["J_DATE"];
                            ct.Rows.Add(rct);
                        }
                        
                        ic++;
                        if ( ic < rc ) 
                           dr2 = dt.Rows[ic];

                    }

                }




            }

            
            return ct;
        }
    }



#else

    /////////


   public class LedgerBalance
   {
       public static DataTable LedgerTable(string jcode)
       {
           SQLAccess sq = new SQLAccess(DbConfig.GetConStr("MAINDB"));
           string qry = "select jm.J_ID,jd.J_CODE,jd.J_DRCR , jd.J_AMOUNT,S_DESC,jm.j_date " +
               "from JournalDetail jd,FaSubGroup fas,journalMaster jm " +
               "where fas.s_code=jd.j_code and jm.j_id = jd.j_id  and " +
               "jm.j_id in ( select j_id from journaldetail where j_code = '" + jcode + "') " +
               " order by j_id ,j_amount desc";

           DataSet ds = sq.Execute(qry);
           DataTable dt = ds.Tables[0];
           DataTable ct = dt.Clone();
           ct.Rows.Clear();

           int rc = dt.Rows.Count;

           int ic = 0;

           while (ic < rc)
           {
               DataRow dr = dt.Rows[ic];
               string journalid = dr["J_ID"].ToString().Trim();
               string j_code = dr["J_CODE"].ToString().Trim();

               if (j_code.Trim() == jcode.Trim())
               {
                   ic++;

                   DataRow dr2 = dt.Rows[ic];

                   while ((ic < rc) && (journalid == dr2["J_ID"].ToString().Trim()))
                   {
                       DataRow drct = ct.NewRow();
                       drct["J_ID"] = dr2["J_ID"];
                       drct["J_CODE"] = dr2["J_CODE"];
                       //drct["J_DRCR"] = (dr2["J_DRCR"].ToString()== "CR") ? "DR" :"CR";

                       drct["J_DRCR"] = dr["J_DRCR"].ToString();
                       drct["J_AMOUNT"] = Convert.ToDouble(dr2["J_AMOUNT"]);
                       drct["S_DESC"] = dr2["S_DESC"];
                       drct["J_DATE"] = dr2["J_DATE"];
                       ct.Rows.Add(drct);


                       ic++;
                       if (ic < rc)
                           dr2 = dt.Rows[ic];

                   }
               }
               else
               {

                   ic++;

                   DataRow dr2 = dt.Rows[ic];

                   while ((ic < rc) && (journalid == dr2["J_ID"].ToString().Trim()))
                   {
                       if (dr2["J_CODE"].ToString().Trim() == jcode)
                       {
                           DataRow rct = ct.NewRow();
                           rct["J_ID"] = dr2["J_ID"];
                           rct["J_CODE"] = dr["J_CODE"];
                          // rct["J_DRCR"] = (dr2["J_DRCR"].ToString() == "DR") ? "CR" : "DR";
                           rct["J_DRCR"] = dr2["J_DRCR"].ToString();
                           rct["J_AMOUNT"] = Convert.ToDouble(dr2["J_AMOUNT"]);
                           rct["S_DESC"] = dr["S_DESC"];
                           rct["J_DATE"] = dr2["J_DATE"];
                           ct.Rows.Add(rct);
                       }

                       ic++;
                       if (ic < rc)
                           dr2 = dt.Rows[ic];

                   }

               }




           }


           return ct;
       }
   }
#endif
}
