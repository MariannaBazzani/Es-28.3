using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_28._3
{
    internal class Ville : Immobili
    {
            public int NumeroVani { get; set; }
            public int NumeroBagni { get; set; }
            public int DimensioneGiar { get; set; }

            public Ville() { }
            public Ville(string codiceAlfanumerico, string indirizzo, string cap, string citta, int dimensioniImm, 
                int numeroVani, int numeroBagni, int dimensioniGiar) : base(codiceAlfanumerico, indirizzo, cap, citta, dimensioniImm)
            {
                this.NumeroVani = numeroVani;
                this.NumeroBagni = numeroBagni;
                this.DimensioneGiar = dimensioniGiar;
            }

            public override string ToString()
                {
                    return $"Codice: {CodiceAlfanumerico}, Indirizzo: {Indirizzo}, Cap: {Cap}, Città: {Citta}, " +
                $"Dimensione immobile: {DimensioneImm}, Numero vani: {NumeroVani}, Numero bagni: {NumeroBagni}, " +
                $"Dimensione giardino: {DimensioneGiar}";
                }
        }
}
