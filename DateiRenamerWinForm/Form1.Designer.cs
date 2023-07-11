namespace DateiRenamerWinForm
{
    partial class dateiRenamerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            filesListBox = new ListBox();
            folderBrowserDialog = new FolderBrowserDialog();
            fileDialogBtn = new Button();
            folderPathTxt = new TextBox();
            filePathLbl = new Label();
            changePrefixBtn = new Button();
            filesListBoxLbl = new Label();
            changeSuffixBtn = new Button();
            changeDigitsBtn = new Button();
            namePatternBtn = new Button();
            SuspendLayout();
            // 
            // filesListBox
            // 
            filesListBox.FormattingEnabled = true;
            filesListBox.HorizontalScrollbar = true;
            filesListBox.ItemHeight = 15;
            filesListBox.Location = new Point(8, 22);
            filesListBox.Margin = new Padding(2);
            filesListBox.Name = "filesListBox";
            filesListBox.Size = new Size(382, 469);
            filesListBox.TabIndex = 1;
            filesListBox.SelectedIndexChanged += filesListBox_SelectedIndexChanged;
            // 
            // folderBrowserDialog
            // 
            folderBrowserDialog.Description = "Ordner mit Dateien auswählen";
            // 
            // fileDialogBtn
            // 
            fileDialogBtn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            fileDialogBtn.Location = new Point(723, 22);
            fileDialogBtn.Margin = new Padding(2);
            fileDialogBtn.Name = "fileDialogBtn";
            fileDialogBtn.Size = new Size(22, 19);
            fileDialogBtn.TabIndex = 4;
            fileDialogBtn.Text = "…";
            fileDialogBtn.UseVisualStyleBackColor = true;
            fileDialogBtn.Click += fileDialogBtn_Click;
            // 
            // folderPathTxt
            // 
            folderPathTxt.Location = new Point(424, 24);
            folderPathTxt.Margin = new Padding(2);
            folderPathTxt.Name = "folderPathTxt";
            folderPathTxt.ReadOnly = true;
            folderPathTxt.Size = new Size(295, 23);
            folderPathTxt.TabIndex = 5;
            // 
            // filePathLbl
            // 
            filePathLbl.AutoSize = true;
            filePathLbl.Location = new Point(424, 7);
            filePathLbl.Margin = new Padding(2, 0, 2, 0);
            filePathLbl.Name = "filePathLbl";
            filePathLbl.Size = new Size(214, 15);
            filePathLbl.TabIndex = 6;
            filePathLbl.Text = "Dateipfad (über den Button auswählen)";
            // 
            // changePrefixBtn
            // 
            changePrefixBtn.Location = new Point(424, 51);
            changePrefixBtn.Margin = new Padding(2);
            changePrefixBtn.Name = "changePrefixBtn";
            changePrefixBtn.Size = new Size(146, 23);
            changePrefixBtn.TabIndex = 7;
            changePrefixBtn.Text = "Präfix ändern";
            changePrefixBtn.UseVisualStyleBackColor = true;
            changePrefixBtn.Click += changePrefixBtn_Click;
            // 
            // filesListBoxLbl
            // 
            filesListBoxLbl.AutoSize = true;
            filesListBoxLbl.Location = new Point(8, 5);
            filesListBoxLbl.Margin = new Padding(2, 0, 2, 0);
            filesListBoxLbl.Name = "filesListBoxLbl";
            filesListBoxLbl.Size = new Size(50, 15);
            filesListBoxLbl.TabIndex = 8;
            filesListBoxLbl.Text = "Dateien:";
            // 
            // changeSuffixBtn
            // 
            changeSuffixBtn.Location = new Point(424, 78);
            changeSuffixBtn.Margin = new Padding(2);
            changeSuffixBtn.Name = "changeSuffixBtn";
            changeSuffixBtn.Size = new Size(146, 23);
            changeSuffixBtn.TabIndex = 9;
            changeSuffixBtn.Text = "Suffix ändern";
            changeSuffixBtn.UseVisualStyleBackColor = true;
            changeSuffixBtn.Click += changeSuffixBtn_Click;
            // 
            // changeDigitsBtn
            // 
            changeDigitsBtn.Location = new Point(424, 104);
            changeDigitsBtn.Margin = new Padding(2);
            changeDigitsBtn.Name = "changeDigitsBtn";
            changeDigitsBtn.Size = new Size(146, 23);
            changeDigitsBtn.TabIndex = 10;
            changeDigitsBtn.Text = "Zahlen ändern";
            changeDigitsBtn.UseVisualStyleBackColor = true;
            changeDigitsBtn.Click += changeDigitsBtn_Click;
            // 
            // namePatternBtn
            // 
            namePatternBtn.Location = new Point(424, 130);
            namePatternBtn.Margin = new Padding(2);
            namePatternBtn.Name = "namePatternBtn";
            namePatternBtn.Size = new Size(146, 23);
            namePatternBtn.TabIndex = 11;
            namePatternBtn.Text = "Musternamen erstellen";
            namePatternBtn.UseVisualStyleBackColor = true;
            namePatternBtn.Click += namePatternBtn_Click;
            // 
            // dateiRenamerForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(823, 505);
            Controls.Add(namePatternBtn);
            Controls.Add(changeDigitsBtn);
            Controls.Add(changeSuffixBtn);
            Controls.Add(filesListBoxLbl);
            Controls.Add(changePrefixBtn);
            Controls.Add(filePathLbl);
            Controls.Add(folderPathTxt);
            Controls.Add(fileDialogBtn);
            Controls.Add(filesListBox);
            Margin = new Padding(2);
            Name = "dateiRenamerForm";
            Text = "DateiRenamer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox filesListBox;
        private FolderBrowserDialog folderBrowserDialog;
        private Button fileDialogBtn;
        private TextBox folderPathTxt;
        private Label filePathLbl;
        private Button changePrefixBtn;
        private Label filesListBoxLbl;
        private Button changeSuffixBtn;
        private Button changeDigitsBtn;
        private Button namePatternBtn;
    }
}