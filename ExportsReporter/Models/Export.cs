using System;

namespace ExportsReporter.Models
{
    public class Export
    {
        public string ExportName { get; set; }
        public DateTime ExportDateTime { get; set; }
        public string ExportUserName { get; set; }
        public string ExportLocalName { get; set; }
    }
}
