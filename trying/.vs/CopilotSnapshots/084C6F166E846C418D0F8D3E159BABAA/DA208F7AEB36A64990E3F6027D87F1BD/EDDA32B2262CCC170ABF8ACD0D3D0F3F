namespace ContoBancario
{
    internal class Program
    {
        static void Main()
        {

            Console.WriteLine("Inserisci il nome del titolare: ");
            string nomeTitolare = Console.ReadLine();

            Console.WriteLine("Inserisci il saldo del conto bancario");
            double saldoConto;
            while (true)
            {
                string input = Console.ReadLine();
                bool corretto = double.TryParse(input, out saldoConto);
                if (corretto && saldoConto > 0)
                {
                    break;
                }
                Console.WriteLine("Il saldo del conto bancario non può essere minore o uguale a 0. Inserisci un valore valido:");
            }
            

        }
    }
}