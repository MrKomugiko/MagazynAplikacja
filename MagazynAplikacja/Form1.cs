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

        private void btn_loadXML_Click(object sender, EventArgs e)
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
                    wynik += myDiv[i].InnerText;
                    wynik += " \n ";
                }

                MessageBox.Show(wynik);
            }
        }
    }
}
