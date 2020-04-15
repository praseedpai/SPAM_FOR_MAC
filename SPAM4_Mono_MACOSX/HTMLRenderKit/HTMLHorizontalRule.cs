using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HTMLRenderKit
{
    public class CHTMLHorizontalRule : CHTMLObject
    {
        /// <summary>
        /// Default ctor
        /// </summary>
        public CHTMLHorizontalRule()
        {
        }

        public override string toHTML()
        {
            return "<HR>";
        }
    }
}
