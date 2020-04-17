using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ExportsReporter.Models;
using ExportsReporter.Presenters;
using System.Linq;

namespace ExportsReporter.Views
{
    public partial class ExportsSearchView : UserControl
    {
        private ExportsSearchPresenter exportsSearchPresenter;
        public ExportsSearchView()
        {
            InitializeComponent();           
        }

        public void LoadDictionares(List<string> localNamesList)
        {
            exportLocalNameComboBox.Properties.Items.Clear();
            exportLocalNameComboBox.Properties.Items.AddRange(localNamesList);
        }

        public void InitPresenter(ExportsSearchPresenter exportsSearchPresenter)
        {
            this.exportsSearchPresenter = exportsSearchPresenter;
            this.exportsSearchPresenter.Search(string.Empty, DateTime.MinValue, DateTime.MinValue);
        }

        private void searchButton_Click(object sender, System.EventArgs e)
        {         
            this.exportsSearchPresenter.Search(exportLocalNameComboBox.Text, exportDateFromDateEdit.DateTime, exportDateToDateEdit.DateTime);
        }

        private void exportLocalNameComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            SearchAfterPressEnter(e);
        }

        private void SearchAfterPressEnter(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.exportsSearchPresenter.Search(exportLocalNameComboBox.Text, exportDateFromDateEdit.DateTime, exportDateToDateEdit.DateTime);
        }

        private void exportDateFromDateEdit_KeyDown(object sender, KeyEventArgs e)
        {
            SearchAfterPressEnter(e);
        }

        private void exportDateToDateEdit_KeyDown(object sender, KeyEventArgs e)
        {
            SearchAfterPressEnter(e);
        }

        private void exportLocalNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.exportsSearchPresenter.Search(exportLocalNameComboBox.Text, exportDateFromDateEdit.DateTime, exportDateToDateEdit.DateTime);
        }

        private void exportDateFromDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            this.exportsSearchPresenter.Search(exportLocalNameComboBox.Text, exportDateFromDateEdit.DateTime, exportDateToDateEdit.DateTime);
        }

        private void exportDateToDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            this.exportsSearchPresenter.Search(exportLocalNameComboBox.Text, exportDateFromDateEdit.DateTime, exportDateToDateEdit.DateTime);
        }
    
    }
}
