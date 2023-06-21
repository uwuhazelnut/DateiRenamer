namespace DateiRenamer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = Methods.getDirectory();

            Console.WriteLine("Auswählen, was mit der Datei passieren soll:");
            Console.WriteLine("[0]: Präfix ändern, [1]: Suffix ändern");

            int option; // The option chosen by the user is stored in the option variable
            bool optionCheck = int.TryParse(Console.ReadLine(), out option); // TryParse returns a false boolean if the user enters invalid input which makes error handling easier

            // Set the check boolean to false if the user enters an option that doesn't exist:
            if (option > 1)
            {
                optionCheck = false;
            }

            // Get new user input if previous input was invalid:
            while (optionCheck == false) 
            {
                Console.WriteLine("Ungültige Option, nochmal versuchen:");
                optionCheck = int.TryParse(Console.ReadLine(), out option);

                if (option > 1)
                {
                    optionCheck = false;
                }
            }

            // Process chosen option:
            switch(option)
            {
                case 0:
                    Methods.changePrefix(path);
                    break;
                case 1:
                    break;
            }
        }
    }
}