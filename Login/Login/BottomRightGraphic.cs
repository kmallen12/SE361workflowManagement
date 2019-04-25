using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkFlowManagement
{
    public partial class BottomRightGraphic : Form
    {
        HomePage Home;
        public BottomRightGraphic()
        {
            InitializeComponent();
        }
        public BottomRightGraphic(HomePage H)
        {
            InitializeComponent();

            Home = H;
            this.MdiParent = Home;
            //So we dont delete the tabs on the first form opened.
            Form Dummy = new Form();
            Dummy.MdiParent = Home;
            //this.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
        }
    }
}
