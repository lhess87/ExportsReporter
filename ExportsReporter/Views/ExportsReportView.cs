using ExportsReporter.Presenters;
using ExportsReporterDataAccess.Interfaces;
using ExportsReporterDataAccess.Services;
using System.Threading;
using System.Windows.Forms;

namespace ExportsReporter.Views
{
    public partial class ExportsReportView : Form
    {
        private ExportRaportPrezenter exportRaportPrezenter;
        public ExportsReportView()
        {
            InitializeComponent();
        }

        internal void Init()
        {
            ISearchService searchService = new ExportsSearchService();
            exportRaportPrezenter = new ExportRaportPrezenter(searchService);
            ExportsTableViewPresenter exportsTableViewPresenter = new ExportsTableViewPresenter();
            exportsTableViewPresenter.LoadList = exportsTableView.LoadList;            
            ExportsSearchPresenter exportsSearchPresenter = new ExportsSearchPresenter(searchService);            
            exportsSearchPresenter.RefreshList = exportsTableViewPresenter.RefreshList;
            exportsSearchPresenter.LoadStarted = ShowWaitForm;
            exportsSearchPresenter.LoadCompleted =  CloseWaitForm;
            exportsSearchView.InitPresenter(exportsSearchPresenter);
            exportsSearchView.LoadDictionares(exportRaportPrezenter.LoadDictionaries(searchService));
            exportsTableView.InitPresenter(exportsTableViewPresenter);            
        }

        public void ShowWaitForm()
        {
            if(!splashScreenManager.IsSplashFormVisible)
                splashScreenManager.ShowWaitForm();
        }

        public void CloseWaitForm()
        {
            if (splashScreenManager.IsSplashFormVisible)
                splashScreenManager.CloseWaitForm();
        }
    }
}
