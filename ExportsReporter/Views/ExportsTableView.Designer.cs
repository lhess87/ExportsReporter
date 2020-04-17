namespace ExportsReporter.Views
{
    partial class ExportsTableView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.exportsGrid = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.exportNameColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.exportDateColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.exportHourColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.exportUserColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.exportLocalName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exportsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.exportsGrid);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(716, 102, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(414, 394);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // exportsGrid
            // 
            this.exportsGrid.DataSource = typeof(ExportsReporter.Models.Export);
            this.exportsGrid.Location = new System.Drawing.Point(12, 12);
            this.exportsGrid.MainView = this.gridView1;
            this.exportsGrid.Name = "exportsGrid";
            this.exportsGrid.Size = new System.Drawing.Size(390, 370);
            this.exportsGrid.TabIndex = 4;
            this.exportsGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.exportNameColumn,
            this.exportDateColumn,
            this.exportHourColumn,
            this.exportUserColumn,
            this.exportLocalName});
            this.gridView1.GridControl = this.exportsGrid;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            // 
            // exportNameColumn
            // 
            this.exportNameColumn.Caption = "Nazwa";
            this.exportNameColumn.FieldName = "ExportName";
            this.exportNameColumn.Name = "exportNameColumn";
            this.exportNameColumn.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.exportNameColumn.Visible = true;
            this.exportNameColumn.VisibleIndex = 0;
            // 
            // exportDateColumn
            // 
            this.exportDateColumn.Caption = "Data";
            this.exportDateColumn.DisplayFormat.FormatString = "dd.MM.yyyy";
            this.exportDateColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.exportDateColumn.FieldName = "ExportDateTime";
            this.exportDateColumn.GroupFormat.FormatString = "yyyy-MM-dd";
            this.exportDateColumn.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.exportDateColumn.Name = "exportDateColumn";
            this.exportDateColumn.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.exportDateColumn.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            this.exportDateColumn.Visible = true;
            this.exportDateColumn.VisibleIndex = 1;
            // 
            // exportHourColumn
            // 
            this.exportHourColumn.Caption = "Godzina";
            this.exportHourColumn.DisplayFormat.FormatString = "HH:mm:ss";
            this.exportHourColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.exportHourColumn.FieldName = "ExportDateTime";
            this.exportHourColumn.GroupFormat.FormatString = "HH:mm:ss";
            this.exportHourColumn.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.exportHourColumn.Name = "exportHourColumn";
            this.exportHourColumn.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.exportHourColumn.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            this.exportHourColumn.Visible = true;
            this.exportHourColumn.VisibleIndex = 2;
            // 
            // exportUserColumn
            // 
            this.exportUserColumn.Caption = "Użytkownik";
            this.exportUserColumn.FieldName = "ExportUserName";
            this.exportUserColumn.Name = "exportUserColumn";
            this.exportUserColumn.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.exportUserColumn.Visible = true;
            this.exportUserColumn.VisibleIndex = 3;
            // 
            // exportLocalName
            // 
            this.exportLocalName.Caption = "Lokal";
            this.exportLocalName.FieldName = "ExportLocalName";
            this.exportLocalName.Name = "exportLocalName";
            this.exportLocalName.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.exportLocalName.Visible = true;
            this.exportLocalName.VisibleIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(414, 394);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.exportsGrid;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(394, 374);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // ExportsTableView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "ExportsTableView";
            this.Size = new System.Drawing.Size(414, 394);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.exportsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl exportsGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.Columns.GridColumn exportNameColumn;
        private DevExpress.XtraGrid.Columns.GridColumn exportDateColumn;
        private DevExpress.XtraGrid.Columns.GridColumn exportHourColumn;
        private DevExpress.XtraGrid.Columns.GridColumn exportUserColumn;
        private DevExpress.XtraGrid.Columns.GridColumn exportLocalName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
    }
}
