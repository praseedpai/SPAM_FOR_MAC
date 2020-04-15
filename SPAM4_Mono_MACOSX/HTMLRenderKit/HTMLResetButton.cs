using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HTMLRenderKit
{
    public class CHTMLResetButton : CHTMLInput
    {
        /// <summary>
        /// Default Ctor
        /// </summary>
        public CHTMLResetButton()
        {
            setType("RESET");
        }
    }
}
