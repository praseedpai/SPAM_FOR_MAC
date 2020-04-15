using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ValidationLayer
{
    public class Validator
    {
        public static bool IsValidString(string x)
        {
            if (x == null)
            {
                return false;
            }
            string y = x.Trim();
            if (y == "")
            {
                return false;
            }
            return true;
        }

        public static bool IsValidNumber(string x)
        {
            if (x == null)
            {
                return false;
            }

            string y = x.Trim();
            if (y == "")
            {
                return false;
            }

            double r = 0;
            try
            {
                r = Convert.ToDouble(y);
                
            }
            catch (Exception e)
            {
                e.ToString();
                return false;
            }
            return true;
        }
    }
}
