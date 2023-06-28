namespace DateiRenamer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = Methods.getDirectory();

            Console.WriteLine("Auswählen, was mit den Dateien passieren soll:");
            Console.WriteLine("[0]: Präfix ändern, [1]: Suffix ändern, [2]: Musternamen erstellen, [3]: Zahlenblöcke verschieben, [4]: Zahlen anpassen");

            int userOption = Methods.getUserOption(4);

            // Process chosen option:
            switch (userOption)
            {
                case 0:
                    Methods.changePrefix(path);
                    break;
                case 1:
                    Methods.changeSuffix(path);
                    break;
                case 2:
                    Methods.createNamePattern(path);
                    break;
                case 3:
                    Methods.moveDigits(path);
                    break;
                case 4:
                    Methods.editDigits(path);
                    break;
            }
        }
    }
}