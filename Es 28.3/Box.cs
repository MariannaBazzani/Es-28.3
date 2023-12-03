using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_28._3
{
    internal class Box : Immobile
    {
            public int PostiAuto { get; set; }

            public Box() { }
            public Box(string codiceAlfanumerico, string indirizzo, string cap, string citta, int dimensioneImm, 
                int postiAuto) : base(codiceAlfanumerico, indirizzo, cap, citta, dimensioneImm)
            {
                this.PostiAuto = postiAuto;
            }

            public override string ToString()
            {
                return $"Codice: {CodiceAlfanumerico}, Indirizzo: {Indirizzo}, Cap: {Cap}, Città: {Citta}, " +
                $"Dimensione immobile: {DimensioneImm}, Posti auto: {PostiAuto}";
            }
    }
}
