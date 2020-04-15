using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HTMLRenderKit
{
    public class CHTMLImage : CHTMLObject
    {
        private string _image = null;
        private string _text = null;

        /// <summary>
        /// Default ctor
        /// </summary>
        public CHTMLImage()
        {

        }

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="image"></param>
        /// <param name="text"></param>
        public CHTMLImage(string image, string text)
        {
            if (image != null)
            {
                _image = image;
            }
            if (text != null)
            {
                _text = text;
            }
        }

        /// <summary>
        /// Set image location
        /// </summary>
        /// <param name="value"></param>
        public void setImage(string value)
        {
            if (value != null)
            {
                _image = value;
            }
        }

        /// <summary>
        /// Get image location
        /// </summary>
        /// <returns></returns>
        public string getImage()
        {
            return _image;
        }

        /// <summary>
        /// Set alternate text
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
        /// Get text
        /// </summary>
        /// <returns></returns>
        public string getText()
        {
            return _text;
        }

        public override string toHTML()
        {
            StringBuilder CHTML = new StringBuilder("<img src=\"");
            if (_image != null)
            {
                CHTML.Append(_image);
            }
            CHTML.Append("\"alt=\"");
            if (_text != null)
            {
                CHTML.Append(_text);
            }
            CHTML.Append("\">");

            return CHTML.ToString();
        }

    }
}
