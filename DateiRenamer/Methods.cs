using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DateiRenamer
{
    internal class Methods
    {
        public static int getUserOption(int optionAmount)
        {
            int option; // The option chosen by the user is stored in the option variable
            bool optionCheck = int.TryParse(Console.ReadLine(), out option); // TryParse returns a false boolean if the user enters invalid input which makes error handling easier

            // Set the check boolean to false if the user enters an option that doesn't exist:
            if (option > optionAmount || option < 0)
            {
                optionCheck = false;
            }

            // Get new user input if previous input was invalid:
            while (optionCheck == false)
            {
                Console.WriteLine("Ungültige Option, nochmal versuchen:");
                optionCheck = int.TryParse(Console.ReadLine(), out option);

                if (option > optionAmount || option < 0)
                {
                    optionCheck = false;
                }
            }

            return option;
        }

        /// <summary>
        /// Returns a directory path from user input and lists all files in directory and subdirectories
        /// </summary>
        public static string getDirectory()
        {
            Console.WriteLine("Bitte den Pfad zu dem Ordner angeben, in dem die Dateien umbenannt werden sollen:");

            // Get directory path from user input:
            string directoryPath = Console.ReadLine()!; // The `!` removes the "can be null" warning
            Boolean validityCheck = false;

            // Get new user input if previous input was invalid:
            while (validityCheck == false)
            {
                if (System.IO.Directory.Exists(directoryPath)) // Check if path exists
                {
                    validityCheck = true; // Stop the loop because user input is valid
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
                }
                else
                {
                    Console.WriteLine("Pfad existiert nicht, bitte nochmal versuchen:");
                    directoryPath = Console.ReadLine()!;
                }
            }

            return directoryPath;
        }

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

        public static void changePrefix(string directoryPath)
        {
            Console.WriteLine("Präfix eingeben, der ersetzt werden soll (leer lassen wenn nur Präfix hinzugefügt werden soll):");
            string oldPrefix = Console.ReadLine()!; // Get old prefix from user input
            Console.WriteLine("neuen Präfix eingeben (leer lassen wenn Präfix, der vorhin eingegeben wurde, nur gelöscht werden soll):");
            string newPrefix = Console.ReadLine()!; // Get new prefix from user input

            prefixProcessor(new DirectoryInfo(directoryPath), oldPrefix, newPrefix); // Processing the prefix changing in a separate function for recursion purposes. If we added recursion to this function, the user would have to enter new prefixes every single time
        }

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

        public static void changeSuffix(string directoryPath)
        {
            Console.WriteLine("Suffix eingeben, der ersetzt werden soll (leer lassen wenn nur Suffix hinzugefügt werden soll):");
            string oldSuffix = Console.ReadLine()!;
            Console.WriteLine("neuen Suffix eingeben (leer lassen wenn Suffix, der vorhin eingegeben wurde, nur gelöscht werden soll):");
            string newSuffix = Console.ReadLine()!;

            suffixProcessor(new DirectoryInfo(directoryPath), oldSuffix, newSuffix);
        }

        private static void suffixProcessor(DirectoryInfo directory, string oldSuffix, string newSuffix)
        {
            FileInfo[] files = directory.GetFiles();

            foreach (FileInfo file in files)
            {
                string oldFileName = file.Name;
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
                string newPath = Path.Combine(directory.FullName, newFileName);
                file.MoveTo(newPath);
            }

            DirectoryInfo[] subDirectories = directory.GetDirectories();
            foreach (DirectoryInfo subDirectory in subDirectories)
            {
                suffixProcessor(subDirectory, oldSuffix, newSuffix);
            }
        }

        public static void moveDigits(string directoryPath)
        {
            Console.WriteLine("Wohin sollen die Zahlenblöcke verschoben werden?");
            Console.WriteLine("[0]: an den Anfang, [1]: an das Ende");

            int userOption = getUserOption(1);

            moveDigitsProcessor(new DirectoryInfo(directoryPath), userOption);

            Console.WriteLine("Zahlenblöcke verschoben (wenn vorhanden).");
        }

        private static void moveDigitsProcessor(DirectoryInfo directory, int userOption)
        {
            FileInfo[] files = directory.GetFiles();

            foreach (FileInfo file in files)
            {
                string fileName = Path.GetFileNameWithoutExtension(file.FullName); // Get file name without extension to allow for moving string to the end without modifying the file extension
                string fileExtension = Path.GetExtension(file.FullName);

                if (containsDigitBlock(fileName))
                {
                    if (userOption == 0)
                    {
                        // Use regular expression to find the digit block and move it to the beginning:
                        Match digitBlockMatch = Regex.Match(fileName, @"\d+");
                        string digitBlock = digitBlockMatch.Value;
                        string remainingFileName = fileName.Remove(digitBlockMatch.Index, digitBlockMatch.Length); // Removes the digit block from the file name using the Regex match information
                        string newFileName = digitBlock + remainingFileName;

                        string newPath = Path.Combine(directory.FullName, newFileName + fileExtension); // Reattach file extension to the file name
                        file.MoveTo(newPath);
                    }
                    else if (userOption == 1)
                    {
                        //Move digit block to end: 
                        Match digitBlockMatch = Regex.Match(fileName, @"\d+");
                        string digitBlock = digitBlockMatch.Value;
                        string remainingFileName = fileName.Remove(digitBlockMatch.Index, digitBlockMatch.Length);
                        string newFileName = remainingFileName + digitBlock;

                        string newPath = Path.Combine(directory.FullName, newFileName + fileExtension);
                        file.MoveTo(newPath);
                    }
                }
            }

            DirectoryInfo[] subDirectories = directory.GetDirectories();
            foreach (DirectoryInfo subDirectory in subDirectories)
            {
                moveDigitsProcessor(subDirectory, userOption);
            }
        }

        private static bool containsDigitBlock(string fileName)
        {
            // Use regular expression to check if the filename contains a block of digits
            return Regex.IsMatch(fileName, @"\d+");
        }
    }
}
