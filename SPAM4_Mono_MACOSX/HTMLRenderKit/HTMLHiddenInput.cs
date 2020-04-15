using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HTMLRenderKit
{
   public class CHTMLHiddenInput : CHTMLInput
    {
       /// <summary>
       /// Default Ctor
       /// </summary>
       public CHTMLHiddenInput()
       {
           setType("HIDDEN");
       }
    }
}
