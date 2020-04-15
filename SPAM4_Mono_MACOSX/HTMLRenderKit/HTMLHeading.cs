using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HTMLRenderKit
{
    public class CHTMLHeading : CHTMLObject
    {
        private string _text = null;
        private heading _heading = heading.H1;

       /// <summary>
       /// default ctor
       /// </summary>
        public CHTMLHeading()
        {
        }

        /// <summary>
        ///  ctor 
        /// </summary>
        /// <param name="txt"></param>
        /// <param name="head"></param>
        public CHTMLHeading(string txt,heading head)
        {
            if (txt != null)
            {
                _text = txt;
            }

            if (head >= heading.H1 && head <= heading.H6)
            {
                _heading = head;
            }
        }

        /// <summary>
        /// set Heading text
        /// </summary>
        /// <param name="value"></param>
        public void setText(string value)
        {
            if (value != null)
            {
                _text = value;
            }
        }

        /// <summary>
        /// Get Heading text
        /// </summary>
        /// <returns></returns>
        public string getText()
        {
            return _text;
        }

        /// <summary>
        /// set Heading level
        /// </summary>
        /// <param name="value"></param>
        public void setHeadingLevel(heading value)
        {
            if (value >= heading.H1 && value <= heading.H6)
            {
                _heading = value;
            }
        }

        public heading getHeadingLevel()
        {
            return _heading;
        }


        public override string toHTML()
        {
            StringBuilder CHTML = new StringBuilder("<H" + _heading.ToString().Trim() );

            switch (getAlignment())
            {
                case alignment.CENTER:
                    CHTML.Append(" ALIGN = \"CENTER\"");
                    break;
                case alignment.LEFT:
                    CHTML.Append(" ALIGN = \"LEFT\"");
                    break;
                case alignment.RIGHT:
                    CHTML.Append(" ALIGN = \"RIGHT\"");
                    break;
            }
            CHTML.Append(">");
            if (_text != null)
            {
                CHTML.Append(_text);
            }
            CHTML.Append("</H" + _heading + ">");

            return CHTML.ToString();
        } 
     }
}
