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

        private void PopulateListBox(string directoryPath)
        {
            filesListBox.Items.Clear();

            try
            {
                string[] files = Directory.GetFiles(directoryPath, "*", SearchOption.AllDirectories);

                foreach (string file in files)
                {
                    string fileName = Path.GetFileName(file);
                    filesListBox.Items.Add(fileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ein Fehler ist aufgetreten: " + ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fileDialogBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
            {
                folderPathTxt.Text = folderBrowserDialog.SelectedPath;
                PopulateListBox(folderBrowserDialog.SelectedPath);
            }
        }
    }
}