using System.IO;
using System.Text.RegularExpressions;

namespace DateiRenamerWinForm
{
    public partial class dateiRenamerForm : Form
    {
        public dateiRenamerForm()
        {
            InitializeComponent();
        }

        private void filesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fileDialogBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
            {
                folderPathTxt.Text = folderBrowserDialog.SelectedPath;
                populateListBox(folderBrowserDialog.SelectedPath);
            }
        }

        private void populateListBox(string directoryPath)
        {
            filesListBox.Items.Clear();

            try
            {
                string[] files = Directory.GetFiles(directoryPath);

                foreach (string file in files)
                {
                    string fileName = Path.GetFileName(file);
                    filesListBox.Items.Add(fileName);
                }

                filesListBox.Items.Add("");
                filesListBox.Items.Add("Unterordner:");
                subdirectoryProcessor(new DirectoryInfo(directoryPath));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ein Fehler ist aufgetreten: " + ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void subdirectoryProcessor(DirectoryInfo directory)
        {
            DirectoryInfo[] subDirectories = directory.GetDirectories(); // `DirectoryInfo` provides methods to work with directories

            foreach (DirectoryInfo subDirectory in subDirectories)
            {
                filesListBox.Items.Add(subDirectory.FullName + ":");

                // Add all file names in the subdirectory:
                foreach (string filePath in Directory.GetFiles(subDirectory.FullName))
                {
                    filesListBox.Items.Add(Path.GetFileName(filePath));
                }

                filesListBox.Items.Add("");

                // Recursively process subdirectories of the subdirectory:
                subdirectoryProcessor(subDirectory);
            }
        }

        private void changePrefixBtn_Click(object sender, EventArgs e)
        {
            prefixForm prefixForm = new prefixForm();
            if (prefixForm.ShowDialog() == DialogResult.OK)
            {
                string oldPrefix = prefixForm.oldPrefix;
                string newPrefix = prefixForm.newPrefix;

                try
                {
                    string directoryPath = folderPathTxt.Text;
                    prefixProcessor(new DirectoryInfo(directoryPath), oldPrefix, newPrefix);
                    populateListBox(directoryPath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ein Fehler ist aufgetreten: " + ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void prefixProcessor(DirectoryInfo directory, string oldPrefix, string newPrefix)
        {
            FileInfo[] files = directory.GetFiles(); // `FileInfo[]` provides methods to work with files

            foreach (FileInfo file in files)
            {
                string oldFileName = file.Name;
                string newFileName;
                oldFileName = oldFileName.Trim(); // Remove all leading and trailing white spaces to allow for proper processing

                if (!string.IsNullOrEmpty(oldPrefix) && oldFileName.StartsWith(oldPrefix))
                {
                    newFileName = oldFileName.Replace(oldPrefix, newPrefix); // REMINDER COMMENT: The string.Replace() function could be used to replace any part of the file name, not just the prefix
                }
                else
                {
                    newFileName = newPrefix + oldFileName;
                }

                newFileName = newFileName.Trim();
                string newPath = Path.Combine(directory.FullName, newFileName); // Create new file path from the new file name
                file.MoveTo(newPath);
            }

            //Create recursion for sub-directory processing:
            DirectoryInfo[] subDirectories = directory.GetDirectories();
            foreach (DirectoryInfo subDirectory in subDirectories)
            {
                prefixProcessor(subDirectory, oldPrefix, newPrefix);
            }
        }

        private void changeSuffixBtn_Click(object sender, EventArgs e)
        {
            suffixForm suffixForm = new suffixForm();
            if (suffixForm.ShowDialog() == DialogResult.OK)
            {
                string oldSuffix = suffixForm.oldSuffix;
                string newSuffix = suffixForm.newSuffix;

                try
                {
                    string directoryPath = folderPathTxt.Text;
                    suffixProcessor(new DirectoryInfo(directoryPath), oldSuffix, newSuffix);
                    populateListBox(directoryPath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ein Fehler ist aufgetreten: " + ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void suffixProcessor(DirectoryInfo directory, string oldSuffix, string newSuffix)
        {
            FileInfo[] files = directory.GetFiles();

            foreach (FileInfo file in files)
            {
                string oldFileName = Path.GetFileNameWithoutExtension(file.FullName);
                string fileExtension = file.Extension;
                string newFileName;
                oldFileName = oldFileName.Trim();

                if (!string.IsNullOrEmpty(oldSuffix) && oldFileName.EndsWith(oldSuffix))
                {
                    newFileName = oldFileName.Replace(oldSuffix, newSuffix); // REMINDER COMMENT: The string.Replace() function could be used to replace any part of the file name, not just the suffix
                }
                else
                {
                    newFileName = oldFileName + newSuffix;
                }

                newFileName = newFileName.Trim();
                string newPath = Path.Combine(directory.FullName, newFileName + fileExtension);
                file.MoveTo(newPath);
            }

            DirectoryInfo[] subDirectories = directory.GetDirectories();
            foreach (DirectoryInfo subDirectory in subDirectories)
            {
                suffixProcessor(subDirectory, oldSuffix, newSuffix);
            }
        }

        private void changeDigitsBtn_Click(object sender, EventArgs e)
        {
            digitsForm digitsForm = new digitsForm();
            digitsForm.ShowDialog();

            if (!string.IsNullOrWhiteSpace(digitsForm.userAction))
            {
                try
                {
                    string userAction = digitsForm.userAction;
                    string directoryPath = folderPathTxt.Text;

                    switch (userAction)
                    {
                        case "moveDigits":
                            int userOptionMoveDigits = digitsForm.userOption;
                            moveDigitsProcessor(new DirectoryInfo(directoryPath), userOptionMoveDigits);
                            break;
                        case "addDelDigitsAddLeadingZeros":
                            int userOptionAddDelDigitsAddLeadingZeros = digitsForm.userOption;
                            editDigitsProcessor(directoryPath, userOptionAddDelDigitsAddLeadingZeros);
                            break;
                    }

                    populateListBox(directoryPath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ein Fehler ist aufgetreten: " + ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void moveDigitsProcessor(DirectoryInfo directory, int userOption)
        {
            FileInfo[] files = directory.GetFiles();

            foreach (FileInfo file in files)
            {
                string fileName = Path.GetFileNameWithoutExtension(file.FullName); // Get file name without extension to allow for moving string to the end without modifying the file extension
                string fileExtension = Path.GetExtension(file.FullName);

                if (containsDigitBlock(fileName))
                {
                    // Use regular expression to find the digit block:
                    Match digitBlockMatch = Regex.Match(fileName, @"\d+");
                    string digitBlock = digitBlockMatch.Value;
                    string remainingFileName = fileName.Remove(digitBlockMatch.Index, digitBlockMatch.Length); // Removes the digit block from the file name using the Regex match information
                    string newFileName = string.Empty; // An empty string is necessary to remove a compiler error when creating the new file path later on

                    if (userOption == 0)
                    {
                        newFileName = digitBlock + remainingFileName; // Move digit block to beginning
                    }
                    else if (userOption == 1)
                    {
                        newFileName = remainingFileName + digitBlock; //Move digit block to end
                    }

                    string newPath = Path.Combine(directory.FullName, newFileName + fileExtension); // Reattach file extension to the file name
                    file.MoveTo(newPath);
                }
            }

            DirectoryInfo[] subDirectories = directory.GetDirectories();
            foreach (DirectoryInfo subDirectory in subDirectories)
            {
                moveDigitsProcessor(subDirectory, userOption);
            }
        }

        private bool containsDigitBlock(string fileName)
        {
            // Use regular expression to check if the filename contains a block of digits
            return Regex.IsMatch(fileName, @"\d+");
        }

        private void namePatternBtn_Click(object sender, EventArgs e)
        {
            namePatternForm namePatternForm = new namePatternForm();
            if (namePatternForm.ShowDialog() == DialogResult.OK)
            {
                string userPattern = namePatternForm.userPattern;

                try
                {
                    string directoryPath = folderPathTxt.Text;
                    namePatternProcessor(directoryPath, userPattern);
                    populateListBox(directoryPath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ein Fehler ist aufgetreten: " + ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void namePatternProcessor(string directoryPath, string userPattern)
        {
            string[] filePaths = Directory.GetFiles(directoryPath);
            Array.Sort(filePaths, (a, b) => File.GetCreationTime(a).CompareTo(File.GetCreationTime(b)));

            for (int i = 0; i < filePaths.Length; i++)
            {
                string filePath = filePaths[i];
                string fileExtension = Path.GetExtension(filePath);

                string newFileName = $"{userPattern}{i + 1}";
                string newPath = Path.Combine(directoryPath, newFileName + fileExtension);
                File.Move(filePath, newPath);
            }

            string[] subdirectoryPaths = Directory.GetDirectories(directoryPath);
            foreach (string subDirectory in subdirectoryPaths)
            {
                namePatternProcessor(subDirectory, userPattern);
            }
        }

        private void editDigitsProcessor(string directoryPath, int userOption)
        {
            string[] files = Directory.GetFiles(directoryPath);

            switch (userOption)
            {
                case 0:
                    //Sort the files depending on file creation time in ascending order (a lambda expression is used to properly sort the elements): 
                    Array.Sort(files, (a, b) => File.GetCreationTime(a).CompareTo(File.GetCreationTime(b)));

                    for (int i = 0; i < files.Length; i++)
                    {
                        string filePath = files[i];
                        string fileName = Path.GetFileNameWithoutExtension(filePath);
                        string fileExtension = Path.GetExtension(filePath);

                        // Remove digit block from file name if it contains a digit block:
                        if (containsDigitBlock(fileName))
                        {
                            Match digitBlockMatch = Regex.Match(fileName, @"\d+");
                            fileName = fileName.Remove(digitBlockMatch.Index, digitBlockMatch.Length);
                        }

                        string newFileName = $"{fileName}{i + 1}"; // Adding the digit to each file name
                        string newPath = Path.Combine(directoryPath, newFileName + fileExtension);
                        File.Move(filePath, newPath);
                    }
                    break;
                case 1:
                    foreach (string filePath in files)
                    {
                        string fileName = Path.GetFileName(filePath);

                        if (containsDigitBlock(fileName))
                        {
                            Match digitBlockMatch = Regex.Match(fileName, @"\d+");
                            string newFileName = fileName.Remove(digitBlockMatch.Index, digitBlockMatch.Length);
                            string newPath = Path.Combine(directoryPath, newFileName);

                            // Check if removing the digit block caused a conflict with already existing file names:
                            if (!File.Exists(newPath))
                            {
                                File.Move(filePath, newPath);
                            }
                            else
                            {
                                /***************************************       CHANGE THIS        **********************+*********************
                                Console.WriteLine($"Datei {filePath} wurde übersprungen, da Konflikt mit bereits vorhandener Datei besteht.");
                                *************************************************************************************************************/
                            }
                        }
                    }
                    break;
                case 2:
                    int longestDigitBlockLength = 0;

                    // Find the longest digit block in file names:
                    foreach (string filePath in files)
                    {
                        string fileName = Path.GetFileName(filePath);

                        if (containsDigitBlock(fileName))
                        {
                            Match digitBlockMatch = Regex.Match(fileName, @"\d+");

                            // Get the length of the largest digit block by comparing each digit block to the current largest block:
                            longestDigitBlockLength = Math.Max(digitBlockMatch.Value.Length, longestDigitBlockLength);
                        }
                    }

                    // Apply padding:
                    foreach (string filePath in files)
                    {
                        string fileName = Path.GetFileName(filePath);

                        if (containsDigitBlock(fileName))
                        {
                            Match digitBlockMatch = Regex.Match(fileName, @"\d+");

                            // Create new digit block with leading zeros and replace old digit block:
                            string paddedDigitBlock = digitBlockMatch.Value.PadLeft(longestDigitBlockLength, '0');
                            string newFileName = fileName.Replace(digitBlockMatch.Value, paddedDigitBlock);

                            string newPath = Path.Combine(directoryPath, newFileName);
                            File.Move(filePath, newPath);
                        }
                    }
                    break;
            }

            string[] subDirectoryPaths = Directory.GetDirectories(directoryPath);
            foreach (string subDirectory in subDirectoryPaths)
            {
                editDigitsProcessor(subDirectory, userOption);
            }
        }
    }
}