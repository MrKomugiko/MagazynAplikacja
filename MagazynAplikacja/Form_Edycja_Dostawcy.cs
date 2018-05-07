using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace MagazynAplikacja
{
    public partial class Form_Edycja_Dostawcy : Form
    {
        XmlSerializer xs;
        List<Dostawcy> listDostawcy;

        public Form_Edycja_Dostawcy()
        {
            InitializeComponent();

            listDostawcy = new List<Dostawcy>();
            xs = new XmlSerializer(typeof(List<Dostawcy>));
        }

        private void Btn_Zatwierdz_Edytuj_Click(object sender, EventArgs e)
        {
            FileStream fs1 = new FileStream("..\\..\\Pliki XML\\ListaDostawcow.xml", FileMode.Open, FileAccess.Read);
            listDostawcy = (List<Dostawcy>)xs.Deserialize(fs1);         //WCZYTANIE XML DO LISTY DOSTAWCOW
            fs1.Close();

            listDostawcy[Convert.ToInt32(Label_ID.Text) - 999].Kontrahent = TextBox_Firma.Text;
            listDostawcy[Convert.ToInt32(Label_ID.Text) - 999].Nazwa_skrocona = TextBox_Nazwa.Text;
            listDostawcy[Convert.ToInt32(Label_ID.Text) - 999].NIP = Convert.ToInt64(TextBox_NIP.Text);
            listDostawcy[Convert.ToInt32(Label_ID.Text) - 999].Adress = TextBox_Adres.Text;
            listDostawcy[Convert.ToInt32(Label_ID.Text) - 999].Miejscowosc = TextBox_Miejscowosc.Text;
            listDostawcy[Convert.ToInt32(Label_ID.Text) - 999].Kod = TextBox_Kod.Text;

            FileStream fs = new FileStream("..\\..\\Pliki XML\\ListaDostawcow.xml", FileMode.Create, FileAccess.Write);
            xs.Serialize(fs, listDostawcy);                              //ZAPISANIE CAŁEJ LISTY DO XML

            fs.Close();                                                 //ZAMKNIECIE POLACZENIA
            Close();

        }
    }
}
