using System;
using System.IO;

namespace DataMapperPDF2XML.Services
{
    public static class DocumentServiceFactory
    {
        /*
         Usage:
            try
            {
                IDocumentService documentService = DocumentServiceFactory.GetDocumentService(filePath);
                var document = await documentService.LoadDocumentAsync(filePath);
                var dataTable = await documentService.ExtractDataAsync(document);
                // Actualizar la UI o el modelo de datos según el resultado
            }
            catch (NotSupportedException ex)
            {
                // Actualizar la UI para mostrar el error
            }
         */
        public static IDocumentService<TDocument> GetDocumentService<TDocument>(string filePath)
        {
            string extension = Path.GetExtension(filePath).ToLower();

            switch (extension)
            {
                case ".pdf":
                    return new PdfService() as IDocumentService<TDocument>;
                default:
                    throw new NotSupportedException($"The file type {extension} is not supported.");
            }
        }
    }

}