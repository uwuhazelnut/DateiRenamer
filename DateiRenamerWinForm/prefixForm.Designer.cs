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
            oldPrefixTxt.Location = new Point(29, 70);
            oldPrefixTxt.Name = "oldPrefixTxt";
            oldPrefixTxt.Size = new Size(529, 31);
            oldPrefixTxt.TabIndex = 0;
            // 
            // newPrefixTxt
            // 
            newPrefixTxt.Location = new Point(29, 159);
            newPrefixTxt.Name = "newPrefixTxt";
            newPrefixTxt.Size = new Size(529, 31);
            newPrefixTxt.TabIndex = 1;
            // 
            // oldPrefixLbl
            // 
            oldPrefixLbl.AutoSize = true;
            oldPrefixLbl.Location = new Point(29, 42);
            oldPrefixLbl.Name = "oldPrefixLbl";
            oldPrefixLbl.Size = new Size(659, 25);
            oldPrefixLbl.TabIndex = 2;
            oldPrefixLbl.Text = "Präfix, der ersetzt werden soll (leer lassen wenn nur Präfix hinzugefügt werden soll)";
            // 
            // newPrefixLbl
            // 
            newPrefixLbl.AutoSize = true;
            newPrefixLbl.Location = new Point(29, 131);
            newPrefixLbl.Name = "newPrefixLbl";
            newPrefixLbl.Size = new Size(560, 25);
            newPrefixLbl.TabIndex = 3;
            newPrefixLbl.Text = "Neuer Präfix (leer lassen wenn nur der alte Präfix gelöscht werden soll)";
            // 
            // prefixFormOkBtn
            // 
            prefixFormOkBtn.DialogResult = DialogResult.OK;
            prefixFormOkBtn.Location = new Point(683, 197);
            prefixFormOkBtn.Name = "prefixFormOkBtn";
            prefixFormOkBtn.Size = new Size(134, 38);
            prefixFormOkBtn.TabIndex = 4;
            prefixFormOkBtn.Text = "OK";
            prefixFormOkBtn.UseVisualStyleBackColor = true;
            // 
            // prefixForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 247);
            Controls.Add(prefixFormOkBtn);
            Controls.Add(newPrefixLbl);
            Controls.Add(oldPrefixLbl);
            Controls.Add(newPrefixTxt);
            Controls.Add(oldPrefixTxt);
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