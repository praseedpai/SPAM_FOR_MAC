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
    public class Journal
    {
        public string jid;
        public string jdate;
        public string narration;
        public List<JournalEntry> rs;

    }

    public class JournalEntry
    {
        public string jcode;
        public string jname;
        public string drcr;
        public string amount;
    }

   public class JournalPoster
    {
        public static bool PostForAdd(Journal j)
        {

            if (IsValidJournal(j.jid))
            {
                return false;
            }

            List<JournalEntry> jrs = j.rs;
            if (jrs.Count == 0)
            {
                return false;
            }

            int s = jrs.Count;
            int dcount = 0;
            int ccount = 0;

            double damount = 0.0;
            double camount = 0.0;

            foreach(JournalEntry je in jrs)
            {
                if (je.drcr == "CR")
                {
                    ccount++;
                    camount = camount + Convert.ToDouble(je.amount);
                }
                else if (je.drcr == "DR")
                {
                    dcount++;
                    damount = damount + Convert.ToDouble(je.amount);
                }
                else
                {
                    return false;
                }

                string cd = JnameToJCode(je.jname);
                if (cd == null)
                {
                    return false;
                }

                je.jcode = cd;


            }

            if (ccount > 1 && dcount > 1)
            {
                return false;
            }
            if (ccount == 0 || dcount == 0)
            {
                return false;
            }

            if (damount != camount)
            {
                return false;
            }


            return DoPost(j);
        }

        public static bool IsValidJournal(string JId)
        {
            DataTable dt = GetJournal(JId);
            return dt.Rows.Count > 0;
        }

        public static DataTable GetJournal(String JId)
        {
            //SPAccess sp = new SPAccess(DbConfig.GetConStr("MAINDB"));
            //sp.Add("@J_ID", typeof(System.String), JId);

           // DataSet ds = sp.Execute("spGetJMaster");
            SQLAccess sq = new SQLAccess(DbConfig.GetConStr("MAINDB"));

            DataSet ds = sq.Execute("select * from JournalMaster where J_ID ='" + JId + "'");
            return ds.Tables[0];
        }

        public static int NextJournal()
        {
            SQLAccess sq = new SQLAccess(DbConfig.GetConStr("MAINDB"));
            string qry = @"select max(convert(int, J_ID))+1 as CNT from JournalMaster";
            DataSet ds = sq.Execute(qry);
            DataTable dt = ds.Tables[0];
            if (dt.Rows.Count == 0)
            {
                return 1;
            }
            else
            {
                DataRow dr = dt.Rows[0];
                if (dr["CNT"] == DBNull.Value)
                {
                    return 1;
                }
                int ls = (int)dr["CNT"];
                return ls;
            }
        }

        public static string JnameToJCode(string Jname)
        {
            SQLAccess sq = new SQLAccess(DbConfig.GetConStr("MAINDB"));
            string qry = "select S_CODE from FASubGroup where S_DESC = '"+Jname+"'";
            DataSet ds = sq.Execute(qry);
            DataTable dt = ds.Tables[0];
            if(dt.Rows.Count == 0)
            {
                return null;
            }
            DataRow dr = dt.Rows[0];
            object obj = dr["S_CODE"];
            if(obj == null || obj == DBNull.Value)
            {
                return null;
            }
            return obj as string ;
        }

        private static bool DoPost(Journal j)
        {

            TSQLAccess sq = new TSQLAccess(DbConfig.GetConStr("MAINDB"));
            sq.Open();
            try
            {
                string qry = "insert into JournalMaster values('" + j.jid + "','JV','" + DateTime.Now + "',0,'" + j.narration + "')";
                sq.ExecuteNonQuery(qry);
                List<JournalEntry> je = j.rs;
                foreach (JournalEntry js in je)
                {
                    qry = "insert into JournalDetail values('" + j.jid + "','" + js.jcode + "','" + js.drcr + "'," + js.amount + ")";
                    sq.ExecuteNonQuery(qry);
                }
                sq.Close();
                return true;
            }
            catch (Exception ex)
            {
                sq.Abort();
                return false;
            }
        }

        public static Journal GetJournalFromId(string jid)
        {
            SQLAccess sq = new SQLAccess(DbConfig.GetConStr("MAINDB"));
            string qry = "select jm.j_id,jm.j_date,jm.j_narr,fas.s_desc,jd.j_drcr,jd.j_amount " +
                "from JournalMaster jm ,JournalDetail jd,FASubGroup fas where jm.j_id = '" + jid + "'" +
                "and jm.j_id = jd.j_id and jd.j_code = fas.s_code";
           DataSet ds= sq.Execute(qry);
           DataTable dt = ds.Tables[0];
           if (dt == null ||dt.Rows.Count == 0)
           {
               return null;
           }
           Journal j = new Journal();
           DataRow dr = dt.Rows[0];
           j.jid = dr["j_id"] as string;
           j.jdate = dr["j_date"].ToString();
           j.narration = dr["j_narr"].ToString();
           List<JournalEntry> je = new List<JournalEntry>();
           foreach (DataRow drs in dt.Rows)
           {
               JournalEntry js = new JournalEntry();
               js.jname = drs["s_desc"].ToString();
               js.drcr = drs["j_drcr"].ToString();
               js.amount = drs["j_amount"].ToString();
               je.Add(js);
           }

           j.rs = je;
           return j;
        }

        public static DataTable JournalEntryToDataTable(List<JournalEntry> je)
        {
            DataTable myDataTable = new DataTable();
            DataColumn myDataColumn;
            myDataColumn = new DataColumn();
            myDataColumn.DataType = System.Type.GetType("System.String");
            myDataColumn.ColumnName = "Account";
            myDataColumn.ReadOnly = false;
            myDataColumn.Unique = false;
            myDataTable.Columns.Add(myDataColumn);
            
            myDataColumn = new DataColumn();
            myDataColumn.DataType = System.Type.GetType("System.String");
            myDataColumn.ColumnName = "DRCR";
            myDataColumn.ReadOnly = false;
            myDataColumn.Unique = false;
            myDataTable.Columns.Add(myDataColumn);

            
            myDataColumn = new DataColumn();
            myDataColumn.DataType = System.Type.GetType("System.String");
            myDataColumn.ColumnName = "Amount";
            myDataColumn.ReadOnly = false;
            myDataColumn.Unique = false;
            myDataTable.Columns.Add(myDataColumn);

            foreach (JournalEntry js in je)
            {
                DataRow dr = myDataTable.NewRow();
                dr["Account"] = js.jname;
                dr["DRCR"] = js.drcr;
                dr["Amount"] = js.amount;
                myDataTable.Rows.Add(dr);
            }
            return myDataTable;
        }

        public static bool DeleteJournal(string jid)
        {
            TSQLAccess sq = new TSQLAccess(DbConfig.GetConStr("MAINDB"));
            sq.Open();
            try
            {
                string qry = "delete from JournalMaster where j_id ='" + jid + "'";
                sq.ExecuteNonQuery(qry);
                qry = "delete from JournalDetail where j_id ='" + jid + "'";
                sq.ExecuteNonQuery(qry);
                
                sq.Close();
                return true;
            }
            catch (Exception ex)
            {
                sq.Abort();
                return false;
            }
        }
    }
}


