using ExportsReporter.Models;
using ExportsReporterDataAccess.Interfaces;
using ExportsReporterDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace ExportsReporter.Presenters
{
    public class ExportsSearchPresenter
    {
        private ISearchService searchService;
        public Action<List<Export>> RefreshList { get; set; }
        public Action LoadStarted { get; set; }
        public Action LoadCompleted { get; set; }        

        public ExportsSearchPresenter(ISearchService searchService)
        {
            this.searchService = searchService;            
        }

        public void Search(string exportLocalName, DateTime exportDateFrom, DateTime exportDateTo)
        {
            LoadStarted?.Invoke();
            ExportsSearchCryteria searchCryteria = BuildCryteria(exportLocalName, exportDateFrom, exportDateTo);
            List<Export> result = Map(searchService.GetExports(searchCryteria));
            LoadCompleted?.Invoke();
            RefreshList?.Invoke(result);            
        }

        private List<Export> Map(List<ExportSearchResult> list)
        {
            return list.Select(x => new Export()
            {
                ExportLocalName = x.ExportLocalName,
                ExportDateTime = x.ExportDateTime,
                ExportName = x.ExportName,
                ExportUserName = x.ExportUserName
            }).ToList();
        
        }
        private ExportsSearchCryteria BuildCryteria(string exportLocalName, DateTime exportDateFrom, DateTime exportDateTo)
        {
            return new ExportsSearchCryteria()
            {
                ExportLocalName = exportLocalName,
                ExportDateFrom = (exportDateFrom == DateTime.MinValue) ? new Nullable<DateTime>() : exportDateFrom,
                ExportDateTo = (exportDateTo == DateTime.MinValue) ? new Nullable<DateTime>() : exportDateTo
            };
        }
    }
}
