using System;
using Classes;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Benvenuto alla tua banca personale!");
        Console.Write("Inserisci il tuo nome: ");
        string ownerName = Console.ReadLine();

        decimal initialBalance;
        while (true)
        {
            Console.Write("Inserisci il saldo iniziale: ");
            if (decimal.TryParse(Console.ReadLine(), out initialBalance) && initialBalance >= 0)
            {
                break;
            }
            Console.WriteLine("Saldo non valido. Inserisci un numero positivo.");
        }

        var account = new BankAccount(ownerName, initialBalance);
        Console.WriteLine($"Conto {account.Number} creato per {account.Owner} con saldo iniziale di {account.Balance}.");

        bool continua = true;
        while (continua)
        {
            Console.WriteLine("\nScegli un'operazione:");
            Console.WriteLine("1. Deposito");
            Console.WriteLine("2. Prelievo");
            Console.WriteLine("3. Visualizza cronologia");
            Console.WriteLine("4. Esci");
            Console.Write("Scelta: ");
            string scelta = Console.ReadLine();

            switch (scelta)
            {
                case "1":
                    Console.Write("Importo del deposito: ");
                    if (decimal.TryParse(Console.ReadLine(), out decimal deposito) && deposito > 0)
                    {
                        Console.Write("Nota (descrizione): ");
                        string notaDeposito = Console.ReadLine();
                        account.MakeDeposit(deposito, DateTime.Now, notaDeposito);
                        Console.WriteLine($"Deposito effettuato. Saldo attuale: {account.Balance}");
                    }
                    else
                    {
                        Console.WriteLine("Importo non valido.");
                    }
                    break;

                case "2":
                    Console.Write("Importo del prelievo: ");
                    if (decimal.TryParse(Console.ReadLine(), out decimal prelievo) && prelievo > 0)
                    {
                        Console.Write("Nota (descrizione): ");
                        string notaPrelievo = Console.ReadLine();
                        try
                        {
                            account.MakeWithdrawal(prelievo, DateTime.Now, notaPrelievo);
                            Console.WriteLine($"Prelievo effettuato. Saldo attuale: {account.Balance}");
                        }
                        catch (InvalidOperationException e)
                        {
                            Console.WriteLine("Errore: " + e.Message);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Importo non valido.");
                    }
                    break;

                case "3":
                    Console.WriteLine("\n=== Cronologia delle transazioni ===");
                    Console.WriteLine(account.GetAccountHistory());
                    break;

                case "4":
                    continua = false;
                    break;

                default:
                    Console.WriteLine("Scelta non valida.");
                    break;
            }
        }

        Console.WriteLine("Grazie per aver usato la tua banca personale. Arrivederci!");
    }
}
