namespace DateiRenamerWinForm
{
    partial class removeDigitsConflictForm
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
            conflictFilesListBox = new ListBox();
            removeDigitsConlictFormOkBtn = new Button();
            conflictFilesListBoxLbl = new Label();
            SuspendLayout();
            // 
            // conflictFilesListBox
            // 
            conflictFilesListBox.FormattingEnabled = true;
            conflictFilesListBox.HorizontalScrollbar = true;
            conflictFilesListBox.ItemHeight = 15;
            conflictFilesListBox.Location = new Point(12, 27);
            conflictFilesListBox.Name = "conflictFilesListBox";
            conflictFilesListBox.Size = new Size(535, 274);
            conflictFilesListBox.TabIndex = 0;
            // 
            // removeDigitsConlictFormOkBtn
            // 
            removeDigitsConlictFormOkBtn.DialogResult = DialogResult.OK;
            removeDigitsConlictFormOkBtn.Location = new Point(586, 323);
            removeDigitsConlictFormOkBtn.Margin = new Padding(2);
            removeDigitsConlictFormOkBtn.Name = "removeDigitsConlictFormOkBtn";
            removeDigitsConlictFormOkBtn.Size = new Size(94, 23);
            removeDigitsConlictFormOkBtn.TabIndex = 5;
            removeDigitsConlictFormOkBtn.Text = "OK";
            removeDigitsConlictFormOkBtn.UseVisualStyleBackColor = true;
            // 
            // conflictFilesListBoxLbl
            // 
            conflictFilesListBoxLbl.AutoSize = true;
            conflictFilesListBoxLbl.Location = new Point(12, 9);
            conflictFilesListBoxLbl.Name = "conflictFilesListBoxLbl";
            conflictFilesListBoxLbl.Size = new Size(517, 15);
            conflictFilesListBoxLbl.TabIndex = 6;
            conflictFilesListBoxLbl.Text = "Folgende Dateien wurden übersprungen, da Konflikte mit bereits vorhandenen Dateien bestehen:";
            // 
            // removeDigitsConflictForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(691, 357);
            Controls.Add(conflictFilesListBoxLbl);
            Controls.Add(removeDigitsConlictFormOkBtn);
            Controls.Add(conflictFilesListBox);
            Name = "removeDigitsConflictForm";
            Text = "Konflikte in Dateinamen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button removeDigitsConlictFormOkBtn;
        private Label conflictFilesListBoxLbl;
        public ListBox conflictFilesListBox;
    }
}