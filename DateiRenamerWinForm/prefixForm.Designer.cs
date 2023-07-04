namespace DateiRenamerWinForm
{
    partial class prefixForm
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
            oldPrefixTxt = new TextBox();
            newPrefixTxt = new TextBox();
            oldPrefixLbl = new Label();
            newPrefixLbl = new Label();
            prefixFormOkBtn = new Button();
            SuspendLayout();
            // 
            // oldPrefixTxt
            // 
            oldPrefixTxt.Location = new Point(20, 42);
            oldPrefixTxt.Margin = new Padding(2, 2, 2, 2);
            oldPrefixTxt.Name = "oldPrefixTxt";
            oldPrefixTxt.Size = new Size(372, 23);
            oldPrefixTxt.TabIndex = 0;
            // 
            // newPrefixTxt
            // 
            newPrefixTxt.Location = new Point(20, 95);
            newPrefixTxt.Margin = new Padding(2, 2, 2, 2);
            newPrefixTxt.Name = "newPrefixTxt";
            newPrefixTxt.Size = new Size(372, 23);
            newPrefixTxt.TabIndex = 1;
            // 
            // oldPrefixLbl
            // 
            oldPrefixLbl.AutoSize = true;
            oldPrefixLbl.Location = new Point(20, 25);
            oldPrefixLbl.Margin = new Padding(2, 0, 2, 0);
            oldPrefixLbl.Name = "oldPrefixLbl";
            oldPrefixLbl.Size = new Size(441, 15);
            oldPrefixLbl.TabIndex = 2;
            oldPrefixLbl.Text = "Präfix, der ersetzt werden soll (leer lassen wenn nur Präfix hinzugefügt werden soll)";
            // 
            // newPrefixLbl
            // 
            newPrefixLbl.AutoSize = true;
            newPrefixLbl.Location = new Point(20, 79);
            newPrefixLbl.Margin = new Padding(2, 0, 2, 0);
            newPrefixLbl.Name = "newPrefixLbl";
            newPrefixLbl.Size = new Size(376, 15);
            newPrefixLbl.TabIndex = 3;
            newPrefixLbl.Text = "Neuer Präfix (leer lassen wenn nur der alte Präfix gelöscht werden soll)";
            // 
            // prefixFormOkBtn
            // 
            prefixFormOkBtn.DialogResult = DialogResult.OK;
            prefixFormOkBtn.Location = new Point(478, 118);
            prefixFormOkBtn.Margin = new Padding(2, 2, 2, 2);
            prefixFormOkBtn.Name = "prefixFormOkBtn";
            prefixFormOkBtn.Size = new Size(94, 23);
            prefixFormOkBtn.TabIndex = 4;
            prefixFormOkBtn.Text = "OK";
            prefixFormOkBtn.UseVisualStyleBackColor = true;
            // 
            // prefixForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(580, 148);
            Controls.Add(prefixFormOkBtn);
            Controls.Add(newPrefixLbl);
            Controls.Add(oldPrefixLbl);
            Controls.Add(newPrefixTxt);
            Controls.Add(oldPrefixTxt);
            Margin = new Padding(2, 2, 2, 2);
            Name = "prefixForm";
            Text = "prefixForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox oldPrefixTxt;
        private TextBox newPrefixTxt;
        private Label oldPrefixLbl;
        private Label newPrefixLbl;
        private Button prefixFormOkBtn;
    }
}