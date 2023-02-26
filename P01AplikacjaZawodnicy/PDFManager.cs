using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01AplikacjaZawodnicy
{
    internal class PDFManager
    {
        private Zawodnik[] zawodnicy;

        public PDFManager(Zawodnik[] zawodnicy)
        {
            this.zawodnicy = zawodnicy;
        }

        public void StworzPdf(string sciezka)
        {
            // Create a new PDF document
            PdfDocument document = new PdfDocument();
            document.Info.Title = "Rarpot zawodnicy";

            // Create an empty page
            PdfPage page = document.AddPage();

            // Get an XGraphics object for drawing
            XGraphics gfx = XGraphics.FromPdfPage(page);

            // Create a font
            XFont font = new XFont("Verdana", 20, XFontStyle.BoldItalic);

            // Draw the text
            for (int i = 0; i < zawodnicy.Length; i++)
            {
                gfx.DrawString(zawodnicy[i].ImieNazwisko, font, XBrushes.Black,
                    50, 100 + 30 * i);
            }

            // Save the document...
          //  string filename = DateTime.Now.ToString("yyyyMMddmmss")+ "raport.pdf";
            document.Save(sciezka);
        }
    }
}
