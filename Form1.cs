
using PdfSharp.Pdf;
using PdfSharp.Pdf.Filters;
using PdfSharp.Pdf.IO;
using System.Drawing.Text;


namespace SecurityTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CombineIntoSinglePdf(null);
        }

        private void CombineIntoSinglePdf(string[] pdfFiles)
        {

            // if only one PDF file exisits in this folder exist and show error message 


            //All combined pdfs are kept in memory untill output.save() is called.
            PdfDocument output = new PdfDocument();

            int count = 0;
           
            const int MB = 1024 * 1024;

            foreach (string file in pdfFiles)
            {
           
                    //clean the RAM
                    output.Close();
                    output = null;
                    GC.Collect();

               
                    //Log("Combing canceled by user");
                  //  return null;
                }
                PdfDocument input = PdfReader.Open("", PdfDocumentOpenMode.Import);
                foreach (PdfPage page in input.Pages)
                {
                    output.AddPage(page);
                }
                input.Close();

                count++;
             
                Application.DoEvents();
            }
       
            
            //Log($"Single PDF created: {outputPath}");
           
        }

    }
