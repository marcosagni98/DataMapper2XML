namespace DataMapperPDF2XML.Models
{
    public class CellConfiguration
    {
        public int Page { get; set; }
        public string CellAddress { get; set; } // Example: "A1", "B2", etc.
        public bool IsTitle { get; set; } // Indicates if the cell contains a title
        public string DataType { get; set; } // Example: "Text", "Number", "Date"
        public string? KeyCellAddress { get; set; } // Address of the key cell associated with this value cell; can be null
    }
}
