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
            addDelDigitsLbl = new Label();
            addDigitsBtn = new Button();
            delDigitsBtn = new Button();
            addLeadingZerosBtn = new Button();
            addLeadingZerosLbl = new Label();
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
            moveDigitsStartBtn.Margin = new Padding(2);
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
            moveDigitsEndBtn.Margin = new Padding(2);
            moveDigitsEndBtn.Name = "moveDigitsEndBtn";
            moveDigitsEndBtn.Size = new Size(120, 23);
            moveDigitsEndBtn.TabIndex = 9;
            moveDigitsEndBtn.Text = "an das Ende";
            moveDigitsEndBtn.UseVisualStyleBackColor = true;
            moveDigitsEndBtn.Click += moveDigitsEndBtn_Click;
            // 
            // addDelDigitsLbl
            // 
            addDelDigitsLbl.AutoSize = true;
            addDelDigitsLbl.Location = new Point(8, 47);
            addDelDigitsLbl.Name = "addDelDigitsLbl";
            addDelDigitsLbl.Size = new Size(155, 15);
            addDelDigitsLbl.TabIndex = 10;
            addDelDigitsLbl.Text = "Zahlen hinzufügen/löschen:";
            // 
            // addDigitsBtn
            // 
            addDigitsBtn.Location = new Point(8, 64);
            addDigitsBtn.Margin = new Padding(2);
            addDigitsBtn.Name = "addDigitsBtn";
            addDigitsBtn.Size = new Size(120, 23);
            addDigitsBtn.TabIndex = 11;
            addDigitsBtn.Text = "Hinzufügen";
            addDigitsBtn.UseVisualStyleBackColor = true;
            addDigitsBtn.Click += addDigitsBtn_Click;
            // 
            // delDigitsBtn
            // 
            delDigitsBtn.Location = new Point(132, 64);
            delDigitsBtn.Margin = new Padding(2);
            delDigitsBtn.Name = "delDigitsBtn";
            delDigitsBtn.Size = new Size(120, 23);
            delDigitsBtn.TabIndex = 12;
            delDigitsBtn.Text = "Löschen";
            delDigitsBtn.UseVisualStyleBackColor = true;
            delDigitsBtn.Click += delDigitsLbl_Click;
            // 
            // addLeadingZerosBtn
            // 
            addLeadingZerosBtn.Location = new Point(8, 106);
            addLeadingZerosBtn.Margin = new Padding(2);
            addLeadingZerosBtn.Name = "addLeadingZerosBtn";
            addLeadingZerosBtn.Size = new Size(120, 23);
            addLeadingZerosBtn.TabIndex = 13;
            addLeadingZerosBtn.Text = "Einfügen";
            addLeadingZerosBtn.UseVisualStyleBackColor = true;
            addLeadingZerosBtn.Click += addLeadingZerosBtn_Click;
            // 
            // addLeadingZerosLbl
            // 
            addLeadingZerosLbl.AutoSize = true;
            addLeadingZerosLbl.Location = new Point(8, 89);
            addLeadingZerosLbl.Name = "addLeadingZerosLbl";
            addLeadingZerosLbl.Size = new Size(148, 15);
            addLeadingZerosLbl.TabIndex = 14;
            addLeadingZerosLbl.Text = "Führende Nullen einfügen:";
            // 
            // digitsForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(560, 270);
            Controls.Add(addLeadingZerosLbl);
            Controls.Add(addLeadingZerosBtn);
            Controls.Add(delDigitsBtn);
            Controls.Add(addDigitsBtn);
            Controls.Add(addDelDigitsLbl);
            Controls.Add(moveDigitsEndBtn);
            Controls.Add(moveDigitsStartBtn);
            Controls.Add(moveDigitsLbl);
            Margin = new Padding(2);
            Name = "digitsForm";
            Text = "Zahlen anpassen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label moveDigitsLbl;
        private Button moveDigitsStartBtn;
        private Button moveDigitsEndBtn;
        private Label addDelDigitsLbl;
        private Button addDigitsBtn;
        private Button delDigitsBtn;
        private Button addLeadingZerosBtn;
        private Label addLeadingZerosLbl;
    }
}