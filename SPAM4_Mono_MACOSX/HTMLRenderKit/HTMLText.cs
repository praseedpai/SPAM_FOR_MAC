using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HTMLRenderKit
{
   public class CHTMLText : CHTMLObject
    {
        private string _text = null;
        private Boolean _bold = false;
        private Boolean _italic = false;
        private Boolean _underline = false;
        private Boolean _center = false;
        private Boolean _preformatted = false;


        ////// Default constructor
        public CHTMLText()
        {
        }

        //// Constructor with text value
        public CHTMLText(string value)
        {
            if (value != null)
            {
                _text = value;
            }
        }

        ///// Set the text value
        public void setText(string value)
        {
            if (value != null)
            {
                _text = value;
            }
        }

        ///// Get the text value
        public string getText()
        {
            return _text;
        }

        ///// Set the bold value
        public void setBold(Boolean value)
        {

            _bold = value;
        }

        ///// Get the bold value
        public Boolean getBold()
        {
            return _bold;
        }

        ///// Set the text italic
        public void setItalic(Boolean value)
        {

            _italic = value;
        }

        ///// returns true if italic is on
        public Boolean getItalic()
        {
            return _italic;
        }

        ///// Set the text underline
        public void setUnderline(Boolean value)
        {

            _underline = value;
        }

        ///// returns true if underline is on
        public Boolean getUnderline()
        {
            return _underline;
        }

        ///// Set the text preformatted
        public void setPreformatted(Boolean value)
        {

            _preformatted = value;
        }

        ///// returns true if preformatted is on
        public Boolean getPreformatted()
        {
            return _preformatted;
        }

        ///// Set the text center
        public void setCenter(Boolean value)
        {

           _center = value;
        }

        ///// returns true if center is on
        public Boolean getCenter()
        {
            return _center;
        }

        ///// Retrurn string containing the CHTML formatted text
        public override string toHTML()
        {
            StringBuilder CHTML = new StringBuilder(_text);

            if (getBold())
            {
                CHTML.Insert(0, "<B>");
                CHTML.Append("</B>");
            }

            if (getItalic())
            {
                CHTML.Insert(0, "<I>");
                CHTML.Append("</I>");
            }

            if (getUnderline())
            {
                CHTML.Insert(0, "<U>");
                CHTML.Append("</U>");
            }

            if (getPreformatted())
            {
                CHTML.Insert(0, "<PRE>");
                CHTML.Append("</PRE>");
            }

            if (getCenter())
            {
                CHTML.Insert(0, "<CENTER>");
                CHTML.Append("</CENTER>");
            }

            return CHTML.ToString();
        }
    }
}