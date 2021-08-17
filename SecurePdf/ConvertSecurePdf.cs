using Syncfusion.Pdf.Parsing;
using Syncfusion.Pdf.Security;
using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using Syncfusion.DocToPDFConverter;
using Syncfusion.Pdf;
using System.Collections.Generic;
using System.IO;
using System;
using System.Linq;

namespace SecurePdf
{
    public class ConvertSecurePdf
    {
        public string ConvertPdfToSecurePdfAsync(string path, string destination)
        {
            try
            {
                List<string> pdfDirectory = new List<string>();
                pdfDirectory = GetAllPdfFile(path);

                if (pdfDirectory.Count > 0)
                {
                    for (int i = 0; i < pdfDirectory.Count; i++)
                    {
                        
                        var msg = ConvertWordToPdf(pdfDirectory[i], destination);
                    }
                    return "Success";
                }
                else
                {
                    return "Please enter those folder which have document files";
                }

            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        public string  ConvertWordToPdf(string file,string dest)
        {
            string fileName = Path.GetFileName(file);
            string pdfFilePath = fileName.Substring(0, fileName.Length - 5);
            //Load an existing Word document
            WordDocument wordDocument = new WordDocument(file, FormatType.Docx);
            //Create an instance of DocToPDFConverter
            DocToPDFConverter converter = new DocToPDFConverter();
            //Convert Word document into PDF document
            PdfDocument pdfDocument = converter.ConvertToPDF(wordDocument);
            PdfSecurity secutity = pdfDocument.Security;
            secutity.OwnerPassword = "Syncfusion";
            secutity.Permissions = PdfPermissionsFlags.Default;
            //Save the PDF file
            pdfDocument.Save(dest + "\\" + pdfFilePath + ".pdf");
            //Close the instance of document objects
            pdfDocument.Close(true);
            wordDocument.Close();
            return "done";
        }

        public static List<string> GetAllPdfFile(string folderName)
        {
            return Directory.GetFiles(folderName, "*.docx", SearchOption.AllDirectories)
                .ToList();
        }

        public string ConvertWordFileToPdf(string file)
        {
            string fileName = Path.GetFileName(file);
            string pdfFileName = fileName.Substring(0, fileName.Length - 5);
            string dest = file.Substring(0, file.Length - fileName.Length);
            //Load an existing Word document
            WordDocument wordDocument = new WordDocument(file, FormatType.Docx);
            //Create an instance of DocToPDFConverter
            DocToPDFConverter converter = new DocToPDFConverter();
            //Convert Word document into PDF document
            PdfDocument pdfDocument = converter.ConvertToPDF(wordDocument);
            PdfSecurity secutity = pdfDocument.Security;
            secutity.OwnerPassword = "Syncfusion";
            secutity.Permissions = PdfPermissionsFlags.Default;
            //Save the PDF file
            pdfDocument.Save(dest + "\\" + pdfFileName + ".pdf");
            //Close the instance of document objects
            pdfDocument.Close(true);
            wordDocument.Close();
            return "Success";
        }

    }
}
