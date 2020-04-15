using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HTMLRenderKit
{
   public class CHTMLTable : CHTMLObject
    {
       private CHTMLObject _caption = null;
       private int _width = 0;
       private int _border = 0;
       private int _cellspacing = 0;
       private int _cellpadding = 0;
       private Boolean _percentagewidth = true;

       /// <summary>
       /// Default Ctor
       /// </summary>
       public CHTMLTable()
       {
       }

       /// <summary>
       /// Set caption
       /// </summary>
       /// <param name="value"></param>
       public void setCaption(CHTMLObject value)
       {
           if (value != null)
           {
               _caption = value;
           }
       }

       /// <summary>
       /// Get caption
       /// </summary>
       /// <returns></returns>
       public CHTMLObject getCaption()
       {
           return _caption;
       }


       /// <summary>
       /// Set border
       /// </summary>
       /// <param name="value"></param>
       public void setBorder(int value)
       {
           if (value > -1)
           {
               _border = value;
           }
       }

       /// <summary>
       /// Get border
       /// </summary>
       /// <returns></returns>
       public int getBorder()
       {
           return _border;
       }

       /// <summary>
       /// Set cell spacing
       /// </summary>
       /// <param name="value"></param>
       public void setCellSpacing(int value)
       {
           if (value >= 0)
           {
               _cellspacing = value;
           }
       }

       /// <summary>
       /// Get cell spacing
       /// </summary>
       /// <returns></returns>
       public int getCellSpacing()
       {
           return _cellspacing;
       }

       /// <summary>
       /// Set cell padding
       /// </summary>
       /// <param name="value"></param>
       public void setCellPadding(int value)
       {
           if (value >= 0)
           {
              _cellpadding = value;
           }
       }

       /// <summary>
       /// Get cell padding
       /// </summary>
       /// <returns></returns>
       public int getCellPadding()
       {
           return _cellpadding;
       }

       /// <summary>
       /// Set table width as percentage
       /// </summary>
       /// <param name="value"></param>
       public void setWidth(int value)
       {
           _width = value;
           _percentagewidth = true;
       }

       /// <summary>
       /// Set table width in pixels
       /// </summary>
       /// <param name="value"></param>
       public void setWidthByPixel(int value)
       {
           _width = value;
           _percentagewidth = false;
       }

       public int getWidth()
       {
           return _width;
       }
       public override string toHTML()
       {
           StringBuilder CHTML = new StringBuilder("<TABLE ");

           if (_width > 0)
           {
               CHTML.Append(" WIDTH=" + _width);
               if (_percentagewidth)
               {
                   CHTML.Append("% ");
               }
               else
               {
                   CHTML.Append(" ");
               }
           }

           if (_border > -1)
           {
               CHTML.Append(" BORDER=" + _border);
           }

           if (_cellspacing > -1)
           {
               CHTML.Append(" CELLSPACING=" + _cellspacing);
           }

           if (_cellpadding > -1)
           {
               CHTML.Append(" CELLSPACING=" + _cellpadding);
           }

           string color = getBackGroundColor();
           if (color != null)
           {
               CHTML.Append(" BGCOLOR=\"" + color + "\" ");
           }
           CHTML.Append(">\n");

           if (_caption != null)
           {
               CHTML.Append("\n<CAPTION>" + _caption.toHTML()+" </CAPTION>\n");
           }

           for (int x = 0; x < CHTMLObjects.Count; x++)
           {
               try
               {
                   CHTML.Append(((CHTMLObject)CHTMLObjects[x]).toHTML()+"\n");
               }
               catch (Exception ex)
               {
                   Console.Error.WriteLine(ex.Message);
               }
           }
           CHTML.Append("\n</TABLE>");

           return CHTML.ToString();
       }
    }
}
