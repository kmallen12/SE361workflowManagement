using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using PdfSharp.Drawing;
using PdfSharp.Pdf;

namespace WorkFlowManagement
{
    public partial class ViewQualifiedProducts : Form
    {
        private List<ProductStruct> qualProducts;
        private DatabaseManager objDatabaseManager;
        private ToolTip ttExport = new ToolTip();
        public ViewQualifiedProducts()
        {
            InitializeComponent();
            qualProducts = new List<ProductStruct>();
            objDatabaseManager = new DatabaseManager();

            qualProducts = objDatabaseManager.LoadQualifiedProducts();

            foreach (var prod in qualProducts)
            {
                lstQualProd.Items.Add(prod.ToString());
            }

            ttExport.SetToolTip(btnExport, "Export as pdfs coming soon  :D");
        }

        private void btnRepRemanufacture_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Selected Item has been sent to Delivery Manager");
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            PdfDocument document = new PdfDocument();
            document.Info.Title = "Qualified Products";
            PdfPage page = document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont tnf1 = new XFont("Times New Roman", 20, XFontStyle.Bold);
            XFont tnf2 = new XFont("Times New Roman", 12);

            gfx.DrawString("Qualified Products Report", tnf1, XBrushes.Black,
                new XRect(0, 0, page.Width, page.Height),
                XStringFormats.TopCenter);
            gfx.DrawLine(new XPen(XColors.Black, 3), 0, 30, page.Width, 30);

            int starty = 20;
            foreach (var item in lstQualProd.Items)
                gfx.DrawString(item.ToString(), tnf2, XBrushes.Black,
                    new XRect(0, starty += 15, page.Width, page.Height),
                    XStringFormats.TopLeft);

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
