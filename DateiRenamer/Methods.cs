using System.Text.RegularExpressions;

namespace DateiRenamer
{
    internal class Methods
    {
        /// <summary>
        /// Gets option in a specified range of numbers from user input
        /// </summary>
        /// <param name="optionAmount">The amount of user options available</param>
        /// <returns>Option selected by user as an int</returns>
        public static int getUserOption(int optionAmount)
        {
            int option; // The option chosen by the user is stored in the option variable

            // Repeat user input request until valid input has been entered:
            while (true)
            {
                bool optionCheck = int.TryParse(Console.ReadLine(), out option); // TryParse returns a false boolean if the user enters invalid input which makes error handling easier

                if (option >= 0 && option <= optionAmount && optionCheck)
                {
                    break;
                }

                Console.WriteLine("Ungültige Option, nochmal versuchen:");
            }

            return option;
        }

        /// <summary>
        /// Returns a directory path from user input and lists all files in directory and subdirectories
        /// </summary>
        /// <returns>Directory path from user input as a string</returns>
        public static string getDirectory()
        {
            Console.WriteLine("Bitte den Pfad zu dem Ordner angeben, in dem die Dateien umbenannt werden sollen:");

            // Get directory path from user input:
            string directoryPath = Console.ReadLine()!; // The `!` removes the "can be null" warning

            // Get new user input if previous input was invalid:
            while (true)
            {
                if (System.IO.Directory.Exists(directoryPath)) // Check if path exists
                {
                    Console.WriteLine($"Pfad existiert");
                    Console.WriteLine($"Dateien in Pfad {directoryPath}:");

                    // Print all file names in the console:
                    foreach (string filePath in Directory.GetFiles(directoryPath))
                    {
                        Console.WriteLine(Path.GetFileName(filePath));
                    }

                    //Recursively process subdirectories:
                    Console.WriteLine($"Unterordner in Pfad {directoryPath}:");
                    subdirectoryProcessor(new DirectoryInfo(directoryPath));
                    break; // End loop because user input is valid
                }
                else
                {
                    Console.WriteLine("Pfad existiert nicht, bitte nochmal versuchen:");
                    directoryPath = Console.ReadLine()!;
                }
            }

            return directoryPath;
        }

        /// <summary>
        /// Lists all files from all subdirectories within a specified directory
        /// </summary>
        /// <param name="directory">Root directory, where all subdirectories should be processed</param>
        private static void subdirectoryProcessor(DirectoryInfo directory)
        {
            DirectoryInfo[] subDirectories = directory.GetDirectories(); // `DirectoryInfo` provides methods to work with directories

            foreach (DirectoryInfo subDirectory in subDirectories)
            {
                Console.WriteLine(subDirectory.FullName + ":");

                // Print all file names in the subdirectory:
                foreach (string filePath in Directory.GetFiles(subDirectory.FullName))
                {
                    Console.WriteLine(Path.GetFileName(filePath));
                }

                // Recursively process subdirectories of the subdirectory:
                subdirectoryProcessor(subDirectory);
            }
        }

        /// <summary>
        /// Gets new file name prefix from user input and calls the prefixProcessor() function for the actual file processing
        /// </summary>
        /// <param name="directoryPath">Directory, where file names should be changed</param>
        public static void changePrefix(string directoryPath)
        {
            Console.WriteLine("Präfix eingeben, der ersetzt werden soll (leer lassen wenn nur Präfix hinzugefügt werden soll):");
            string oldPrefix = Console.ReadLine()!; // Get old prefix from user input
            Console.WriteLine("neuen Präfix eingeben (leer lassen wenn Präfix, der vorhin eingegeben wurde, nur gelöscht werden soll):");
            string newPrefix = Console.ReadLine()!; // Get new prefix from user input

            prefixProcessor(new DirectoryInfo(directoryPath), oldPrefix, newPrefix); // Processing the prefix changing in a separate function for recursion purposes. If we added recursion to this function, the user would have to enter new prefixes every single time
        }

        /// <summary>
        /// Replaces prefix with given prefix for all file names, or adds prefix if no prefix to replace is given in directory and sub-directories
        /// </summary>
        /// <param name="directory">Directory, where file names should be changed</param>
        /// <param name="oldPrefix">Prefix to be replaced</param>
        /// <param name="newPrefix">New prefix</param>
        private static void prefixProcessor(DirectoryInfo directory, string oldPrefix, string newPrefix)
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

        /// <summary>
        /// Gets new file name suffix from user input and calls the suffixProcessor() function for the actual file processing
        /// </summary>
        /// <param name="directoryPath">Directory, where file names should be changed</param>
        public static void changeSuffix(string directoryPath)
        {
            Console.WriteLine("Suffix eingeben, der ersetzt werden soll (leer lassen wenn nur Suffix hinzugefügt werden soll):");
            string oldSuffix = Console.ReadLine()!;
            Console.WriteLine("neuen Suffix eingeben (leer lassen wenn Suffix, der vorhin eingegeben wurde, nur gelöscht werden soll):");
            string newSuffix = Console.ReadLine()!;

            suffixProcessor(new DirectoryInfo(directoryPath), oldSuffix, newSuffix);
        }

        /// <summary>
        /// Replaces suffix with given suffix for all file names, or adds suffix if no suffix to replace is given in directory and sub-directories
        /// </summary>
        /// <param name="directory">Directory, where file names should be changed</param>
        /// <param name="oldSuffix">Prefix to be replaced</param>
        /// <param name="newSuffix">New prefix</param>
        private static void suffixProcessor(DirectoryInfo directory, string oldSuffix, string newSuffix)
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

        /// <summary>
        /// Asks user if the digit blocks should be moved to the start or the end of the file name and calls the moveDigitsProcessor() function for file processing
        /// </summary>
        /// <param name="directoryPath">Directory, where file names should be changed</param>
        public static void moveDigits(string directoryPath)
        {
            Console.WriteLine("Wohin sollen die Zahlenblöcke verschoben werden?");
            Console.WriteLine("[0]: an den Anfang, [1]: an das Ende");

            int userOption = getUserOption(1);

            moveDigitsProcessor(new DirectoryInfo(directoryPath), userOption);

            Console.WriteLine("Zahlenblöcke verschoben (wenn vorhanden).");
        }

        /// <summary>
        /// Moves existing digit blocks in the file names to either the start or end of the file name, depending on the option given
        /// </summary>
        /// <param name="directory">Directory, where file names should be changed</param>
        /// <param name="userOption">Option for where the digit block should be moved to</param>
        private static void moveDigitsProcessor(DirectoryInfo directory, int userOption)
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

        /// <summary>
        /// Checks, if a string contains a digit block using a regular expression and returns a bool value
        /// </summary>
        /// <param name="fileName">string to be checked for existing digit blocks</param>
        /// <returns>bool true or false</returns>
        private static bool containsDigitBlock(string fileName)
        {
            // Use regular expression to check if the filename contains a block of digits
            return Regex.IsMatch(fileName, @"\d+");
        }

        /// <summary>
        /// Asks the user to choose from multiple options for editing the digit blocks of file names and calls the editDigitsProcessor() function for file processing
        /// </summary>
        /// <param name="directoryPath">Directory, where file names should be changed</param>
        public static void editDigits(string directoryPath)
        {
            Console.WriteLine("Was soll mit den Zahlen passieren?");
            Console.WriteLine("[0]: Zahlenblöcke einfügen/ersetzen (nach Erstellungsdatum sortiert), [1]: Zahlenblöcke löschen, [2]: Führende Nullen einführen");

            int userOption = getUserOption(2);

            editDigitsProcessor(directoryPath, userOption);

            switch (userOption)
            {
                case 0:
                    Console.WriteLine("Zahlenblöcke eingefügt (bereits vorhandene Zahlenblöcke wurden ersetzt)");
                    break;
                case 1:
                    Console.WriteLine("Zahlenblöcke gelöscht.");
                    break;
                case 2:
                    Console.WriteLine("Führende Nullen hinzugefügt (alle Zahlenblöcke wurden an den größten Zahlenblock angepasst).");
                    break;
            }
        }

        /// <summary>
        /// Either adds digit blocks to all file names or removes all digit blocks in the file names or adds leading zeros as padding to all file names, depending on option given
        /// </summary>
        /// <param name="directoryPath">Directory, where file names should be changed</param>
        /// <param name="userOption">The option chosen by the user</param>
        private static void editDigitsProcessor(string directoryPath, int userOption)
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
                                Console.WriteLine($"Datei {filePath} wurde übersprungen, da Konflikt mit bereits vorhandener Datei besteht.");
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

        /// <summary>
        /// Gets a pattern for all file names from the user and calls the namePatternProcessor() function for file processing
        /// </summary>
        /// <param name="directoryPath">Directory, where file names should be changed</param>
        public static void createNamePattern(string directoryPath)
        {
            Console.WriteLine("Muster eingeben, das für alle Dateien verwendet werden soll (alle Dateinamen werden mit diesem Muster ersetzt):");
            Console.WriteLine("Beispiel: 'file-' führt zum Muster 'file-1', 'file-2', ...");
            string userPattern = Console.ReadLine()!;

            if (!string.IsNullOrWhiteSpace(userPattern))
            {
                namePatternProcessor(directoryPath, userPattern);
                Console.WriteLine("Dateien umbenannt");
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe");
            }
        }

        /// <summary>
        /// Replaces all file names with pattern given and adds digits to prevent file name conflicts
        /// </summary>
        /// <param name="directoryPath">Directory, where file names should be changed</param>
        /// <param name="userPattern">Pattern used for the file names</param>
        private static void namePatternProcessor(string directoryPath, string userPattern)
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
    }
}
