using System.Collections.Generic;
using System.Windows.Forms;
using ExportsReporter.Presenters;
using ExportsReporter.Models;
using System.ComponentModel;

namespace ExportsReporter.Views
{
    public partial class ExportsTableView : UserControl
    {
        private ExportsTableViewPresenter exportsTableViewPresenter;

        public ExportsTableView()
        {
            InitializeComponent();          
            
        }

        internal void InitPresenter(ExportsTableViewPresenter exportsTableViewPresenter)
        {
            this.exportsTableViewPresenter = exportsTableViewPresenter;
        }

        internal void LoadList(List<Export> listToLoad)
        {
            BindingList<Export> list = new BindingList<Export>(listToLoad);
            exportsGrid.DataSource = list;
        }
    }
}
