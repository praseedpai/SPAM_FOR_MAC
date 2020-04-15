using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HTMLRenderKit
{
    public class CHTMLForm : CHTMLObject
    {
        private string _action = null;
        private Boolean _postmethod = false;

        /// <summary>
        /// Default Ctor
        /// </summary>
        public CHTMLForm()
        {
        }

        /// <summary>
        /// Set action
        /// </summary>
        /// <param name="value"></param>
        public void setAction(string value)
        {
            if (value != null)
            {
                _action = value;
            }
        }

        /// <summary>
        /// Get action
        /// </summary>
        /// <returns></returns>
        public string getAction()
        {
            return _action;
        }

        /// <summary>
        /// Set post method to true or false
        /// </summary>
        /// <param name="value"></param>
        public void setPostMethod(Boolean value)
        {
            _postmethod = value;
            
        }

        /// <summary>
        /// return true if post
        /// </summary>
        /// <returns></returns>
        public Boolean getPostMethod()
        {
            return _postmethod;
        }

        public override string toHTML()
        {
            StringBuilder CHTML = new StringBuilder("<FORM ACTION=\"");

            if (_action != null)
            {
                CHTML.Append(_action);
            }
            CHTML.Append("\"");

            /// Set up method
            CHTML.Append(" METHOD=");

            if (_postmethod)
            {
                CHTML.Append("POST");
            }
            else
            {
                CHTML.Append("GET");
            }

            string color = getBackGroundColor();
            if (color != null)
            {
                CHTML.Append(" BGCOLOR=\"" + color + "\"");
            }
            CHTML.Append(">\n");

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
            CHTML.Append("\n</FORM>");

            if (getAlignment() == alignment.CENTER)
            {
                CHTML.Insert(0, "<CENTER>");
                CHTML.Append("</CENTER>");
            }

            return CHTML.ToString();
        }
    }
}
