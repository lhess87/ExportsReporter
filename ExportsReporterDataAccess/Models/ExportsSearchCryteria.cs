using System;

namespace ExportsReporterDataAccess.Models
{
    public class ExportsSearchCryteria
    {
        public string ExportLocalName { get; set; }
        public DateTime? ExportDateFrom { get; set; }
        public DateTime? ExportDateTo { get; set; }
    }
}
