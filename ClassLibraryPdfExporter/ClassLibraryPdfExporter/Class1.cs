using System.IO;
using System.Reflection.Metadata;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextDocument = iTextSharp.text.Document;
namespace PdfExport//  just a little class to export data from program 

{
    public class PdfExporter
    {
        public void ExportDataToPdf(string filePath, string content)
        {
            using (FileStream stream = new FileStream(filePath, FileMode.Create))
            {
                iTextDocument pdfDoc = new iTextDocument(PageSize.A4, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(new Paragraph(content)); 
                pdfDoc.Close();
                stream.Close();
            }
        }

    }
}
