namespace DateiRenamerWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void filesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addFileToListBtn_Click(object sender, EventArgs e)
        {
            filesListBox.Items.Add("NEW ITEM");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            filesListBox.Items.Clear();
        }
    }
}