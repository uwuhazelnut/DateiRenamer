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
    public partial class removeDigitsConflictForm : Form
    {
        public removeDigitsConflictForm()
        {
            InitializeComponent();
        }

        public void addItemToListBox(string item)
        {
            conflictFilesListBox.Items.Add(item);
        }

        public void clearListBox()
        {
            conflictFilesListBox.Items.Clear();
        }
    }
}
