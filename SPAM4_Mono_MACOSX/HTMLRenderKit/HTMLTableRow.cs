using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HTMLRenderKit
{
   public class CHTMLTableRow : CHTMLObject
    {
       /// <summary>
       /// Default Ctor
       /// </summary>
       public CHTMLTableRow()
       {
       }

       public override string toHTML()
       {

           StringBuilder CHTML = new StringBuilder("<TR>");

           for (int x = 0; x < CHTMLObjects.Count; x++)
           {
               try
               {
                   CHTML.Append(((CHTMLObject)CHTMLObjects[x]).toHTML());
               }
               catch (Exception ex)
               {
                   Console.Error.WriteLine(ex.Message);
               }
           }
           CHTML.Append("</TR>\n");

           return CHTML.ToString();
       }
    }
}
