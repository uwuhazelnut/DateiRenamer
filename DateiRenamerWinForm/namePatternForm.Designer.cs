namespace DateiRenamerWinForm
{
    partial class namePatternForm
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
            namePatternLbl = new Label();
            namePatternTxt = new TextBox();
            namePatternFormOkBtn = new Button();
            SuspendLayout();
            // 
            // namePatternLbl
            // 
            namePatternLbl.AutoSize = true;
            namePatternLbl.Location = new Point(8, 5);
            namePatternLbl.Margin = new Padding(2, 0, 2, 0);
            namePatternLbl.Name = "namePatternLbl";
            namePatternLbl.Size = new Size(326, 45);
            namePatternLbl.TabIndex = 0;
            namePatternLbl.Text = "Muster eingeben, das für alle Dateien verwendet werden soll \r\n(alle Dateinamen werden mit diesem Muster ersetzt)\r\nBeispiel: 'file-' führt zum Muster 'file-1', 'file-2', ...:";
            // 
            // namePatternTxt
            // 
            namePatternTxt.Location = new Point(8, 55);
            namePatternTxt.Margin = new Padding(2);
            namePatternTxt.Name = "namePatternTxt";
            namePatternTxt.Size = new Size(301, 23);
            namePatternTxt.TabIndex = 1;
            // 
            // namePatternFormOkBtn
            // 
            namePatternFormOkBtn.DialogResult = DialogResult.OK;
            namePatternFormOkBtn.Location = new Point(458, 86);
            namePatternFormOkBtn.Margin = new Padding(2);
            namePatternFormOkBtn.Name = "namePatternFormOkBtn";
            namePatternFormOkBtn.Size = new Size(94, 23);
            namePatternFormOkBtn.TabIndex = 5;
            namePatternFormOkBtn.Text = "OK";
            namePatternFormOkBtn.UseVisualStyleBackColor = true;
            // 
            // namePatternForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(560, 116);
            Controls.Add(namePatternFormOkBtn);
            Controls.Add(namePatternTxt);
            Controls.Add(namePatternLbl);
            Margin = new Padding(2);
            Name = "namePatternForm";
            Text = "namePatternForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label namePatternLbl;
        private TextBox namePatternTxt;
        private Button namePatternFormOkBtn;
    }
}