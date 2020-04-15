using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ConfigLayer
{
    public class DbConfig
    {
        private static Hashtable _hash = null;

        static DbConfig()
        {
            _hash = new Hashtable();
         //   string con_str = @"Data Source=SAP-PC\SQLEXPRESS;Initial Catalog=FA;Integrated Security=True";
            string con_str = @"URI=file:FA.db";

            Add("MAINDB", con_str);

        }

        private static void Add(string symbolname, string connstr)
        {
            _hash.Add(symbolname, connstr);
        }

        public static string GetConStr(string key)
        {
            return (string)_hash[key];
        }

    }
}
