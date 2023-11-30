using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_28._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Clicca 1 se vuoi inserire dei dati per una box, 2 per un appartamento o 3 per una villa: ");
            string x = Console.ReadLine();
            while (!int.TryParse(x, out int y))
            {
                Console.WriteLine("Valore nullo, inserire uno dei tre numeri indicati: ");
                x = Console.ReadLine();
            }
            int n = int.Parse(x);
            while(n != 1 && n != 2 && n != 3)
            {
                Console.WriteLine("Numero non disponibile, inserire uno dei tre numeri indicati: ");
                n = int.Parse(Console.ReadLine());
            }

            if (n == 1)
            {
                Console.WriteLine("Inserisci i dati della box: \n Codice alfanumerico: ");
                string CodiceAlfanumerico = Console.ReadLine();
                Console.WriteLine("Indirizzo: ");
                string Indirizzo = Console.ReadLine();
                Console.WriteLine("Cap: ");
                string Cap = Console.ReadLine();
                Console.WriteLine("Citta': ");
                string Citta = Console.ReadLine();
                Console.WriteLine("Dimensione della box in mq: ");
                int DimensioneBox = int.Parse(Console.ReadLine());
                Console.WriteLine("Posti auto: ");
                int PostiAuto = int.Parse(Console.ReadLine());
                Box box = new Box(CodiceAlfanumerico, Indirizzo, Cap, Citta, DimensioneBox, PostiAuto);
                Console.WriteLine($"\nEcco la box: {box}");
                Console.ReadLine();
            }
            else if (n == 2)
            {
                Console.WriteLine("Inserisci i dati dell'appartamento: \n Codice alfanumerico: ");
                string CodiceAlfanumerico = Console.ReadLine();
                Console.WriteLine("Indirizzo: ");
                string Indirizzo = Console.ReadLine();
                Console.WriteLine("Cap: ");
                string Cap = Console.ReadLine();
                Console.WriteLine("Citta': ");
                string Citta = Console.ReadLine();
                Console.WriteLine("Dimensione dell'appartamento in mq: ");
                int DimensioneApp = int.Parse(Console.ReadLine());
                Console.WriteLine("Numero Vani: ");
                int NumeroVani = int.Parse(Console.ReadLine());
                Console.WriteLine("Numero Bagni: ");
                int NumeroBagni = int.Parse(Console.ReadLine());
                Appartamenti appartamento = new Appartamenti(CodiceAlfanumerico, Indirizzo, Cap, Citta, 
                    DimensioneApp, NumeroVani, NumeroBagni);
                Console.WriteLine($"\nEcco l'appartamento: {appartamento}");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Inserisci i dati della villa: \n Codice alfanumerico: ");
                string CodiceAlfanumerico = Console.ReadLine();
                Console.WriteLine("Indirizzo: ");
                string Indirizzo = Console.ReadLine();
                Console.WriteLine("Cap: ");
                string Cap = Console.ReadLine();
                Console.WriteLine("Citta': ");
                string Citta = Console.ReadLine();
                Console.WriteLine("Dimensione della villa in mq: ");
                int DimensioneVil = int.Parse(Console.ReadLine());
                Console.WriteLine("Numero Vani: ");
                int NumeroVani = int.Parse(Console.ReadLine());
                Console.WriteLine("Numero Bagni: ");
                int NumeroBagni = int.Parse(Console.ReadLine());
                Console.WriteLine("Dimensione giardino in mq: ");
                int DimensioneGiar = int.Parse(Console.ReadLine());

                Ville villa = new Ville(CodiceAlfanumerico, Indirizzo, Cap, Citta, DimensioneVil, 
                    NumeroVani, NumeroBagni, DimensioneGiar);
                Console.WriteLine($"\nEcco la villa: {villa}");
                Console.ReadLine();
            }
        }
    }
}
