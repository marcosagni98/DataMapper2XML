using System.Data;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace DataMapperPDF2XML.Services
{
    public interface IDocumentService<TDocument>
    {
        Task<TDocument> LoadDocumentAsync(string filePath);
        Task<DataTable> ExtractDataAsync(TDocument document);
    }
}