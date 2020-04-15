using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HTMLRenderKit
{
   public class CHTMLDocument :CHTMLObject
    {
        private string title = null;
        private string backgroundImage = null;
        private string _backgroundColor = null;
        private string textColor = null;
        private string linkColor = null;
        private string vlink = null;
        private string alink = null;


        
        /// ///// Constructor
        public CHTMLDocument()
        {
            
        }

        /// Constructor with Title
        public CHTMLDocument(string value)
        {
            if (value != null)
            {
                title = value;
            }
        }

        //// Set the document title
        public void setTitle(string value)
        {
            if (value != null)
            {
                title = value;
            }
        }

        //// Get the document title
        public string getTitle()
        {
            return title;
        }

        //// Set the document Background Image
        public void setBackgroundImage(string value)
        {
            if (value != null)
            {
                backgroundImage = value;
            }
        }

        //// Get the document Background Image
        public string getBackgroundImage()
        {
            return backgroundImage;
        }

        //// Set the document Background Color
        public override void setBackgroundColor(string value)
        {
            if (value != null)
            {
                _backgroundColor = value;
            }
        }

        //// Get the document Background Color
        public string getBackgroundColor()
        {
            return _backgroundColor;
        }

        //// Set the document Text Color
        public void setTextColor(string value)
        {
            if (value != null)
            {
                textColor = value;
            }
        }

        //// Get the document Text Color
        public string getTextColor()
        {
            return textColor;
        }

        //// Set the document Link Color
        public void setLinkColor(string value)
        {
            if (value != null)
            {
                linkColor = value;
            }
        }

        //// Get the document Link Color
        public string getLinkColor()
        {
            return linkColor;
        }

        //// Set the document Visited Link Color
        public void setVLinkColor(string value)
        {
            if (value != null)
            {
                vlink = value;
            }
        }

        //// Get the document Visited Link Color
        public string getVLinkColor()
        {
            return vlink;
        }

        //// Set the document Acitve Link Color
        public void setALinkColor(string value)
        {
            if (value != null)
            {
                alink = value;
            }
        }

        //// Get the document Active Link Color
        public string getALinkColor()
        {
            return alink;
        }


        public override string toHTML()
        {
            StringBuilder document = new StringBuilder("<HTML><head>\n");
            document.Append("<title>");
            if(title != null)
            {
                document.Append(title);
            }
            document.Append("</title></head>\n\n<body ");

             if(backgroundImage != null)
            {
                document.Append("BACKGROUND =\" " + backgroundImage +"\" ");
            }
             string color = getBackgroundColor();
             if (color != null)
             {
                 document.Append("BGCOLOR =\"" + color + "\"");
             }
             string textColor = getTextColor();
             if (textColor != null)
             {
                 document.Append("TEXT =\"" + textColor + "\"");
             }
             if (vlink != null)
             {
                 document.Append("VLINK =\"" + vlink + "\"");
             }
             if (linkColor != null)
             {
                 document.Append("LINK =\"" + linkColor + "\"");
             }
             if (alink != null)
             {
                 document.Append("ALINK =\"" + alink + "\"");
             }
             document.Append(">\n");

            ///// Iterate through all objects in CHTMLObjects
             for (int x = 0; x < CHTMLObjects.Count; x++)
             {
                 try
                 {
                     document.Append(((CHTMLObject)CHTMLObjects[x]).toHTML() + "\n");
                 }
                 catch (Exception ex)
                 {
                     Console.Error.WriteLine(ex.Message);
                 }
             }
            document.Append("\n</body>\n</HTML>\n");
            return document.ToString();
        }
    }
}
