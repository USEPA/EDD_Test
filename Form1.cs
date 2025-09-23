
using PdfSharp.Pdf;
using PdfSharp.Pdf.Filters;
using PdfSharp.Pdf.IO;
using System.Drawing.Text;


namespace SecurityTest
{
    public partial class Form1 : Form
    { //s
        public Form1()
        {
            InitializeComponent();
            CombineIntoSinglePdf(null);
        }

        private void CombineIntoSinglePdf(string[] pdfFiles)
        {

            PdfDocument output = new PdfDocument();

            int count = 0;
           
            
            foreach (string file in pdfFiles)
            {
               
                }
                PdfDocument input = PdfReader.Open("", PdfDocumentOpenMode.Import);
                foreach (PdfPage page in input.Pages)
                {
                    output.AddPage(page);
                }
          
                Application.DoEvents();
            }
       
            
          
           
        }

    }
