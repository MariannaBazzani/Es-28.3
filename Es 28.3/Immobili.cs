using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_28._3
{
    internal class Immobili
    {
            public string CodiceAlfanumerico { get; set; }
            public string Indirizzo { get; set; }
            public string Cap { get; set; }
            public string Citta { get; set; }
            public int DimensioneImm { get; set; }

            public Immobili() { }
            public Immobili(string codiceAlfanumerico, string indirizzo, string cap, string citta, int dimensioneImm)
            {
                this.CodiceAlfanumerico = codiceAlfanumerico;
                this.Indirizzo = indirizzo;
                this.Cap = cap;
                this.Citta = citta;
                this.DimensioneImm = dimensioneImm;
            }

            public override string ToString()
            {
                return $"Codice: {CodiceAlfanumerico}, Indirizzo: {Indirizzo}, " +
                $"Cap: {Cap}, Città: {Citta}, Dimensione immobile: {DimensioneImm}";
            }
    }
}
