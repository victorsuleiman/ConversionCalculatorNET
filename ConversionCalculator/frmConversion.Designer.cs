
namespace ConversionCalculator
{
    partial class frmConversion
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
            this.labelValue = new System.Windows.Forms.Label();
            this.labelConversions = new System.Windows.Forms.Label();
            this.listBoxConversions = new System.Windows.Forms.ListBox();
            this.listBoxResults = new System.Windows.Forms.ListBox();
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonManageConversions = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.Location = new System.Drawing.Point(49, 37);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(115, 17);
            this.labelValue.TabIndex = 0;
            this.labelValue.Text = "Value to convert:";
            // 
            // labelConversions
            // 
            this.labelConversions.AutoSize = true;
            this.labelConversions.Location = new System.Drawing.Point(53, 109);
            this.labelConversions.Name = "labelConversions";
            this.labelConversions.Size = new System.Drawing.Size(86, 17);
            this.labelConversions.TabIndex = 1;
            this.labelConversions.Text = "Conversions";
            // 
            // listBoxConversions
            // 
            this.listBoxConversions.FormattingEnabled = true;
            this.listBoxConversions.ItemHeight = 16;
            this.listBoxConversions.Location = new System.Drawing.Point(56, 143);
            this.listBoxConversions.Name = "listBoxConversions";
            this.listBoxConversions.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxConversions.Size = new System.Drawing.Size(249, 308);
            this.listBoxConversions.TabIndex = 2;
            // 
            // listBoxResults
            // 
            this.listBoxResults.FormattingEnabled = true;
            this.listBoxResults.ItemHeight = 16;
            this.listBoxResults.Location = new System.Drawing.Point(355, 47);
            this.listBoxResults.Name = "listBoxResults";
            this.listBoxResults.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxResults.Size = new System.Drawing.Size(378, 404);
            this.listBoxResults.TabIndex = 3;
            // 
            // textBoxValue
            // 
            this.textBoxValue.Location = new System.Drawing.Point(52, 57);
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.Size = new System.Drawing.Size(124, 22);
            this.textBoxValue.TabIndex = 4;
            this.textBoxValue.Tag = "Value to Convert";
            // 
            // buttonConvert
            // 
            this.buttonConvert.Location = new System.Drawing.Point(56, 473);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(89, 28);
            this.buttonConvert.TabIndex = 5;
            this.buttonConvert.Text = "Convert";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(216, 473);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(89, 28);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonManageConversions
            // 
            this.buttonManageConversions.Location = new System.Drawing.Point(355, 473);
            this.buttonManageConversions.Name = "buttonManageConversions";
            this.buttonManageConversions.Size = new System.Drawing.Size(184, 28);
            this.buttonManageConversions.TabIndex = 7;
            this.buttonManageConversions.Text = "Manage Conversions";
            this.buttonManageConversions.UseVisualStyleBackColor = true;
            this.buttonManageConversions.Click += new System.EventHandler(this.buttonManageConversions_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonExit.Location = new System.Drawing.Point(644, 473);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(89, 28);
            this.buttonExit.TabIndex = 8;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // frmConversion
            // 
            this.AcceptButton = this.buttonConvert;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonExit;
            this.ClientSize = new System.Drawing.Size(791, 540);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonManageConversions);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.textBoxValue);
            this.Controls.Add(this.listBoxResults);
            this.Controls.Add(this.listBoxConversions);
            this.Controls.Add(this.labelConversions);
            this.Controls.Add(this.labelValue);
            this.Name = "frmConversion";
            this.Text = "Conversions";
            this.Load += new System.EventHandler(this.frmConversion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.Label labelConversions;
        private System.Windows.Forms.ListBox listBoxConversions;
        private System.Windows.Forms.ListBox listBoxResults;
        private System.Windows.Forms.TextBox textBoxValue;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonManageConversions;
        private System.Windows.Forms.Button buttonExit;
    }
}

