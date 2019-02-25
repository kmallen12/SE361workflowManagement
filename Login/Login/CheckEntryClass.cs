using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlowManagement
{
    class CheckEntry
    {
        public string text { get; set; }
        public string label { get; set; }

        public CheckEntry()
        {
            text = "";
            label = "";
        }

        public CheckEntry(string txt, string lbl)
        {
            text = txt;
            label = lbl;
        }

        // Checks to see if a string can be converted to a double & returns an error if it can't
        public Boolean isValidNumber()
        {
            try
            {
                double txt = double.Parse(text);
                return true;
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show(label + " must be a numeric value.");
                return false;
            }
        }

        //returns true if string variable is null
        public Boolean isNull()
        {
            if (text == "") { return true; }
            return false;
        }
    }
}
