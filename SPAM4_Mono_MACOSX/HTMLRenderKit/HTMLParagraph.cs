using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HTMLRenderKit
{
   public class CHTMLParagraph : CHTMLObject
    {
       /// <summary>
       /// Default ctor
       /// </summary>
       public CHTMLParagraph()
       {
       }

       public override string toHTML()
       {
           return "<P>";
       }
    }
}
