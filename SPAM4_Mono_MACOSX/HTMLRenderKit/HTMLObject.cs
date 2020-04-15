using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;


namespace HTMLRenderKit
{
    

    public abstract class CHTMLObject
    {
        protected ArrayList CHTMLObjects = null;
        private alignment align = alignment.LEFT;

        public abstract string toHTML();
        public string backgroundColor = null;

        /// Constructor
        public CHTMLObject()
        {
            CHTMLObjects = new ArrayList(5);

        }

        /// Add an CHTMLObject
        public void addObject(CHTMLObject value)
        {
            if (value != null)
            {
                CHTMLObjects.Add(value);
            }
        }

        /// Remove an CHTMLObject
        public Boolean removeObject(CHTMLObject value)
        {
            if (value != null)
            {
                 CHTMLObjects.Remove(value);
                 return true;
            }
            return false;
        }


        /// Set objects background color
        public virtual void setBackgroundColor(string value)
        {
            if (value != null)
            {
                backgroundColor = value;
            }
        }

        /// Get the objects background color
         public virtual string getBackGroundColor()
        {
            return backgroundColor;
        }

        //// Set Objects Alignment
         public  void setAlignment(alignment value)
         {
             if (value >= alignment.LEFT && 
                 value <= alignment.RIGHT)
             {
                 align = value;
             }
         }

        /// Get objects alignment
         public alignment getAlignment()
         {
             return align;
         }


       
    }
}
