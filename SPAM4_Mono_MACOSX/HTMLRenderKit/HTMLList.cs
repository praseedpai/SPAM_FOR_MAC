using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HTMLRenderKit
{
    public class CHTMLList : CHTMLObject
    {
        private listType _listType = listType.UL;

        /// <summary>
        /// Default Ctor
        /// </summary>
        public CHTMLList()
        {
        }

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="value"></param>
        public CHTMLList( listType value)
        {
            _listType = listType.UL;

            if (value >= listType.UL && value <= listType.DIR)
            {
                _listType = value;
            }
        }

        /// <summary>
        /// Set Listtype
        /// </summary>
        /// <param name="value"></param>
        public void setListType(listType value)
        {
            if (value >= listType.UL && value <= listType.DIR)
            {
                _listType = value;
            }
        }

        /// <summary>
        /// Get list type
        /// </summary>
        /// <returns></returns>
        public listType getListType()
        {
            return _listType;
        }

        public override string toHTML()
        {
            StringBuilder CHTML = new StringBuilder("\n");

            for (int x = 0; x < CHTMLObjects.Count; x++)
            {
                try
                {
                    CHTML.Append("<LI>" + ((CHTMLObject)CHTMLObjects[x]).toHTML() + "\n");
                }
                catch (Exception ex)
                {
                    Console.Error.WriteLine(ex.Message);
                }

                
            }

            if (_listType == listType.UL)
            {
                CHTML.Insert(0, "<UL>");
                CHTML.Append("</UL>");
            }
            else if (_listType == listType.OL)
            {
                CHTML.Insert(0, "<OL>");
                CHTML.Append("</OL>");
            }
            else if (_listType == listType.MENU)
            {
                CHTML.Insert(0, "<MENU>");
                CHTML.Append("</MENU>");
            }
            else
            {
                CHTML.Insert(0, "<DIR>");
                CHTML.Append("</DIR>");
            }

            return CHTML.ToString();
        }
    }
}
