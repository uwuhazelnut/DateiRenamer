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
            suffixFormOkBtn.Location = new Point(683, 197);
            suffixFormOkBtn.Name = "suffixFormOkBtn";
            suffixFormOkBtn.Size = new Size(134, 38);
            suffixFormOkBtn.TabIndex = 9;
            suffixFormOkBtn.Text = "OK";
            suffixFormOkBtn.UseVisualStyleBackColor = true;
            // 
            // newSuffixLbl
            // 
            newSuffixLbl.AutoSize = true;
            newSuffixLbl.Location = new Point(29, 131);
            newSuffixLbl.Name = "newSuffixLbl";
            newSuffixLbl.Size = new Size(562, 25);
            newSuffixLbl.TabIndex = 8;
            newSuffixLbl.Text = "Neuer Suffix (leer lassen wenn nur der alte Suffix gelöscht werden soll)";
            // 
            // oldSuffixLbl
            // 
            oldSuffixLbl.AutoSize = true;
            oldSuffixLbl.Location = new Point(29, 42);
            oldSuffixLbl.Name = "oldSuffixLbl";
            oldSuffixLbl.Size = new Size(661, 25);
            oldSuffixLbl.TabIndex = 7;
            oldSuffixLbl.Text = "Suffix, der ersetzt werden soll (leer lassen wenn nur Suffix hinzugefügt werden soll)";
            // 
            // newSuffixTxt
            // 
            newSuffixTxt.Location = new Point(29, 159);
            newSuffixTxt.Name = "newSuffixTxt";
            newSuffixTxt.Size = new Size(529, 31);
            newSuffixTxt.TabIndex = 6;
            // 
            // oldSuffixTxt
            // 
            oldSuffixTxt.Location = new Point(29, 70);
            oldSuffixTxt.Name = "oldSuffixTxt";
            oldSuffixTxt.Size = new Size(529, 31);
            oldSuffixTxt.TabIndex = 5;
            // 
            // suffixForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 247);
            Controls.Add(suffixFormOkBtn);
            Controls.Add(newSuffixLbl);
            Controls.Add(oldSuffixLbl);
            Controls.Add(newSuffixTxt);
            Controls.Add(oldSuffixTxt);
            Name = "suffixForm";
            Text = "suffixForm";
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