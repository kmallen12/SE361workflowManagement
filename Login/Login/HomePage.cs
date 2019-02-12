using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WorkflowManagement
{
    public partial class HomePage : Form
    {
        public HomePage() 
        {
            InitializeComponent();
            //Set panels to correct initial visibility. 
            pnlStock.Visible = true;
            pnlProducts.Visible = false;
            pnlReports.Visible = false;
        }

        private void tabHome_Selected(object sender, TabControlEventArgs e)
        {
            //Changes the visibility of the pages. Using panels instead of included tabpages currently.
            if (tabHome.SelectedTab == tabHome.TabPages["tabStock"])//specific tabname
            {
                pnlStock.Visible = true;
                pnlProducts.Visible = false;
                pnlReports.Visible = false;
            }
            else if (tabHome.SelectedTab == tabHome.TabPages["tabProducts"])
            {
                pnlStock.Visible = false;
                pnlProducts.Visible = true;
                pnlReports.Visible = false;
            }
            else if (tabHome.SelectedTab == tabHome.TabPages["tabReports"])
            {
                pnlStock.Visible = false;
                pnlProducts.Visible = false;
                pnlReports.Visible = true;
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}