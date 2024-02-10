using System.Collections.Generic;

namespace DataMapperPDF2XML.Models
{
    public class ExtractionConfiguration
    {
        public string Id { get; set; } // A unique identifier for the configuration
        public List<CellConfiguration> Cells { get; set; } = new List<CellConfiguration>();

        public void AddCellConfiguration(CellConfiguration cell)
        {
            Cells.Add(cell);
        } 
    }
}
