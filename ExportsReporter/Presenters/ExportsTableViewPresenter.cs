using ExportsReporter.Models;
using System;
using System.Collections.Generic;

namespace ExportsReporter.Presenters
{
    internal class ExportsTableViewPresenter
    {
        public Action<List<Export>> LoadList;
        
        public void RefreshList(List<Export> exports)
        {
            if (LoadList != null && exports != null)
            {
                LoadList(exports);                
            }
;        }
    }
}
