using System;

namespace ExportsReporterDataAccess.Models
{
    public class ExportSearchResult
    {
        public int ExportId { get; set; }
        public string ExportName { get; set; }
        public DateTime ExportDateTime { get; set; }
        public string ExportUserName { get; set; }
        public string ExportLocalName { get; set; }       
    }
}
