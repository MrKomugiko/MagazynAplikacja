using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MagazynAplikacja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_loadXML_Click(object sender, EventArgs e)
        {
            string wynik = " ";
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "XML|*.xml";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load(ofd.FileName);
                var myDiv = xDoc.DocumentElement.SelectNodes("//Faktura/Dostawca/Nazwa");

                for (int i = 0; i < myDiv.Count; i++)
                {
                    wynik += "[" + (i + 1) + "] " + myDiv[i].InnerText + " \n ";
                }

                label_WynikDostawcy.Text = wynik;
            }
        }

        private void button_Dodaj_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = textBox_Nazwa.Text;
            dataGridView1.Rows[n].Cells[1].Value = textBox_Netto.Text;
            dataGridView1.Rows[n].Cells[2].Value = textBox_VAT.Text;
            dataGridView1.Rows[n].Cells[3].Value = textBox_Brutto.Text;

        }

        private void label1_Click(object sender, EventArgs e)
        {

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
                ds.Tables["Produkt"].Rows.Add(row1);
            }
            ds.WriteXml("C:\\Users\\Kuba\\Data.xml");
            
            
        }

        private void button_Zaladuj_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml("C:\\Users\\Kuba\\Data.xml");
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

            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox_Nazwa.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox_Netto.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox_VAT.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox_Brutto.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void button_Edytuj_Click(object sender, EventArgs e)
        {
            dataGridView1.SelectedRows[0].Cells[0].Value = textBox_Nazwa.Text;
            dataGridView1.SelectedRows[0].Cells[1].Value = textBox_Netto.Text;
            dataGridView1.SelectedRows[0].Cells[2].Value = textBox_VAT.Text;
            dataGridView1.SelectedRows[0].Cells[3].Value = textBox_Brutto.Text;
       
        }

        private void button_Usun_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
        }
    }
}
