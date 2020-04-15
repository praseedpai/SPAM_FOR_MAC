using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HTMLRenderKit
{
   public class CHTMLTableCell : CHTMLObject
    {
       private alignment _horizontal = alignment.LEFT;
       private alignment _vertical = alignment.MIDDLE;
       private alignment _type = alignment.DATA;
       private int _colspan = 1;

       /// <summary>
       /// Default Ctor
       /// </summary>
       public CHTMLTableCell()
       {
       }

       /// <summary>
       /// Ctor
       /// </summary>
       /// <param name="type"></param>
       public CHTMLTableCell( alignment type)
       {
           _type = type;
       }

       /// <summary>
       /// Set no of Columns
       /// </summary>
       /// <param name="value"></param>
       public void setColSpan(int value)
       {
           if (value > 0)
               _colspan = value;
       }

       /// <summary>
       /// Get columns
       /// </summary>
       /// <returns></returns>
       public int getColSpan()
       {
           return _colspan;
       }

       /// <summary>
       /// Set cell horizontal alignment
       /// </summary>
       /// <param name="value"></param>
       public void setHorizontalAlign(alignment value)
       {
           _horizontal = value;
       }

       /// <summary>
       /// Get horizontal alignment
       /// </summary>
       /// <returns></returns>
       public alignment getHorizontalAlign()
       {
           return _horizontal;
       }

       /// <summary>
       /// Set cell's vertical alignment
       /// </summary>
       /// <param name="value"></param>
       public void setVerticallAlign(alignment value)
       {
           if (value >= alignment.TOP && value <= alignment.BOTTOM)
           {
               _vertical = value;
           }
       }

       /// <summary>
       /// Get Vertical alignment
       /// </summary>
       /// <returns></returns>
       public alignment getVerticalAlign()
       {
           return _vertical;
       }

       public override string toHTML()
       {
           StringBuilder CHTML = new StringBuilder("");
           string tag = null;
           string valign = null;
           string align = null;

           switch (_vertical)
           {
               case alignment.TOP:
                   valign = "TOP";
                   break;
               case alignment.MIDDLE:
                   valign = "MIDDLE";
                   break;
               default:
                   valign = "BOTTOM";
                   break;
           }

           switch (_horizontal)
           {
               case alignment.LEFT:
                   align = "LEFT";
                   break;
               case alignment.CENTER:
                   align = "CENTER";
                   break;
               default:
                   align = "RIGHT";
                   break;
           }

           if (_type == alignment.DATA)
           {
               tag = "TD";
           }
           else
           {
               tag = "TH";
           }
           CHTML.Append("<" + tag + " VALIGN=" + valign + " ALIGN=" + align);
           CHTML.Append(" COLSPAN=" + _colspan + ">");

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
           CHTML.Append("</" + tag + ">");
           return CHTML.ToString();
       }
    }
}
