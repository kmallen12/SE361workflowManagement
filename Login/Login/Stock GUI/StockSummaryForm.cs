using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using PdfSharp.Drawing;
using PdfSharp.Pdf;

namespace WorkFlowManagement
{
    public partial class StockSummaryForm : Form
    {
        private DataTable stocks;
        private DatabaseManager objDatabaseManager;
        HomePage Home;
        public StockSummaryForm(HomePage H)
        {
            InitializeComponent();
            Home = H;
            stocks = new DataTable();
            objDatabaseManager = new DatabaseManager();
        }

        private void StockSummaryForm_Load(object sender, EventArgs e)
        {
            stocks = objDatabaseManager.SumStocks();

            dataGridViewStockSum.DataSource = stocks;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnOpenDetails_Click(object sender, EventArgs e)
        {
            Home.MdiChildren.Last<Form>().Close();

            StockView form = new StockView();
            form.MdiParent = Home;
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            PdfDocument document = new PdfDocument();
            document.Info.Title = "Stock Summary Report";
            PdfPage page = document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont tnf1 = new XFont("Times New Roman", 20, XFontStyle.Bold);
            XFont tnf2 = new XFont("Times New Roman", 12);
            XFont header = new XFont("Times New Roman", 14, XFontStyle.Bold);
            XFont header2 = new XFont("Times New Roman", 16, XFontStyle.Bold);


            gfx.DrawString("Stock Summary Report", tnf1, XBrushes.Black,
                new XRect(0, 0, page.Width, page.Height),
                XStringFormats.TopCenter);
            gfx.DrawLine(new XPen(XColors.Black, 3), 0, 30, page.Width, 30);

            int startx = -55;
            gfx.DrawString("Material Type", header, XBrushes.Black,
                new XRect(startx, 70, page.Width, page.Height),
                XStringFormats.TopCenter);

            gfx.DrawString("Quantity", header, XBrushes.Black,
                                new XRect(startx += 130, 70, page.Width, page.Height),
                                XStringFormats.TopCenter);



            int starty = 90;

            foreach (DataGridViewRow row in dataGridViewStockSum.Rows)
            {
                try { row.Cells[0].Value.ToString();
                    startx = -50;
                    starty += 15;
                    gfx.DrawString(row.Cells[0].Value.ToString(), tnf2, XBrushes.Black,
                        new XRect(startx, starty, page.Width, page.Height),
                        XStringFormats.TopCenter);

                    gfx.DrawString(row.Cells[1].Value.ToString(), tnf2, XBrushes.Black,
                                        new XRect(startx += 125, starty, page.Width, page.Height),
                                        XStringFormats.TopCenter);
                }
                catch
                {
                  


                }
              

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
            catch (Exception ex)
            {
                MessageBox.Show("Please enter an appropriate file name and save it to a suitable location.");
            }


        }
    }
}
