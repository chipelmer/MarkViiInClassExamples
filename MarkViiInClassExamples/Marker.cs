using System;
using System.Collections.Generic;
using System.Text;

namespace MarkViiInClassExamples
{
    class Marker
    {
        public string Brand { get; set; }
        public bool CapIsOn { get; set; }

        private string _color;
        public string Color
        {
            get
            {
                return _color;
            }

            set
            {
                string newColor = value;
                newColor = newColor[0].ToString().ToUpper() + newColor.Substring(1).ToLower();
                _color = newColor;
            }
        }
    }
}
