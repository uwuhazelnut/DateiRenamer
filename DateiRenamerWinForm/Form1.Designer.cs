﻿namespace DateiRenamerWinForm
{
    partial class Form1
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
            SuspendLayout();
            // 
            // filesListBox
            // 
            filesListBox.FormattingEnabled = true;
            filesListBox.HorizontalScrollbar = true;
            filesListBox.ItemHeight = 25;
            filesListBox.Items.AddRange(new object[] { "test1", "test2", "test3", "test4", "test", "", "test", "test", "test", "test", "test", "test", "zzz" });
            filesListBox.Location = new Point(12, 12);
            filesListBox.Name = "filesListBox";
            filesListBox.Size = new Size(260, 429);
            filesListBox.TabIndex = 1;
            filesListBox.SelectedIndexChanged += filesListBox_SelectedIndexChanged;
            // 
            // addFileToListBtn
            // 
            addFileToListBtn.Location = new Point(307, 96);
            addFileToListBtn.Name = "addFileToListBtn";
            addFileToListBtn.Size = new Size(134, 38);
            addFileToListBtn.TabIndex = 2;
            addFileToListBtn.Text = "Add";
            addFileToListBtn.UseVisualStyleBackColor = true;
            addFileToListBtn.Click += addFileToListBtn_Click;
            // 
            // button1
            // 
            button1.Location = new Point(307, 140);
            button1.Name = "button1";
            button1.Size = new Size(134, 38);
            button1.TabIndex = 3;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // fileDialogBtn
            // 
            fileDialogBtn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            fileDialogBtn.Location = new Point(684, 37);
            fileDialogBtn.Name = "fileDialogBtn";
            fileDialogBtn.Size = new Size(32, 32);
            fileDialogBtn.TabIndex = 4;
            fileDialogBtn.Text = "…";
            fileDialogBtn.UseVisualStyleBackColor = true;
            fileDialogBtn.Click += fileDialogBtn_Click;
            // 
            // folderPathTxt
            // 
            folderPathTxt.Location = new Point(307, 38);
            folderPathTxt.Name = "folderPathTxt";
            folderPathTxt.Size = new Size(371, 31);
            folderPathTxt.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(folderPathTxt);
            Controls.Add(fileDialogBtn);
            Controls.Add(button1);
            Controls.Add(addFileToListBtn);
            Controls.Add(filesListBox);
            Name = "Form1";
            Text = "Form1";
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
    }
}