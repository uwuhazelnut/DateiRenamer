namespace DateiRenamer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = Methods.getDirectory();

            Console.WriteLine("Auswählen, was mit den Dateien passieren soll:");
            Console.WriteLine("[0]: Präfix ändern, [1]: Suffix ändern, [2]: Zahlenblöcke verschieben");

            int userOption = Methods.getUserOption(2);

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
                    Methods.moveDigits(path);
                    break;
            }
        }
    }
}