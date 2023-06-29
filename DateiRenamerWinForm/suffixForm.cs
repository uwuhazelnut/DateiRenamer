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
    public partial class suffixForm : Form
    {
        public suffixForm()
        {
            InitializeComponent();
        }

        public string oldSuffix
        {
            get { return oldSuffixTxt.Text; }
        }

        public string newSuffix
        {
            get { return newSuffixTxt.Text; }
        }
    }
}
