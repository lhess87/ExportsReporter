namespace ExportsReporter.Views
{
    partial class ExportsSearchView
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.exportDateToDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.exportDateFromDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.searchButton = new DevExpress.XtraEditors.SimpleButton();
            this.exportLocalNameComboBox = new DevExpress.XtraEditors.ComboBoxEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exportDateToDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportDateToDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportDateFromDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportDateFromDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportLocalNameComboBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.exportDateToDateEdit);
            this.layoutControl1.Controls.Add(this.exportDateFromDateEdit);
            this.layoutControl1.Controls.Add(this.searchButton);
            this.layoutControl1.Controls.Add(this.exportLocalNameComboBox);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(582, 114, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(280, 406);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // exportDateToDateEdit
            // 
            this.exportDateToDateEdit.EditValue = null;
            this.exportDateToDateEdit.Location = new System.Drawing.Point(12, 80);
            this.exportDateToDateEdit.Name = "exportDateToDateEdit";
            this.exportDateToDateEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.exportDateToDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.exportDateToDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.exportDateToDateEdit.Properties.NullValuePrompt = "Data do:";
            this.exportDateToDateEdit.Size = new System.Drawing.Size(256, 20);
            this.exportDateToDateEdit.StyleController = this.layoutControl1;
            this.exportDateToDateEdit.TabIndex = 10;
            this.exportDateToDateEdit.ToolTip = "Wpisz datę do lokalizacji aby wyszukać";
            this.exportDateToDateEdit.EditValueChanged += new System.EventHandler(this.exportDateToDateEdit_EditValueChanged);
            this.exportDateToDateEdit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.exportDateToDateEdit_KeyDown);
            // 
            // exportDateFromDateEdit
            // 
            this.exportDateFromDateEdit.EditValue = null;
            this.exportDateFromDateEdit.Location = new System.Drawing.Point(12, 46);
            this.exportDateFromDateEdit.Name = "exportDateFromDateEdit";
            this.exportDateFromDateEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.exportDateFromDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.exportDateFromDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.exportDateFromDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.exportDateFromDateEdit.Properties.NullValuePrompt = "Data od:";
            this.exportDateFromDateEdit.Size = new System.Drawing.Size(256, 20);
            this.exportDateFromDateEdit.StyleController = this.layoutControl1;
            this.exportDateFromDateEdit.TabIndex = 9;
            this.exportDateFromDateEdit.ToolTip = "Wpisz datę od dodania lokalizacji aby wyszukać";
            this.exportDateFromDateEdit.EditValueChanged += new System.EventHandler(this.exportDateFromDateEdit_EditValueChanged);
            this.exportDateFromDateEdit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.exportDateFromDateEdit_KeyDown);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(12, 372);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(256, 22);
            this.searchButton.StyleController = this.layoutControl1;
            this.searchButton.TabIndex = 8;
            this.searchButton.Text = "Zatwierdź";
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // exportLocalNameComboBox
            // 
            this.exportLocalNameComboBox.Location = new System.Drawing.Point(12, 12);
            this.exportLocalNameComboBox.Name = "exportLocalNameComboBox";
            this.exportLocalNameComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.exportLocalNameComboBox.Properties.NullValuePrompt = "Lokal:";
            this.exportLocalNameComboBox.Size = new System.Drawing.Size(256, 20);
            this.exportLocalNameComboBox.StyleController = this.layoutControl1;
            this.exportLocalNameComboBox.TabIndex = 4;
            this.exportLocalNameComboBox.ToolTip = "Wpisz nazwę lokalizacji";
            this.exportLocalNameComboBox.SelectedIndexChanged += new System.EventHandler(this.exportLocalNameComboBox_SelectedIndexChanged);
            this.exportLocalNameComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.exportLocalNameComboBox_KeyDown);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem5,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.emptySpaceItem2,
            this.emptySpaceItem1,
            this.emptySpaceItem3});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(280, 406);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.exportLocalNameComboBox;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(260, 24);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.searchButton;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 360);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(260, 26);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.exportDateFromDateEdit;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 34);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(260, 24);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.exportDateToDateEdit;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 68);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(260, 24);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 92);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(260, 268);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.BestFitWeight = 5;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 24);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(260, 10);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.BestFitWeight = 5;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 58);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(260, 10);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // ExportsSearchView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "ExportsSearchView";
            this.Size = new System.Drawing.Size(280, 406);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.exportDateToDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportDateToDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportDateFromDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportDateFromDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportLocalNameComboBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.ComboBoxEdit exportLocalNameComboBox;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton searchButton;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.DateEdit exportDateToDateEdit;
        private DevExpress.XtraEditors.DateEdit exportDateFromDateEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
    }
}
