using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DateiRenamer
{
    internal class Methods
    {
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
            Console.WriteLine("neuen Präfix eingeben:");
            string newPrefix = Console.ReadLine()!; // Get new prefix from user input

            if (string.IsNullOrEmpty(newPrefix))
            {
                Console.WriteLine("Keinen neuen Präfix angegeben...");
                return;
            }

            prefixProcessor(new DirectoryInfo(directoryPath), oldPrefix, newPrefix); // Processing the prefix changing in a separate function for recursion purposes. If we added recursion to this function, we would have to enter new prefixes every single time
        }

        private static void prefixProcessor(DirectoryInfo directory, string oldPrefix, string newPrefix)
        {
            FileInfo[] files = directory.GetFiles(); // `FileInfo[]` provides methods to work with files

            foreach (FileInfo file in files)
            {
                string oldFileName = file.Name;
                string newFileName;

                if (!string.IsNullOrEmpty(oldPrefix) && oldFileName.StartsWith(oldPrefix))
                {
                    newFileName = oldFileName.Replace(oldPrefix, newPrefix); // REMINDER COMMENT: The string.Replace() function could be used to replace any part of the file name, not just the prefix
                }
                else
                {
                    newFileName = newPrefix + oldFileName;
                }

                string newPath = Path.Combine(directory.FullName, newFileName);
                file.MoveTo(newPath);
            }

            //Create recursion for sub-directory processing:
            DirectoryInfo[] subDirectories = directory.GetDirectories();
            foreach (DirectoryInfo subDirectory in subDirectories)
            {
                prefixProcessor(subDirectory, oldPrefix, newPrefix);
            }
        }
    }
}
