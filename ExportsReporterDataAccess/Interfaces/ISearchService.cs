using ExportsReporterDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExportsReporterDataAccess.Interfaces
{
    public interface ISearchService
    {
        List<ExportSearchResult> GetExports(ExportsSearchCryteria searchCryteria);
        List<string> GetLocalNamesDictionary();
    }
}
