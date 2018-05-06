﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace MagazynAplikacja
{
    public partial class Form1 : Form
    {
        List<Panel> listPanel = new List<Panel>();
        public XmlSerializer xs;
        public XmlSerializer xs2;
        List<Dostawcy> listDostawcy;
        List<Produkty> listProdukty;

        //Przypisanie własności listy do listyDostawców oraz utworzenie odwołania do XmlSerializer'a
        public Form1()
        {
            InitializeComponent();

            listDostawcy = new List<Dostawcy>();
            xs = new XmlSerializer(typeof(List<Dostawcy>));
            listProdukty = new List<Produkty>();
            xs2 = new XmlSerializer(typeof(List<Produkty>));
        }

        //PRzy starcie apki załaduje do listy wszystkie mozliwe panele w celu łatwiejszej organizacji 
        private void Form1_Load(object sender, EventArgs e)
        {
            Btn_Dostawca_Import.PerformClick();
            Btn_Produkty_Import.PerformClick();


            listPanel.Add(panel_Magazyn);           // 0
            listPanel.Add(panel_Zamowienia);        // 1
            listPanel.Add(panel_Dostawcy_Main);     // 2
            listPanel.Add(panel_Produkty_Main);     // 3
            UkryjPanele();

        }

        private void button_Dodaj_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = textBox_Nazwa.Text;
            dataGridView1.Rows[n].Cells[1].Value = textBox_Netto.Text;
            dataGridView1.Rows[n].Cells[2].Value = textBox_VAT.Text;
            dataGridView1.Rows[n].Cells[3].Value = ((Convert.ToDouble(textBox_Netto.Text) * ( (Convert.ToDouble(textBox_VAT.Text) / 100) + 1)));
            dataGridView1.Rows[n].Cells[4].Value = textBox_ilosc.Text;
            dataGridView1.Rows[n].Cells[5].Value = (Convert.ToDouble(textBox_ilosc.Text) * Convert.ToDouble(textBox_Netto.Text) * ((Convert.ToDouble(textBox_VAT.Text)/100) + 1));

        }
        private void button_ZapiszXML_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt.TableName = "Dostawca";
            dt.Columns.Add("Nazwa");
            dt.Columns.Add("NIP");
            dt.Columns.Add("Adres");
            dt.Columns.Add("Kod_Pocztowy");
            dt.Columns.Add("Miasto");
            ds.Tables.Add(dt);

            DataTable dt1 = new DataTable();
            dt1.TableName = "Produkt";
            dt1.Columns.Add("Nazwa");
            dt1.Columns.Add("Wartość_Netto");
            dt1.Columns.Add("Podatek");
            dt1.Columns.Add("Wartość_Brutto");
            dt1.Columns.Add("Ilosc");
            dt1.Columns.Add("Wartosc_calkowita_brutto");
            ds.Tables.Add(dt1);

            DataRow row = ds.Tables["Dostawca"].NewRow();
            row["Nazwa"] =textBox2_Nazwa.Text;
            row["NIP"] = textBox2_NIP.Text;
            row["Adres"] = textBox2_Adres.Text;
            row["Kod_Pocztowy"] = textBox2_Kod.Text;
            row["Miasto"] = textBox2_Miasto.Text;
            ds.Tables["Dostawca"].Rows.Add(row);

            foreach(DataGridViewRow r in dataGridView1.Rows)
            {
                DataRow row1 = ds.Tables["Produkt"].NewRow();
                row1["Nazwa"]           = r.Cells[0].Value;
                row1["Wartość_Netto"]   = r.Cells[1].Value;
                row1["Podatek"]         = r.Cells[2].Value;
                row1["Wartość_Brutto"]  = r.Cells[3].Value;
                row1["Ilosc"]           = r.Cells[4].Value;
                row1["Wartosc_calkowita_brutto"] = r.Cells[5].Value;
                ds.Tables["Produkt"].Rows.Add(row1);
            }
            ds.WriteXml("C:\\Users\\MrKom\\Data.xml");
            
            
        }
        private void button_Zaladuj_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml("C:\\Users\\MrKom\\Data.xml");
            textBox2_Nazwa.Text = ds.Tables["Dostawca"].Rows[0][0].ToString();
            textBox2_NIP.Text = ds.Tables["Dostawca"].Rows[0][1].ToString();
            textBox2_Adres.Text = ds.Tables["Dostawca"].Rows[0][2].ToString();
            textBox2_Kod.Text = ds.Tables["Dostawca"].Rows[0][3].ToString();
            textBox2_Miasto.Text = ds.Tables["Dostawca"].Rows[0][4].ToString();
            foreach(DataRow item in ds.Tables["Produkt"].Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["Nazwa"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["Wartość_Netto"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item["Podatek"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item["Wartość_Brutto"].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item["Ilosc"].ToString();
                dataGridView1.Rows[n].Cells[5].Value = item["Wartosc_calkowita_brutto"].ToString();

            }
        }
        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox_Nazwa.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox_Netto.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox_VAT.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            //textBox_Brutto.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox_ilosc.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();

        }
        private void button_Edytuj_Click(object sender, EventArgs e)
        {
            dataGridView1.SelectedRows[0].Cells[0].Value = textBox_Nazwa.Text;
            dataGridView1.SelectedRows[0].Cells[1].Value = textBox_Netto.Text;
            dataGridView1.SelectedRows[0].Cells[2].Value = textBox_VAT.Text;
           //dataGridView1.SelectedRows[0].Cells[3].Value = textBox_Brutto.Text;
            dataGridView1.SelectedRows[0].Cells[4].Value = textBox_ilosc.Text;
            dataGridView1.SelectedRows[0].Cells[5].Value = (Convert.ToDouble(textBox_ilosc.Text) * Convert.ToDouble(textBox_Netto.Text));

        }
        private void button_Usun_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
        }

        //----------------------------------------------------------------------------------------------------------------------------------------------------------
        //Ukrywa wszystkie panele pokazujac strone glowna - dostawa             -- KUBY STRONA GLOWNA
        private void Btn_Dostawa_Click(object sender, EventArgs e)
        {
            UkryjPanele();
        }

        //Przycisk magazyn otwiera panel i zamyka wszytskie pozostałe
        private void Btn_Magazyn_Click(object sender, EventArgs e)
        {
            UkryjPanele();
            listPanel[0].BringToFront();  
        }

        //Przycisk zamowienie otwiera panel i zamyka wszytskie pozostałe
        private void Btn_Zamowienia_Click(object sender, EventArgs e)
        {
            UkryjPanele();
            listPanel[1].BringToFront();
        }

        //Funkcja odpowiadająca za ukrycie wszystkich dostępnych paneli
        public void UkryjPanele()
        {
            for (int i = 0; i < listPanel.Count(); i++)
            {
                listPanel[i].SendToBack();
            }      
        }

        //Przycisk dostawcy pokazuje panel dostawcow ukrywajac reszte paneli
        private void Btn_Dostawcy_Click(object sender, EventArgs e)
        {
            UkryjPanele();
            listPanel[2].BringToFront();
        }

        //Wróc na strone glowna przyskiem back - poukrywaj panele
        private void Btn_Back_Click(object sender, EventArgs e)
        {
            UkryjPanele();
        }

        //Zaimportowanie wczesniej utworzonej listy dostawców z pliku xml
        private void Btn_Dostawca_Import_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("..\\..\\Pliki XML\\ListaDostawcow.xml", FileMode.Open, FileAccess.Read);
            listDostawcy = (List<Dostawcy>)xs.Deserialize(fs);

            dataGridView2.DataSource = listDostawcy;
            fs.Close();
        }

        //Wyexportowanie zapisanej tabeli dostawców do pliku xml
        private void Btn_Dostawca_Export_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("..\\..\\Pliki XML\\ListaDostawcowEXPORT.xml", FileMode.Create, FileAccess.Write);
            xs.Serialize(fs, listDostawcy);                              
            fs.Close();                                                
        }

        //Wysiwtlenie nowego okna umożliwiającego wprowadzenie nowego dostawcę
        private void Btn_Dostawca_New_Click(object sender, EventArgs e)
        {
            Form_Nowy_Dostawca Nowy_Dostawca = new Form_Nowy_Dostawca();
            Nowy_Dostawca.ShowDialog();
        }      

        // Zamknięcie panelu produktów przy wciśnieciu przycisku back
        private void Btn_Produkty_Back_Click(object sender, EventArgs e)
        {
            UkryjPanele();
            listPanel[0].BringToFront();
        }    

        // Pokazanie panelu produktów po kliknięciu przycisk produkty
        private void Btn_Produkty_Click(object sender, EventArgs e)
        {
            listPanel[3].BringToFront();
        }    
        
        // Przekazanie wartości klikniętego elementu w tabeli do okna edycjii
        private void Btn_Dostawca_Edit_Click(object sender, EventArgs e)
        {
            Form_Edycja_Dostawcy Edycja_Dostawca = new Form_Edycja_Dostawcy();

            Edycja_Dostawca.Label_ID.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            Edycja_Dostawca.TextBox_Firma.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
            Edycja_Dostawca.TextBox_Nazwa.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
            Edycja_Dostawca.TextBox_NIP.Text = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
            Edycja_Dostawca.TextBox_Adres.Text = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
            Edycja_Dostawca.TextBox_Miejscowosc.Text = dataGridView2.SelectedRows[0].Cells[5].Value.ToString();
            Edycja_Dostawca.TextBox_Kod.Text = dataGridView2.SelectedRows[0].Cells[6].Value.ToString();

            Edycja_Dostawca.ShowDialog();
            Btn_Dostawca_Import.PerformClick();
        }

        //---------------------------------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------------------------------

        private void Btn_Produkty_Import_Click(object sender, EventArgs e)
        {
            FileStream fs2 = new FileStream("..\\..\\Pliki XML\\Produkty.xml", FileMode.Open, FileAccess.Read);
            listProdukty = (List<Produkty>)xs2.Deserialize(fs2);

            dataGridView3.DataSource = listProdukty;
            fs2.Close();
        }

    }
}
