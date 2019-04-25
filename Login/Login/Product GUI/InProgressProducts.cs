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
    public partial class InProgressProducts : Form
    {
        private DatabaseManager objDatabaseManager;
        public InProgressProducts()
        {
            InitializeComponent();
            objDatabaseManager = new DatabaseManager();

            
            dataGridProductStatus.DataSource = objDatabaseManager.LoadDataInProgressProducts();
        }


        private void btnExport_Click(object sender, EventArgs e)
        {
            PdfDocument document = new PdfDocument();
            document.Info.Title = "Product Progress Report";
            PdfPage page = document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont tnf1 = new XFont("Times New Roman", 20, XFontStyle.Bold);
            XFont tnf2 = new XFont("Times New Roman", 12);
            XFont header = new XFont("Times New Roman", 14, XFontStyle.Bold);
            XFont header2 = new XFont("Times New Roman", 16, XFontStyle.Bold);


            gfx.DrawString("Product Progress Report", tnf1, XBrushes.Black,
                new XRect(0, 0, page.Width, page.Height),
                XStringFormats.TopCenter);
            gfx.DrawLine(new XPen(XColors.Black, 3), 0, 30, page.Width, 30);

            int startx = 0;

            gfx.DrawString("ID", header, XBrushes.Black,
                new XRect(startx += 20, 45, page.Width, page.Height),
                XStringFormats.TopLeft);

            gfx.DrawString("Product Name", header, XBrushes.Black,
                                new XRect(startx += 25, 45, page.Width, page.Height),
                                XStringFormats.TopLeft);

            gfx.DrawString("Material String", header, XBrushes.Black,
                new XRect(startx += 150, 45, page.Width, page.Height),
                XStringFormats.TopLeft);

            gfx.DrawString("Quantity", header, XBrushes.Black,
          new XRect(page.Width - 55, 45, page.Width, page.Height),
          XStringFormats.TopLeft);



            int starty = 90;

            foreach (DataGridViewRow row in dataGridProductStatus.Rows)
            {
                try
                {
                    startx = 0;
                    starty += 15;
                    gfx.DrawString(row.Cells[0].Value.ToString(), tnf2, XBrushes.Black,
                        new XRect(startx += 20, starty, page.Width, page.Height),
                        XStringFormats.TopLeft);

                    gfx.DrawString(row.Cells[1].Value.ToString(), tnf2, XBrushes.Black,
                                        new XRect(startx += 25, starty, page.Width, page.Height),
                                        XStringFormats.TopLeft);

                    if (row.Cells[2].Value.ToString().Length < 70)
                    {
                        gfx.DrawString(row.Cells[2].Value.ToString(), tnf2, XBrushes.Black,
                     new XRect(startx += 150, starty, page.Width, page.Height),
                     XStringFormats.TopLeft);


                    }
                    else
                    {
                        string shortened = row.Cells[2].Value.ToString().Substring(0, 65);
                        shortened += "  ....";

                        gfx.DrawString(shortened, tnf2, XBrushes.Black,
                     new XRect(startx += 150, starty, page.Width, page.Height),
                     XStringFormats.TopLeft);
                    }

                    gfx.DrawString(row.Cells[3].Value.ToString(), tnf2, XBrushes.Black,
                      new XRect(page.Width - 30, starty, page.Width, page.Height),
                      XStringFormats.TopLeft);

                }
                catch { }


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
