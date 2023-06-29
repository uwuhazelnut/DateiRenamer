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
    public partial class namePatternForm : Form
    {
        public namePatternForm()
        {
            InitializeComponent();
        }

        public string userPattern
        {
            get { return namePatternTxt.Text; }
        }
    }
}
