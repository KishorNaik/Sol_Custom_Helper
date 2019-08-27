using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_Custom_Helper.Models
{
    public class ButtonModel
    {

        public enum ButtonType
        {
               Button=0,
               Submit=1
        };


        public String Id { get; set; }

        public ButtonType Type { get; set; }

        public String CssClassName { get; set; }

        public String Value { get; set; }
    }
}
