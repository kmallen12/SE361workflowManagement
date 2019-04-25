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
using System.IO;
using PdfSharp.Drawing;
using PdfSharp.Pdf;

namespace WorkFlowManagement
{
    public partial class StockReportForm : Form
    {
        HomePage home;
        DatabaseManager objDatabaseManager = new DatabaseManager();
        public StockReportForm(HomePage h)
        {
            home = h;
            InitializeComponent();
        }

        private void StockReportForm_Load(object sender, EventArgs e)
        {
           
            updateMaxLowDataViewer();
        }

        private void updateMaxLowDataViewer()
        {
            DataTable dataMax = objDatabaseManager.StockReportMax();
            dataGridViewMax.DataSource = dataMax;

            DataTable dataLow = objDatabaseManager.StockReportLow();
            dataGridViewLow.DataSource = dataLow;
        }

        private void btnChangeDefaults_Click(object sender, EventArgs e)
        {

            ItemCapacityForm ICF = new ItemCapacityForm();
            ICF.MdiParent=home;

            ICF.FormClosing += (sender2, args2) =>
            {
                updateMaxLowDataViewer();
                this.Show();
            };

            ICF.Leave += (sender3, args3) =>
            {
                home.MdiChildren.Last<Form>().Close();
            };

            this.Hide();
            ICF.Show();
        }


        private void btnExport_Click(object sender, EventArgs e)
        {
            PdfDocument document = new PdfDocument();
            document.Info.Title = "Stock Report";
            PdfPage page = document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont tnf1 = new XFont("Times New Roman", 20, XFontStyle.Bold);
            XFont tnf2 = new XFont("Times New Roman", 12);
            XFont header = new XFont("Times New Roman", 14, XFontStyle.Bold);
            XFont header2 = new XFont("Times New Roman", 16, XFontStyle.Bold);


            gfx.DrawString("Stock Report", tnf1, XBrushes.Black,
                new XRect(0, 0, page.Width, page.Height),
                XStringFormats.TopCenter);
            gfx.DrawLine(new XPen(XColors.Black, 3), 0, 30, page.Width, 30);

            gfx.DrawString("Stock Running Low", header2, XBrushes.Black,
                   new XRect(
                       75, 45, page.Width, page.Height),
                   XStringFormats.TopLeft);
            gfx.DrawLine(new XPen(XColors.Black, 2), 10, 67, page.Width / 2 - 40, 67);

            int startx = 0;

            gfx.DrawString("Material Type", header, XBrushes.Black,
                new XRect(startx += 20, 70, page.Width, page.Height),
                XStringFormats.TopLeft);

            gfx.DrawString("Quantity", header, XBrushes.Black,
                                new XRect(startx += 125, 70, page.Width, page.Height),
                                XStringFormats.TopLeft);

            gfx.DrawString("Limit", header, XBrushes.Black,
                new XRect(startx += 75, 70, page.Width, page.Height),
                XStringFormats.TopLeft);



            int starty = 90;

            foreach (DataGridViewRow row in dataGridViewLow.Rows)
            {
                startx = 0;
                starty += 15;
                gfx.DrawString(row.Cells[0].Value.ToString(), tnf2, XBrushes.Black,
                    new XRect(startx += 20, starty, page.Width, page.Height),
                    XStringFormats.TopLeft);

                gfx.DrawString(row.Cells[1].Value.ToString(), tnf2, XBrushes.Black,
                                    new XRect(startx += 125, starty, page.Width, page.Height),
                                    XStringFormats.TopLeft);

                gfx.DrawString(row.Cells[2].Value.ToString(), tnf2, XBrushes.Black,
                    new XRect(startx += 75, starty, page.Width, page.Height),
                    XStringFormats.TopLeft);

            }



            gfx.DrawString("Stock Reaching Max Capacity", header2, XBrushes.Black,
             new XRect(page.Width / 2 + 40, 45, page.Width, page.Height),
             XStringFormats.TopLeft);
            gfx.DrawLine(new XPen(XColors.Black, 2), page.Width / 2 + 10, 67, page.Width - 40, 67);

            startx = (int)page.Width / 2;

            gfx.DrawString("Material Type", header, XBrushes.Black,
                new XRect(startx += 20, 70, page.Width, page.Height),
                XStringFormats.TopLeft);

            gfx.DrawString("Quantity", header, XBrushes.Black,
                                new XRect(startx += 125, 70, page.Width, page.Height),
                                XStringFormats.TopLeft);

            gfx.DrawString("Limit", header, XBrushes.Black,
                new XRect(startx += 75, 70, page.Width, page.Height),
                XStringFormats.TopLeft);



            starty = 90;

            foreach (DataGridViewRow row in dataGridViewMax.Rows)
            {
                startx = (int)page.Width / 2;
                starty += 15;
                gfx.DrawString(row.Cells[0].Value.ToString(), tnf2, XBrushes.Black,
                    new XRect(startx += 20, starty, page.Width, page.Height),
                    XStringFormats.TopLeft);

                gfx.DrawString(row.Cells[1].Value.ToString(), tnf2, XBrushes.Black,
                                    new XRect(startx += 125, starty, page.Width, page.Height),
                                    XStringFormats.TopLeft);

                gfx.DrawString(row.Cells[2].Value.ToString(), tnf2, XBrushes.Black,
                    new XRect(startx += 75, starty, page.Width, page.Height),
                    XStringFormats.TopLeft);

            }

            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.DefaultExt = "pdf";
                sfd.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
                sfd.ShowDialog();
                Stream filename = sfd.OpenFile();
                document.Save(filename);
            }
            catch 
            {
                MessageBox.Show("Please enter an appropriate file name and save it to a suitable location.");
            }
            document.Close();
        }
    }
}