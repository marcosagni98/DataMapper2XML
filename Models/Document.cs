using System.Collections.Generic;

namespace DataMapperPDF2XML.Models
{
    public class Document
    {
        public string Name { get; set; }
        public string FilePath { get; set; }
        public List<CellConfiguration> ConfiguredCells { get; set; } = new List<CellConfiguration>();
    }
}
