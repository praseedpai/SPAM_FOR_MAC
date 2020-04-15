using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HTMLRenderKit
{
   public class CHTMLInput : CHTMLObject
    {
       protected string _type = null;
       protected string _name = null;
       protected string _input = null;
       protected string _attributes = null;

       /// <summary>
       /// Default Ctor
       /// </summary>
       public CHTMLInput()
       {
       }

       /// <summary>
       /// Set input type
       /// </summary>
       /// <param name="value"></param>
       protected void setType(string value)
       {
           if (value != null)
           {
               _type = value;
           }
       }

       /// <summary>
       /// Get type
       /// </summary>
       /// <returns></returns>
       public string getType()
       {
           return _type;
       }

       /// <summary>
       /// Set input name
       /// </summary>
       /// <param name="value"></param>
       protected void setName(string value)
       {
           if (value != null)
           {
               _name = value;
           }
       }

       /// <summary>
       /// Get name
       /// </summary>
       /// <returns></returns>
       public string getName()
       {
           return _name;
       }

       /// <summary>
       /// Set value of input object
       /// </summary>
       /// <param name="value"></param>
       protected void setValue(string value)
       {
           if (value != null)
           {
               _input = value;
           }
       }

       /// <summary>
       /// Get value
       /// </summary>
       /// <returns></returns>
       public string getValue()
       {
           return _input;
       }
       /// <summary>
       /// Set attributes
       /// </summary>
       /// <param name="value"></param>
       protected void setAttributes(string value)
       {
           if (value != null)
           {
               _attributes = value;
           }
       }

       /// <summary>
       /// Get attributes
       /// </summary>
       /// <returns></returns>
       public string getAttributes()
       {
           return _attributes;
       }

       public override string toHTML()
       {
           StringBuilder CHTML = new StringBuilder("<INPUT TYPE=\"");

           if(_type != null)
           {
               CHTML.Append(_type);
           }
           CHTML.Append("\" NAME=\"");

           if(_name != null)
           {
               CHTML.Append(_name);
           }
           CHTML.Append("\" ");

           if(_input != null)
           {
               CHTML.Append(" VALUE=\""+_input+"\"");
           }
           if(_attributes != null)
           {
               CHTML.Append(_attributes);
           }
           CHTML.Append(">");

           return CHTML.ToString();

       }
    }
}
