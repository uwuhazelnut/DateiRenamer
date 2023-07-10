namespace DateiRenamerWinForm
{
    partial class suffixForm
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
            suffixFormOkBtn = new Button();
            newSuffixLbl = new Label();
            oldSuffixLbl = new Label();
            newSuffixTxt = new TextBox();
            oldSuffixTxt = new TextBox();
            SuspendLayout();
            // 
            // suffixFormOkBtn
            // 
            suffixFormOkBtn.DialogResult = DialogResult.OK;
            suffixFormOkBtn.Location = new Point(478, 118);
            suffixFormOkBtn.Margin = new Padding(2);
            suffixFormOkBtn.Name = "suffixFormOkBtn";
            suffixFormOkBtn.Size = new Size(94, 23);
            suffixFormOkBtn.TabIndex = 9;
            suffixFormOkBtn.Text = "OK";
            suffixFormOkBtn.UseVisualStyleBackColor = true;
            // 
            // newSuffixLbl
            // 
            newSuffixLbl.AutoSize = true;
            newSuffixLbl.Location = new Point(20, 79);
            newSuffixLbl.Margin = new Padding(2, 0, 2, 0);
            newSuffixLbl.Name = "newSuffixLbl";
            newSuffixLbl.Size = new Size(376, 15);
            newSuffixLbl.TabIndex = 8;
            newSuffixLbl.Text = "Neuer Suffix (leer lassen wenn nur der alte Suffix gelöscht werden soll)";
            // 
            // oldSuffixLbl
            // 
            oldSuffixLbl.AutoSize = true;
            oldSuffixLbl.Location = new Point(20, 25);
            oldSuffixLbl.Margin = new Padding(2, 0, 2, 0);
            oldSuffixLbl.Name = "oldSuffixLbl";
            oldSuffixLbl.Size = new Size(441, 15);
            oldSuffixLbl.TabIndex = 7;
            oldSuffixLbl.Text = "Suffix, der ersetzt werden soll (leer lassen wenn nur Suffix hinzugefügt werden soll)";
            // 
            // newSuffixTxt
            // 
            newSuffixTxt.Location = new Point(20, 95);
            newSuffixTxt.Margin = new Padding(2);
            newSuffixTxt.Name = "newSuffixTxt";
            newSuffixTxt.Size = new Size(372, 23);
            newSuffixTxt.TabIndex = 6;
            // 
            // oldSuffixTxt
            // 
            oldSuffixTxt.Location = new Point(20, 42);
            oldSuffixTxt.Margin = new Padding(2);
            oldSuffixTxt.Name = "oldSuffixTxt";
            oldSuffixTxt.Size = new Size(372, 23);
            oldSuffixTxt.TabIndex = 5;
            // 
            // suffixForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(580, 148);
            Controls.Add(suffixFormOkBtn);
            Controls.Add(newSuffixLbl);
            Controls.Add(oldSuffixLbl);
            Controls.Add(newSuffixTxt);
            Controls.Add(oldSuffixTxt);
            Margin = new Padding(2);
            Name = "suffixForm";
            Text = "Suffix ändern";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button suffixFormOkBtn;
        private Label newSuffixLbl;
        private Label oldSuffixLbl;
        private TextBox newSuffixTxt;
        private TextBox oldSuffixTxt;
    }
}