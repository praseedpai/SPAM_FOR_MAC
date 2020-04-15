using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HTMLRenderKit
{
     public class CHTMLLineBreak : CHTMLObject
    {
         /// <summary>
         /// Default ctor
         /// </summary>
         public CHTMLLineBreak()
         {
         }

         public override string toHTML()
         {
             return "<BR>";
         } 
    }
}
