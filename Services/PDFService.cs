using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System.Data;
using System.Reflection.PortableExecutable;
using System.Threading.Tasks;

namespace DataMapperPDF2XML.Services
{
    public class PdfService : IDocumentService<PdfDocument>
    {
        public async Task<PdfDocument> LoadDocumentAsync(string filePath)
        {
            return await Task.Run(() =>
            {
                return PdfReader.Open(filePath, PdfDocumentOpenMode.ReadOnly);
            });
        }

        public async Task<DataTable> ExtractDataAsync(PdfDocument pdfDocument)
        {

            //Aqui se tiene que convertir a excel para poder operar
            DataTable dataTable = new();
            return dataTable;
        }
    }
}