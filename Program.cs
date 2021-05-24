using System;

namespace EsercizioBolletta
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome=null, cognome=null;
            int kwh=0;
            int quotaFissa = 40;
            int bolletta = 0;

            



            Console.WriteLine("Calcolo Bolletta");
            string scelta;
            do
            {
                Console.WriteLine("Premi 1 per inserire dati: Nome, Cognome, kWh");
                Console.WriteLine("Premi 2 per richiedere il calcolo della bolletta");
                Console.WriteLine("Premi 3 per stampare tutti i dati");
                Console.WriteLine("Premi 0 per uscire");

                scelta = Console.ReadLine();
                switch (scelta)
                {
                    case "1":
                        InserisciDati(out nome, out cognome);
                        InserisciDati(out kwh);
                        break;

                    case "2":
                        CalcoloBolletta(kwh,quotaFissa,out bolletta);
                       
                        break;
                        
                    case "3":
                        Console.WriteLine($"il cliente {nome} {cognome}, ha consumato{kwh},e deve pagare {bolletta} Euro");
                        break;
                       

                }

            } while (scelta != "0");
        }
        private static void CalcoloBolletta(int kwh,int quotaFissa,out int bolletta)
        {
            //Console.WriteLine("Inserisci quanti kWh hai consumato");
            //int kwh = int.Parse(Console.ReadLine());

            bolletta = (kwh * 10) + quotaFissa;
            Console.WriteLine("Bolletta Calcolata!");

        }
        private static void InserisciDati(out string nome, out string cognome)
        {
            Console.WriteLine("Inserisci nome");
            nome = Console.ReadLine();
            Console.WriteLine("Inserisci cognome");
            cognome = Console.ReadLine();
            //Console.WriteLine("Inserisci kwh");
            //kwh = int.Parse(Console.ReadLine());
        }

        private static void InserisciDati(out int kwh)
        {
            Console.WriteLine("Inserisci kwh");
            kwh = int.Parse(Console.ReadLine());
        }

    }
}
