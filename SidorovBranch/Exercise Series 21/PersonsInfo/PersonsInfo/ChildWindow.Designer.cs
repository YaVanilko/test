namespace PersonsInfo
{
    partial class ChildWindow
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.xtraTabControlPersons = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPagePerson = new DevExpress.XtraTab.XtraTabPage();
            this.labelControlBirthDate = new DevExpress.XtraEditors.LabelControl();
            this.labelControlMiddleName = new DevExpress.XtraEditors.LabelControl();
            this.labelControlLastName = new DevExpress.XtraEditors.LabelControl();
            this.labelControlFirstName = new DevExpress.XtraEditors.LabelControl();
            this.dateTimePicketBirth = new System.Windows.Forms.DateTimePicker();
            this.textEditMiddleName = new DevExpress.XtraEditors.TextEdit();
            this.textEditLasstName = new DevExpress.XtraEditors.TextEdit();
            this.textEditFirstName = new DevExpress.XtraEditors.TextEdit();
            this.xtraTabPageZoo = new DevExpress.XtraTab.XtraTabPage();
            this.gridControlPersonsZoo = new DevExpress.XtraGrid.GridControl();
            this.gridViewZoo = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlPersons)).BeginInit();
            this.xtraTabControlPersons.SuspendLayout();
            this.xtraTabPagePerson.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMiddleName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditLasstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditFirstName.Properties)).BeginInit();
            this.xtraTabPageZoo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPersonsZoo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewZoo)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControlPersons
            // 
            this.xtraTabControlPersons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControlPersons.Location = new System.Drawing.Point(12, 12);
            this.xtraTabControlPersons.Name = "xtraTabControlPersons";
            this.xtraTabControlPersons.SelectedTabPage = this.xtraTabPagePerson;
            this.xtraTabControlPersons.Size = new System.Drawing.Size(370, 262);
            this.xtraTabControlPersons.TabIndex = 0;
            this.xtraTabControlPersons.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPagePerson,
            this.xtraTabPageZoo});
            // 
            // xtraTabPagePerson
            // 
            this.xtraTabPagePerson.Controls.Add(this.labelControlBirthDate);
            this.xtraTabPagePerson.Controls.Add(this.labelControlMiddleName);
            this.xtraTabPagePerson.Controls.Add(this.labelControlLastName);
            this.xtraTabPagePerson.Controls.Add(this.labelControlFirstName);
            this.xtraTabPagePerson.Controls.Add(this.dateTimePicketBirth);
            this.xtraTabPagePerson.Controls.Add(this.textEditMiddleName);
            this.xtraTabPagePerson.Controls.Add(this.textEditLasstName);
            this.xtraTabPagePerson.Controls.Add(this.textEditFirstName);
            this.xtraTabPagePerson.Name = "xtraTabPagePerson";
            this.xtraTabPagePerson.Size = new System.Drawing.Size(364, 234);
            this.xtraTabPagePerson.Text = "Person";
            // 
            // labelControlBirthDate
            // 
            this.labelControlBirthDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControlBirthDate.Location = new System.Drawing.Point(35, 193);
            this.labelControlBirthDate.Name = "labelControlBirthDate";
            this.labelControlBirthDate.Size = new System.Drawing.Size(48, 13);
            this.labelControlBirthDate.TabIndex = 7;
            this.labelControlBirthDate.Text = "Birth Date";
            // 
            // labelControlMiddleName
            // 
            this.labelControlMiddleName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControlMiddleName.Location = new System.Drawing.Point(35, 137);
            this.labelControlMiddleName.Name = "labelControlMiddleName";
            this.labelControlMiddleName.Size = new System.Drawing.Size(60, 13);
            this.labelControlMiddleName.TabIndex = 6;
            this.labelControlMiddleName.Text = "Middle Name";
            // 
            // labelControlLastName
            // 
            this.labelControlLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControlLastName.Location = new System.Drawing.Point(35, 84);
            this.labelControlLastName.Name = "labelControlLastName";
            this.labelControlLastName.Size = new System.Drawing.Size(50, 13);
            this.labelControlLastName.TabIndex = 5;
            this.labelControlLastName.Text = "Last Name";
            // 
            // labelControlFirstName
            // 
            this.labelControlFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControlFirstName.Location = new System.Drawing.Point(35, 31);
            this.labelControlFirstName.Name = "labelControlFirstName";
            this.labelControlFirstName.Size = new System.Drawing.Size(51, 13);
            this.labelControlFirstName.TabIndex = 4;
            this.labelControlFirstName.Text = "First Name";
            // 
            // dateTimePicketBirth
            // 
            this.dateTimePicketBirth.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicketBirth.Location = new System.Drawing.Point(120, 187);
            this.dateTimePicketBirth.Name = "dateTimePicketBirth";
            this.dateTimePicketBirth.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicketBirth.TabIndex = 3;
            // 
            // textEditMiddleName
            // 
            this.textEditMiddleName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEditMiddleName.Location = new System.Drawing.Point(120, 134);
            this.textEditMiddleName.Name = "textEditMiddleName";
            this.textEditMiddleName.Size = new System.Drawing.Size(200, 20);
            this.textEditMiddleName.TabIndex = 2;
            // 
            // textEditLasstName
            // 
            this.textEditLasstName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEditLasstName.Location = new System.Drawing.Point(120, 81);
            this.textEditLasstName.Name = "textEditLasstName";
            this.textEditLasstName.Size = new System.Drawing.Size(200, 20);
            this.textEditLasstName.TabIndex = 1;
            // 
            // textEditFirstName
            // 
            this.textEditFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEditFirstName.Location = new System.Drawing.Point(120, 28);
            this.textEditFirstName.Name = "textEditFirstName";
            this.textEditFirstName.Size = new System.Drawing.Size(200, 20);
            this.textEditFirstName.TabIndex = 0;
            // 
            // xtraTabPageZoo
            // 
            this.xtraTabPageZoo.Controls.Add(this.gridControlPersonsZoo);
            this.xtraTabPageZoo.Name = "xtraTabPageZoo";
            this.xtraTabPageZoo.Size = new System.Drawing.Size(364, 234);
            this.xtraTabPageZoo.Text = "Zoo";
            // 
            // gridControlPersonsZoo
            // 
            this.gridControlPersonsZoo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlPersonsZoo.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlPersonsZoo.Location = new System.Drawing.Point(4, 4);
            this.gridControlPersonsZoo.MainView = this.gridViewZoo;
            this.gridControlPersonsZoo.Name = "gridControlPersonsZoo";
            this.gridControlPersonsZoo.Size = new System.Drawing.Size(357, 227);
            this.gridControlPersonsZoo.TabIndex = 0;
            this.gridControlPersonsZoo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewZoo});
            // 
            // gridViewZoo
            // 
            this.gridViewZoo.GridControl = this.gridControlPersonsZoo;
            this.gridViewZoo.Name = "gridViewZoo";
            // 
            // ChildWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 286);
            this.Controls.Add(this.xtraTabControlPersons);
            this.Name = "ChildWindow";
            this.Text = "Person";
            this.Load += new System.EventHandler(this.ChildWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlPersons)).EndInit();
            this.xtraTabControlPersons.ResumeLayout(false);
            this.xtraTabPagePerson.ResumeLayout(false);
            this.xtraTabPagePerson.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMiddleName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditLasstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditFirstName.Properties)).EndInit();
            this.xtraTabPageZoo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPersonsZoo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewZoo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControlPersons;
        private DevExpress.XtraTab.XtraTabPage xtraTabPagePerson;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageZoo;
        private DevExpress.XtraGrid.GridControl gridControlPersonsZoo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewZoo;
        private DevExpress.XtraEditors.LabelControl labelControlBirthDate;
        private DevExpress.XtraEditors.LabelControl labelControlMiddleName;
        private DevExpress.XtraEditors.LabelControl labelControlLastName;
        private DevExpress.XtraEditors.LabelControl labelControlFirstName;
        private System.Windows.Forms.DateTimePicker dateTimePicketBirth;
        private DevExpress.XtraEditors.TextEdit textEditMiddleName;
        private DevExpress.XtraEditors.TextEdit textEditLasstName;
        private DevExpress.XtraEditors.TextEdit textEditFirstName;
    }
}