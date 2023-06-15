namespace DateiRenamer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = Methods.getDirectory();

            Console.WriteLine("Auswählen, was mit der Datei passieren soll:");
            Console.WriteLine("[0]: Präfix ändern, [1]: Suffix ändern");

            int option;
            bool optionCheck = int.TryParse(Console.ReadLine(), out option);

            while (optionCheck == false)
            {
                Console.WriteLine("Ungültige Option, nochmal versuchen:");
                optionCheck = int.TryParse(Console.ReadLine(), out option);

                if (option > 1)
                {
                    optionCheck = false;
                }
            }
        }
    }
}