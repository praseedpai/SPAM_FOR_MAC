using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HTMLRenderKit
{
   public class CHTMLLink : CHTMLObject
    {

       private string _href = null;

       /// <summary>
       /// Ctor
       /// </summary>
       public CHTMLLink()
       {
       }

       /// <summary>
       /// Ctor
       /// </summary>
       /// <param name="href"></param>
       /// <param name="obj"></param>
       public CHTMLLink(string href, CHTMLObject obj)
       {
           if (href != null)
           {
               _href = href;
           }

           if (obj != null)
           {
               addObject(obj);
           }
       }

       /// <summary>
       /// Set Href
       /// </summary>
       /// <param name="value"></param>
       public void setHREF(string value)
       {
           if (value != null)
           {
               _href = value;
           }
       }

       /// <summary>
       /// Get Href
       /// </summary>
       /// <returns></returns>
       public string getHREF()
       {
           return _href;
       }

       public override string toHTML()
       {
           StringBuilder CHTML = new StringBuilder("<a href=\"");

           if (_href == null)
           {
               Console.Error.WriteLine("HREF ia an empty string");
           }
           else
           {
               CHTML.Append(_href + "\">");
           }

           for (int x = 0; x < CHTMLObjects.Count; x++)
           {
               try
               {
                   CHTML.Append(((CHTMLObject)CHTMLObjects[x]).toHTML() + "\n");
               }
               catch (Exception ex)
               {
                   Console.Error.WriteLine(ex.Message);
               }
           }
           CHTML.Append("</a>");

           return CHTML.ToString();
       }
    }
}
