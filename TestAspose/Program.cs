using Aspose.Words;
using System;
using System.IO;

namespace TestAspose
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Read first file
            var _ = Path.DirectorySeparatorChar.ToString();
            var firstFilePath = $"{Directory.GetCurrentDirectory()}{_}Documents{_}edlinger.docx";

            // 2. Create PDF from word document
            var firstDoc = new Document(firstFilePath);
            var firstFilePdfPath = $"{Directory.GetCurrentDirectory()}{_}Documents{_}edlinger.pdf";
            firstDoc.Save(firstFilePdfPath, SaveFormat.Pdf);

            // 3. Read created PDF file
            var firstDocPdf = new Aspose.Pdf.Document(firstFilePdfPath);

            // 4. Read second PDF file
            //var secondFilePdfPath = $"{Directory.GetCurrentDirectory()}{_}Documents{_}Annexe_simple.pdf";
            //var secondDocPdf = new Aspose.Pdf.Document(secondFilePdfPath);

            // 5. Concatenate files
            //firstDocPdf.Pages.Add(secondDocPdf.Pages);

            // 6. Convert merged document to base 64 string
            string base64FileToSign;
            using (var outStream = new MemoryStream())
            {
                firstDocPdf.Save(outStream, Aspose.Pdf.SaveFormat.Pdf);
                base64FileToSign = Convert.ToBase64String(outStream.ToArray());
            }

            Console.WriteLine("Success");
        }
    }
}