using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Collections;
using DbLayer;
using ConfigLayer;

namespace InventoryLayer
{
    public class Transaction
    {
        public string type;
        public string invo;
        public string cr;
        public string refno;
        public string date;
        public string add;
        public decimal total;
        public decimal gtotal;
        public decimal discount;
        public decimal freight;
        public string cterms;

        public List<TransactionEntry> rs;

    }

    public class TransactionEntry
    {
       
        public string iname;
        public decimal qty;
        public string unit;
        public decimal rate;
        public decimal val;
        
    }


    public class TransactionPoster
    {
        public static DataTable JournalEntryToDataTable(List<TransactionEntry> je)
        {
            DataTable myDataTable = new DataTable();
            DataColumn myDataColumn;
            myDataColumn = new DataColumn();
            myDataColumn.DataType = System.Type.GetType("System.String");
            myDataColumn.ColumnName = "ItemName";
            myDataColumn.ReadOnly = false;
            myDataColumn.Unique = false;
            myDataTable.Columns.Add(myDataColumn);

            myDataColumn = new DataColumn();
            myDataColumn.DataType = System.Type.GetType("System.String");
            myDataColumn.ColumnName = "Quantity";
            myDataColumn.ReadOnly = false;
            myDataColumn.Unique = false;
            myDataTable.Columns.Add(myDataColumn);

            myDataColumn = new DataColumn();
            myDataColumn.DataType = System.Type.GetType("System.String");
            myDataColumn.ColumnName = "Unit";
            myDataColumn.ReadOnly = false;
            myDataColumn.Unique = false;
            myDataTable.Columns.Add(myDataColumn);

            myDataColumn = new DataColumn();
            myDataColumn.DataType = System.Type.GetType("System.String");
            myDataColumn.ColumnName = "Rate";
            myDataColumn.ReadOnly = false;
            myDataColumn.Unique = false;
            myDataTable.Columns.Add(myDataColumn);

            myDataColumn = new DataColumn();
            myDataColumn.DataType = System.Type.GetType("System.String");
            myDataColumn.ColumnName = "Value";
            myDataColumn.ReadOnly = false;
            myDataColumn.Unique = false;
            myDataTable.Columns.Add(myDataColumn);

            foreach (TransactionEntry js in je)
            {
                DataRow dr = myDataTable.NewRow();
                dr["itemname"] = js.iname;
                dr["qty"] = js.qty;
                dr["unit"] = js.unit;
                dr["rate"] = js.rate;
                dr["val"] = js.val;
                
                myDataTable.Rows.Add(dr);
            }

            return myDataTable;
        }

       public static bool DoPost(Transaction t)
        {

            SQLAccess sq = new SQLAccess(DbConfig.GetConStr("MAINDB"));
            
            try
            {
                string qry = "insert into TransactionMaster values('" + t.invo + "','" + t.cr + "','" + t.refno + "','" + DateTime.Now + "',"+
                "'"+t.add+"','"+t.type+"',"+t.total+","+t.gtotal+","+t.discount+","+t.freight+",'"+t.cterms+"')";
                sq.ExecuteNonQuery(qry);
                List<TransactionEntry> te = t.rs;
                foreach (TransactionEntry ts in te)
                {
                    qry = "insert into transactionDetail values('" + t.invo + "','" + ts.iname + "'," + ts.qty + ",'"+ts.unit+"'," + ts.rate + ","+ts.val+")";
                    sq.ExecuteNonQuery(qry);
                }
                
                return true;
            }
            catch (Exception ex)
            {
                
                return false;
            }
        }

    }
}