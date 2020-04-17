using ExportsReporterDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ExportsReporterDataAccess.Repo
{
    class ExportSearchRepo
    {
        internal List<ExportSearchResult> GetExports(ExportsSearchCryteria exportsSearchCryteria)
        {
            using (LSIEntities context = new LSIEntities())
            {
                var exports = context.Export.Select(r => r);

                if (!string.IsNullOrWhiteSpace(exportsSearchCryteria.ExportLocalName))
                    exports = exports.Where(x => x.ExportLocalName.StartsWith(exportsSearchCryteria.ExportLocalName));

                if (exportsSearchCryteria.ExportDateFrom.HasValue)
                    exports = exports.Where(x => x.ExportDateTime >= exportsSearchCryteria.ExportDateFrom.Value);

                if (exportsSearchCryteria.ExportDateTo.HasValue)
                {
                    DateTime endOfday = exportsSearchCryteria.ExportDateTo.Value.AddDays(1);
                    exports = exports.Where(x => x.ExportDateTime < endOfday);
                }

                return exports.Select(x =>
                    new ExportSearchResult()
                    {
                        ExportId = x.ExportId,
                        ExportDateTime = x.ExportDateTime,
                        ExportLocalName = x.ExportLocalName,
                        ExportUserName = x.ExportUserName,
                        ExportName = x.ExportName
                    }).ToList();
            }            
        }

        internal List<string> GetLocalNamesDictionary()
        {
            using (LSIEntities context = new LSIEntities())
            {
                return context.Export.Select(x => x.ExportLocalName).Distinct().ToList();
            }
        }
    }
}
