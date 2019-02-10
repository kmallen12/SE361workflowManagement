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
    public partial class StockReportForm : Form
    {
        public StockReportForm()
        {
            InitializeComponent();
        }

        //all materials on hand - aggregates by material type
        public double totalQuantity()
        {
            return 0;
        }

        //average cost by material type
        public double averageCost()
        {
            return 0;
        }

        //average time to use
        public TimeSpan avgIdleTime()
        {
            return new TimeSpan();
        }

        private void StockReportForm_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "tcp:workflowdatabase.database.windows.net,1433";
            builder.UserID = "OCOTOD";
            builder.Password = "FairBanks152";
            builder.InitialCatalog = "WorkFlowDatabase";


            SqlConnection con = new SqlConnection(builder.ConnectionString);
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = con;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT ST.itemID , ST.quantity FROM StockTable AS ST, WareHouseTable AS WHT WHERE ST.itemID = WHT.itemID AND ST.quantity >= WHT.Max";
            SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

            DataTable dtRecord = new DataTable();
            sqlDataAdap.Fill(dtRecord);
            dataGridViewMax.DataSource = dtRecord;

            SqlConnection con2 = new SqlConnection(builder.ConnectionString);
            SqlCommand sqlCmd2 = new SqlCommand();
            sqlCmd.Connection = con;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT ST.itemID , ST.quantity FROM StockTable AS ST, WareHouseTable AS WHT WHERE ST.itemID = WHT.itemID AND ST.quantity <= WHT.Low";
            SqlDataAdapter sqlDataAdap2 = new SqlDataAdapter(sqlCmd);

            DataTable dtRecord2 = new DataTable();
            sqlDataAdap.Fill(dtRecord2);
            dataGridViewLow.DataSource = dtRecord2;

        }

        private void linklblChangeItem_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ItemCapacityForm ICF = new ItemCapacityForm();


            ICF.FormClosing += (sender2, args2) =>
            {

                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "tcp:workflowdatabase.database.windows.net,1433";
                builder.UserID = "OCOTOD";
                builder.Password = "FairBanks152";
                builder.InitialCatalog = "WorkFlowDatabase";


                SqlConnection con = new SqlConnection(builder.ConnectionString);
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = con;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "SELECT ST.itemID , ST.quantity FROM StockTable AS ST, WareHouseTable AS WHT WHERE ST.itemID = WHT.itemID AND ST.quantity >= WHT.Max";
                SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

                DataTable dtRecord = new DataTable();
                sqlDataAdap.Fill(dtRecord);
                dataGridViewMax.DataSource = dtRecord;

                SqlConnection con2 = new SqlConnection(builder.ConnectionString);
                SqlCommand sqlCmd2 = new SqlCommand();
                sqlCmd.Connection = con;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "SELECT ST.itemID , ST.quantity FROM StockTable AS ST, WareHouseTable AS WHT WHERE ST.itemID = WHT.itemID AND ST.quantity <= WHT.Low";
                SqlDataAdapter sqlDataAdap2 = new SqlDataAdapter(sqlCmd);

                DataTable dtRecord2 = new DataTable();
                sqlDataAdap.Fill(dtRecord2);
                dataGridViewLow.DataSource = dtRecord2;
            };


            ICF.Show();


        }

    }
}