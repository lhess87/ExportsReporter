using ExportsReporterDataAccess.Interfaces;
using ExportsReporterDataAccess.Models;
using ExportsReporterDataAccess.Repo;
using System.Collections.Generic;

namespace ExportsReporterDataAccess.Services
{
    public class ExportsSearchService : ISearchService
    {
        private ExportSearchRepo exportSearchRepo;

        public ExportsSearchService()
        {
            exportSearchRepo = new ExportSearchRepo();
        }

        public List<ExportSearchResult> GetExports(ExportsSearchCryteria searchCryteria)
        {
            return exportSearchRepo.GetExports(searchCryteria);
        }

        public List<string> GetLocalNamesDictionary()
        {
            return exportSearchRepo.GetLocalNamesDictionary();
        }
    }
}
