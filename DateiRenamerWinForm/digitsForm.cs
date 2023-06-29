using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateiRenamerWinForm
{
    public partial class digitsForm : Form
    {
        public digitsForm()
        {
            InitializeComponent();
        }

        public string userAction
        {
            get; // makes the property read-only for public use
            private set; // makes the property writable within this class (private)
        }

        public int userOption
        {
            get; 
            private set;
        }

        private void moveDigitsStartBtn_Click(object sender, EventArgs e)
        {
            userAction = "moveDigits";
            userOption = 0;
            this.Close();
        }

        private void moveDigitsEndBtn_Click(object sender, EventArgs e)
        {
            userAction = "moveDigits";
            userOption = 1;
            this.Close();
        }
    }
}
