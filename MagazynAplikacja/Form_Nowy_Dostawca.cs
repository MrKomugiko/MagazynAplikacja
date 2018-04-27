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
    public partial class Form_Nowy_Dostawca : Form
    {
        XmlSerializer xs;
        List<Dostawcy> listDostawcy;

        public Form_Nowy_Dostawca()
        {
            InitializeComponent();

            listDostawcy = new List<Dostawcy>();
            xs = new XmlSerializer(typeof(List<Dostawcy>));


        }
        private void Form_Nowy_Dostawca_Load(object sender, EventArgs e)
        {
            
            FileStream fs1 = new FileStream("..\\..\\Pliki XML\\ListaDostawcow.xml", FileMode.Open, FileAccess.Read);
            listDostawcy = (List<Dostawcy>)xs.Deserialize(fs1);         //WCZYTANIE XML DO LISTY DOSTAWCOW
            fs1.Close();                                                //ZAMKNIECIE POLACZENIA

            int numerID = listDostawcy.Count + 999;                      //Obliczenie ilsoci elementow na liscie w celu automatyzacji nadawania id
            Label_ID.Text = numerID.ToString();
        }

        private void Btn_Zatwierdz_Dodaj_Click(object sender, EventArgs e)
        {
            DodajDostawce();
            Close();
        }

        private void Btn_Zatwierdz_DodajNowy_Click(object sender, EventArgs e)
        {
            DodajDostawce();
        }

        protected void DodajDostawce()
        {
            //------------ZAŁADOWANIE DO LISTY DOSTAWCOW ELEMENTOW Z ISTNIEJACEGO JUŻ PLIKU XML------------------------------------------

            FileStream fs1 = new FileStream("..\\..\\Pliki XML\\ListaDostawcow.xml", FileMode.Open, FileAccess.Read);
            listDostawcy = (List<Dostawcy>)xs.Deserialize(fs1);         //WCZYTANIE XML DO LISTY DOSTAWCOW
            fs1.Close();                                                //ZAMKNIECIE POLACZENIA

            //------------DODANIE WSZYSTKICH ELEMENTOW Z LISTY I PONOWNE UTWORZENIE PLIKU XML NADPISANEGO O NOWY ELEMEMT-----------------

            int numerID = listDostawcy.Count + 999;                      //Obliczenie ilsoci elementow na liscie w celu automatyzacji nadawania id
            Label_ID.Text = numerID.ToString();

            FileStream fs = new FileStream("..\\..\\Pliki XML\\ListaDostawcow.xml", FileMode.Create, FileAccess.Write);
            Dostawcy Dostawca = new Dostawcy
            {
                id = numerID,
                Kontrahent = TextBox_Firma.Text,
                Nazwa_skrocona = TextBox_Nazwa.Text,
                NIP = Convert.ToInt64(TextBox_NIP.Text),
                Adress = TextBox_Adres.Text,
                Miejscowosc = TextBox_Miejscowosc.Text,
                Kod = TextBox_Kod.Text,
                Grupa = 0 //"Not assigned yet"
            };                        //TWORZENIE NOWEGO ELEMENTU W LISCIE DOSTAWCOW

            listDostawcy.Add(Dostawca);                                 //DODANIE ELEMENTU DO LISTY

            xs.Serialize(fs, listDostawcy);                              //ZAPISANIE CAŁEJ LISTY DO XML

            fs.Close();                                                 //ZAMKNIECIE POLACZENIA
        }
    }
}
