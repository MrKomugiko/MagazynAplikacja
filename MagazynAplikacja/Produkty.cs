using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazynAplikacja
{
    public class Produkty
    {
        public int Id { get; set; }
        public string Nazwa { get; set; }
        public string Opis { get; set; }
        public int EAN { get; set; }
        public float Cena_Netto { get; set; }
        public int VAT { get; set; }
        public float Wartosc_VAT { get; set; }
        public float Cena_Brutto { get; set; }
        public int Dostawca_ID { get; set; }
        public string Grupa { get; set; }

    }
}
