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
            addFileToListBtn = new Button();
            button1 = new Button();
            folderBrowserDialog = new FolderBrowserDialog();
            fileDialogBtn = new Button();
            folderPathTxt = new TextBox();
            filePathLbl = new Label();
            changePrefixBtn = new Button();
            filesListBoxLbl = new Label();
            changeSuffixBtn = new Button();
            SuspendLayout();
            // 
            // filesListBox
            // 
            filesListBox.FormattingEnabled = true;
            filesListBox.HorizontalScrollbar = true;
            filesListBox.ItemHeight = 25;
            filesListBox.Location = new Point(12, 37);
            filesListBox.Name = "filesListBox";
            filesListBox.Size = new Size(544, 779);
            filesListBox.TabIndex = 1;
            filesListBox.SelectedIndexChanged += filesListBox_SelectedIndexChanged;
            // 
            // addFileToListBtn
            // 
            addFileToListBtn.Location = new Point(605, 98);
            addFileToListBtn.Name = "addFileToListBtn";
            addFileToListBtn.Size = new Size(134, 38);
            addFileToListBtn.TabIndex = 2;
            addFileToListBtn.Text = "Add";
            addFileToListBtn.UseVisualStyleBackColor = true;
            addFileToListBtn.Click += addFileToListBtn_Click;
            // 
            // button1
            // 
            button1.Location = new Point(605, 142);
            button1.Name = "button1";
            button1.Size = new Size(134, 38);
            button1.TabIndex = 3;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // folderBrowserDialog
            // 
            folderBrowserDialog.Description = "Ordner mit Dateien auswählen";
            // 
            // fileDialogBtn
            // 
            fileDialogBtn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            fileDialogBtn.Location = new Point(982, 39);
            fileDialogBtn.Name = "fileDialogBtn";
            fileDialogBtn.Size = new Size(32, 32);
            fileDialogBtn.TabIndex = 4;
            fileDialogBtn.Text = "…";
            fileDialogBtn.UseVisualStyleBackColor = true;
            fileDialogBtn.Click += fileDialogBtn_Click;
            // 
            // folderPathTxt
            // 
            folderPathTxt.Location = new Point(605, 40);
            folderPathTxt.Name = "folderPathTxt";
            folderPathTxt.ReadOnly = true;
            folderPathTxt.Size = new Size(371, 31);
            folderPathTxt.TabIndex = 5;
            // 
            // filePathLbl
            // 
            filePathLbl.AutoSize = true;
            filePathLbl.Location = new Point(605, 12);
            filePathLbl.Name = "filePathLbl";
            filePathLbl.Size = new Size(321, 25);
            filePathLbl.TabIndex = 6;
            filePathLbl.Text = "Dateipfad (über den Button auswählen)";
            // 
            // changePrefixBtn
            // 
            changePrefixBtn.Location = new Point(863, 98);
            changePrefixBtn.Name = "changePrefixBtn";
            changePrefixBtn.Size = new Size(134, 38);
            changePrefixBtn.TabIndex = 7;
            changePrefixBtn.Text = "Präfix ändern";
            changePrefixBtn.UseVisualStyleBackColor = true;
            changePrefixBtn.Click += changePrefixBtn_Click;
            // 
            // filesListBoxLbl
            // 
            filesListBoxLbl.AutoSize = true;
            filesListBoxLbl.Location = new Point(12, 9);
            filesListBoxLbl.Name = "filesListBoxLbl";
            filesListBoxLbl.Size = new Size(76, 25);
            filesListBoxLbl.TabIndex = 8;
            filesListBoxLbl.Text = "Dateien:";
            // 
            // changeSuffixBtn
            // 
            changeSuffixBtn.Location = new Point(863, 142);
            changeSuffixBtn.Name = "changeSuffixBtn";
            changeSuffixBtn.Size = new Size(134, 38);
            changeSuffixBtn.TabIndex = 9;
            changeSuffixBtn.Text = "Suffix ändern";
            changeSuffixBtn.UseVisualStyleBackColor = true;
            changeSuffixBtn.Click += changeSuffixBtn_Click;
            // 
            // dateiRenamerForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1422, 841);
            Controls.Add(changeSuffixBtn);
            Controls.Add(filesListBoxLbl);
            Controls.Add(changePrefixBtn);
            Controls.Add(filePathLbl);
            Controls.Add(folderPathTxt);
            Controls.Add(fileDialogBtn);
            Controls.Add(button1);
            Controls.Add(addFileToListBtn);
            Controls.Add(filesListBox);
            Name = "dateiRenamerForm";
            Text = "DateiRenamer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox filesListBox;
        private Button addFileToListBtn;
        private Button button1;
        private FolderBrowserDialog folderBrowserDialog;
        private Button fileDialogBtn;
        private TextBox folderPathTxt;
        private Label filePathLbl;
        private Button changePrefixBtn;
        private Label filesListBoxLbl;
        private Button changeSuffixBtn;
    }
}