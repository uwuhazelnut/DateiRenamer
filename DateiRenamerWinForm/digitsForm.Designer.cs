namespace DateiRenamerWinForm
{
    partial class digitsForm
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
            moveDigitsLbl = new Label();
            moveDigitsStartBtn = new Button();
            moveDigitsEndBtn = new Button();
            SuspendLayout();
            // 
            // moveDigitsLbl
            // 
            moveDigitsLbl.AutoSize = true;
            moveDigitsLbl.Location = new Point(8, 5);
            moveDigitsLbl.Margin = new Padding(2, 0, 2, 0);
            moveDigitsLbl.Name = "moveDigitsLbl";
            moveDigitsLbl.Size = new Size(141, 15);
            moveDigitsLbl.TabIndex = 0;
            moveDigitsLbl.Text = "Zahlenblock verschieben:";
            // 
            // moveDigitsStartBtn
            // 
            moveDigitsStartBtn.Location = new Point(8, 22);
            moveDigitsStartBtn.Margin = new Padding(2, 2, 2, 2);
            moveDigitsStartBtn.Name = "moveDigitsStartBtn";
            moveDigitsStartBtn.Size = new Size(120, 23);
            moveDigitsStartBtn.TabIndex = 8;
            moveDigitsStartBtn.Text = "an den Anfang";
            moveDigitsStartBtn.UseVisualStyleBackColor = true;
            moveDigitsStartBtn.Click += moveDigitsStartBtn_Click;
            // 
            // moveDigitsEndBtn
            // 
            moveDigitsEndBtn.Location = new Point(132, 22);
            moveDigitsEndBtn.Margin = new Padding(2, 2, 2, 2);
            moveDigitsEndBtn.Name = "moveDigitsEndBtn";
            moveDigitsEndBtn.Size = new Size(120, 23);
            moveDigitsEndBtn.TabIndex = 9;
            moveDigitsEndBtn.Text = "an das Ende";
            moveDigitsEndBtn.UseVisualStyleBackColor = true;
            moveDigitsEndBtn.Click += moveDigitsEndBtn_Click;
            // 
            // digitsForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(560, 270);
            Controls.Add(moveDigitsEndBtn);
            Controls.Add(moveDigitsStartBtn);
            Controls.Add(moveDigitsLbl);
            Margin = new Padding(2, 2, 2, 2);
            Name = "digitsForm";
            Text = "digitsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label moveDigitsLbl;
        private Button moveDigitsStartBtn;
        private Button moveDigitsEndBtn;
    }
}