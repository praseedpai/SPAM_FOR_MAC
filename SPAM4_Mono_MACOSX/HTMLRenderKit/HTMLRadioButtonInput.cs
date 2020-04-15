using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HTMLRenderKit
{
    public class CHTMLRadioButtonInput : CHTMLInput
    {
        private Boolean _checked = false;

        /// <summary>
        /// Default Ctor
        /// </summary>
        public CHTMLRadioButtonInput()
        {
            setType("RADIO");
        }

        /// <summary>
        /// Set checked true or false
        /// </summary>
        /// <param name="value"></param>
        public void setChecked(Boolean value)
        {
            _checked = value;
        }

        public Boolean isChecked()
        {
            return _checked;
        }

        public override string toHTML()
        {
            if (_checked)
            {
                setAttributes("CHECKED");
            }
            return base.toHTML();
        }
    }
}
