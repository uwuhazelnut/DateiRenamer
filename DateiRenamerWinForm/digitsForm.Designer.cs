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
            moveDigitsLbl.Location = new Point(12, 9);
            moveDigitsLbl.Name = "moveDigitsLbl";
            moveDigitsLbl.Size = new Size(209, 25);
            moveDigitsLbl.TabIndex = 0;
            moveDigitsLbl.Text = "Zahlenblock verschieben:";
            // 
            // moveDigitsStartBtn
            // 
            moveDigitsStartBtn.Location = new Point(12, 37);
            moveDigitsStartBtn.Name = "moveDigitsStartBtn";
            moveDigitsStartBtn.Size = new Size(171, 38);
            moveDigitsStartBtn.TabIndex = 8;
            moveDigitsStartBtn.Text = "an den Anfang";
            moveDigitsStartBtn.UseVisualStyleBackColor = true;
            moveDigitsStartBtn.Click += moveDigitsStartBtn_Click;
            // 
            // moveDigitsEndBtn
            // 
            moveDigitsEndBtn.Location = new Point(189, 37);
            moveDigitsEndBtn.Name = "moveDigitsEndBtn";
            moveDigitsEndBtn.Size = new Size(171, 38);
            moveDigitsEndBtn.TabIndex = 9;
            moveDigitsEndBtn.Text = "an das Ende";
            moveDigitsEndBtn.UseVisualStyleBackColor = true;
            moveDigitsEndBtn.Click += moveDigitsEndBtn_Click;
            // 
            // digitsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(moveDigitsEndBtn);
            Controls.Add(moveDigitsStartBtn);
            Controls.Add(moveDigitsLbl);
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