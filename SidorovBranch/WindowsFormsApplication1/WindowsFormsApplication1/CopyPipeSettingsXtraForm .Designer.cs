namespace WindowsFormsApplication1
{
    partial class CopyPipeSettingsXtraForm
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
            this.checkEditPipeParameters = new DevExpress.XtraEditors.CheckEdit();
            this.checkEditListOfTestOperations = new DevExpress.XtraEditors.CheckEdit();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboBoxEdit2 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControlManufacturer = new DevExpress.XtraEditors.LabelControl();
            this.labelControlPipeSizes = new DevExpress.XtraEditors.LabelControl();
            this.simpleButtonCopy = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonСancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditPipeParameters.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditListOfTestOperations.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // checkEditPipeParameters
            // 
            this.checkEditPipeParameters.Location = new System.Drawing.Point(38, 28);
            this.checkEditPipeParameters.Name = "checkEditPipeParameters";
            this.checkEditPipeParameters.Properties.Caption = "Pipe parameters";
            this.checkEditPipeParameters.Size = new System.Drawing.Size(145, 19);
            this.checkEditPipeParameters.TabIndex = 0;
            // 
            // checkEditListOfTestOperations
            // 
            this.checkEditListOfTestOperations.Location = new System.Drawing.Point(38, 68);
            this.checkEditListOfTestOperations.Name = "checkEditListOfTestOperations";
            this.checkEditListOfTestOperations.Properties.Caption = "List of test operations";
            this.checkEditListOfTestOperations.Size = new System.Drawing.Size(145, 19);
            this.checkEditListOfTestOperations.TabIndex = 1;
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxEdit1.Location = new System.Drawing.Point(38, 135);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Size = new System.Drawing.Size(320, 20);
            this.comboBoxEdit1.TabIndex = 2;
            // 
            // comboBoxEdit2
            // 
            this.comboBoxEdit2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxEdit2.Location = new System.Drawing.Point(38, 187);
            this.comboBoxEdit2.Name = "comboBoxEdit2";
            this.comboBoxEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit2.Size = new System.Drawing.Size(320, 20);
            this.comboBoxEdit2.TabIndex = 3;
            // 
            // labelControlManufacturer
            // 
            this.labelControlManufacturer.Location = new System.Drawing.Point(38, 116);
            this.labelControlManufacturer.Name = "labelControlManufacturer";
            this.labelControlManufacturer.Size = new System.Drawing.Size(106, 13);
            this.labelControlManufacturer.TabIndex = 4;
            this.labelControlManufacturer.Text = "Manufacturer of pipes";
            // 
            // labelControlPipeSizes
            // 
            this.labelControlPipeSizes.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.labelControlPipeSizes.Location = new System.Drawing.Point(38, 168);
            this.labelControlPipeSizes.Name = "labelControlPipeSizes";
            this.labelControlPipeSizes.Size = new System.Drawing.Size(186, 13);
            this.labelControlPipeSizes.TabIndex = 5;
            this.labelControlPipeSizes.Text = "Pipe sizes, performance characteristics";
            // 
            // simpleButtonCopy
            // 
            this.simpleButtonCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonCopy.Location = new System.Drawing.Point(186, 229);
            this.simpleButtonCopy.Name = "simpleButtonCopy";
            this.simpleButtonCopy.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonCopy.TabIndex = 6;
            this.simpleButtonCopy.Text = "Copy";
            // 
            // simpleButtonСancel
            // 
            this.simpleButtonСancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonСancel.Location = new System.Drawing.Point(283, 229);
            this.simpleButtonСancel.Name = "simpleButtonСancel";
            this.simpleButtonСancel.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonСancel.TabIndex = 7;
            this.simpleButtonСancel.Text = "Сancel";
            // 
            // CopyPipeSettingsXtraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 264);
            this.Controls.Add(this.simpleButtonСancel);
            this.Controls.Add(this.simpleButtonCopy);
            this.Controls.Add(this.labelControlPipeSizes);
            this.Controls.Add(this.labelControlManufacturer);
            this.Controls.Add(this.comboBoxEdit2);
            this.Controls.Add(this.comboBoxEdit1);
            this.Controls.Add(this.checkEditListOfTestOperations);
            this.Controls.Add(this.checkEditPipeParameters);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CopyPipeSettingsXtraForm";
            this.Text = "Сopy the settings";
            ((System.ComponentModel.ISupportInitialize)(this.checkEditPipeParameters.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditListOfTestOperations.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.CheckEdit checkEditPipeParameters;
        private DevExpress.XtraEditors.CheckEdit checkEditListOfTestOperations;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit2;
        private DevExpress.XtraEditors.LabelControl labelControlManufacturer;
        private DevExpress.XtraEditors.LabelControl labelControlPipeSizes;
        private DevExpress.XtraEditors.SimpleButton simpleButtonCopy;
        private DevExpress.XtraEditors.SimpleButton simpleButtonСancel;
    }
}