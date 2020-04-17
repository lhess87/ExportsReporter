using ExportsReporterDataAccess.Interfaces;
using System.Collections.Generic;

namespace ExportsReporter.Presenters
{
    public class ExportRaportPrezenter
    {        
        public ExportRaportPrezenter(ISearchService exportsSearchService)
        {
            LoadDictionaries(exportsSearchService);
        }

        public List<string> LoadDictionaries(ISearchService exportsSearchService)
        {
            return exportsSearchService.GetLocalNamesDictionary();
        }

    }
}
