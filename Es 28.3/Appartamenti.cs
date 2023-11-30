using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_28._3
{
    internal class Appartamenti : Immobili
    {
            public int NumeroVani { get; set; }
            public int NumeroBagni { get; set; }

            public Appartamenti() { }
            public Appartamenti(string codiceAlfanumerico, string indirizzo, string cap, string citta, int dimensioniImm, 
                int numeroVani, int numeroBagni) : base(codiceAlfanumerico, indirizzo, cap, citta, dimensioniImm)
            {
                this.NumeroVani = numeroVani;
                this.NumeroBagni = numeroBagni;
            }

            public override string ToString()
            {
                return $"Codice: {CodiceAlfanumerico}, Indirizzo: {Indirizzo}, Cap: {Cap}, Città: {Citta}, " +
                $"Dimensione immobile: {DimensioneImm}, Numero vani: {NumeroVani}, Numero bagni: {NumeroBagni}";
            }
    }
}
