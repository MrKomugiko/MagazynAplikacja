using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazynAplikacja
{                                                                   
    public class Dostawcy
    {
        public int id { get; set; }
        public string Kontrahent { get; set; }
        public string Nazwa_skrocona { get; set; }
        public long NIP { get; set; }
        public string Adress { get; set; }
        public string Miejscowosc { get; set; }
        public string Kod { get; set; }
        public int Grupa { get; set; }
    }
}
