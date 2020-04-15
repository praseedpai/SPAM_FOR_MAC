using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HTMLRenderKit
{
    public class CHTMLSubmitButton : CHTMLInput
    {
        /// <summary>
        /// Default Ctor
        /// </summary>
        public CHTMLSubmitButton()
        {
            setType("SUBMIT");
        }
    }
}
