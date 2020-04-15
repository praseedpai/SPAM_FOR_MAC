using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HTMLRenderKit
{
    public class CHTMLTextInput : CHTMLInput
    {
        private int _size = -1;
        private int _maxlength = -1;


        /// <summary>
        /// Default Ctor
        /// </summary>
        public CHTMLTextInput()
        {
            setType("TEXT");
        }

        /// <summary>
        /// Set input size
        /// </summary>
        /// <param name="value"></param>
        public void setSize(int value)
        {
            if (value > -1)
            {
                _size = value;
            }
        }

        /// <summary>
        /// Get input size
        /// </summary>
        /// <returns></returns>
        public int getSize()
        {
            return _size;
        }

        /// <summary>
        /// Set input maximum length
        /// </summary>
        /// <param name="value"></param>
        public void setMaxLength(int value)
        {
            if (value > -1)
            {
                _maxlength = value;
            }
        }

        /// <summary>
        /// Get input maximum length
        /// </summary>
        /// <returns></returns>
        public int getMaxLength()
        {
            return _maxlength;
        }

        public override string toHTML()
        {
            StringBuilder attribute = new StringBuilder("");

            if (_size > -1)
            {
                attribute.Append(" SIZE=" + _size);
            }

            if (_maxlength > -1)
            {
                attribute.Append(" MAXLENGTH=" + _maxlength);
            }

            setAttributes(attribute.ToString());
            return base.toHTML();
        }
    }
}
