using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateiRenamer
{
    internal class Methods
    {
        /// <summary>
        /// Returns a directory path from user input and lists all files in directory
        /// </summary>
        public static string getDirectory()
        {
            Console.WriteLine("Bitte den Pfad zu dem Ordner angeben, in dem die Dateien umbenannt werden sollen:");

            string directoryPath = Console.ReadLine()!;
            Boolean validityCheck = false;

            while (validityCheck == false)
            {
                if (System.IO.Directory.Exists(directoryPath))
                {
                    validityCheck = true;
                    Console.WriteLine($"Pfad existiert");
                    Console.WriteLine($"Dateien in Pfad {directoryPath}:");

                    foreach (string filePath in Directory.GetFiles(directoryPath))
                    {
                        Console.WriteLine(Path.GetFileName(filePath));
                    }
                }
                else
                {
                    Console.WriteLine("Pfad existiert nicht, bitte nochmal versuchen:");
                    directoryPath = Console.ReadLine()!;
                }
            }

            return directoryPath;
        }
    }
}
