using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using PdfSharp.Drawing;
using PdfSharp.Pdf;

namespace WorkFlowManagement
{
    public partial class RemanufactureForm : Form
    {
        private DatabaseManager objDatabaseManager;
        private ToolTip ttExport = new ToolTip();
        Product P;
        HomePage Home;
        ProductStruct PS;
        public RemanufactureForm(HomePage H)
        {
            Home = H;
            InitializeComponent();
            
            P = new Product();
            objDatabaseManager = new DatabaseManager();
            Home = H;
            

            lstDefProd.DataSource = P.LoadDefectives();

            ttExport.SetToolTip(btnExport, "Export as pdfs coming soon  :D");
        }

        //add selected item to Remanufacture list
        private void btnRepRemanufacture_Click(object sender, EventArgs e)
        {
            AddProduct newProduct = new AddProduct();
            newProduct.MdiParent = Home;
            newProduct.SetTXTBoxs(PS.ProductID.ToString(), 1.ToString());

            newProduct.FormClosing += (sender2, args2) =>
            {
                this.Show();
            };

            newProduct.Leave += (sender3, args3) =>
            {
                Home.MdiChildren.Last<Form>().Close();
            };

            this.Hide();
            newProduct.Show();
            
            
        }

        private void lstDefProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lstDefProd.SelectedIndex >= 0)
                {
                    PS = (ProductStruct)lstDefProd.SelectedItem;                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning");
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            PdfDocument document = new PdfDocument();
            document.Info.Title = "Defective Products";
            PdfPage page = document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont tnf1 = new XFont("Times New Roman", 20, XFontStyle.Bold);
            XFont tnf2 = new XFont("Times New Roman", 12);

            gfx.DrawString("Defective Products Report", tnf1, XBrushes.Black,
                new XRect(0, 0, page.Width, page.Height),
                XStringFormats.TopCenter);
            gfx.DrawLine(new XPen(XColors.Black, 3), 0,30, page.Width, 30 );

            int starty = 20;
            foreach (var item in lstDefProd.Items)
            gfx.DrawString(item.ToString(), tnf2, XBrushes.Black, 
                new XRect(0, starty+=15, page.Width, page.Height), 
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
