using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RegisztracioAlkalmazas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBoxkedvenchobbi.Items.Add("Úszás.");
            listBoxkedvenchobbi.Items.Add("Horgászat.");
            listBoxkedvenchobbi.Items.Add("Futás.");

            string neved = "";
            string szuletesidatumod = "";
            string nemed = "";
            string ujhobbi = "";

            mentes.Click += (sender, e) =>
            {

                DateTime time = dateTimePickerszuldatum.Value;
                string timestring = time.ToString();
                
                if (string.IsNullOrWhiteSpace(textBoxnev.Text))
                {
                    MessageBox.Show("Nem töltötted ki a nevedet.");
                    
                }
                else
                {

                    MessageBox.Show("A te neved:" + textBoxnev.Text);
                    neved = textBoxnev.Text;
                }

                MessageBox.Show("A te születési dátumod:" + dateTimePickerszuldatum.Value);
                dateTimePickerszuldatum.Value.ToShortDateString();
                szuletesidatumod = dateTimePickerszuldatum.Value.ToShortDateString();
      
                if(ferfi.Checked == true)
                {
                    nemed = "ferfi";
                    MessageBox.Show("A te nemed:" + nemed);
                }
                else
                {
                    nemed = "no";
                    MessageBox.Show("A te nemed:" + nemed);
                    
                }

                if (string.IsNullOrWhiteSpace(textBoxujhobbi.Text))
                {
                    MessageBox.Show("Nem töltötted ki az új hobbidat.");
                }
                else
                {

                    MessageBox.Show("A te új hobbid neve:" + textBoxujhobbi.Text);
                    ujhobbi = textBoxujhobbi.Text;
                }

               

            };
            hozzaad.Click += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBoxujhobbi.Text))
                {
                    MessageBox.Show("Nem adott meg adatot.");
                }
                else
                {
                    string ujhobbihozzadas = textBoxujhobbi.Text;
                    listBoxkedvenchobbi.Items.Add(ujhobbihozzadas);
                }
                
            };
            betoltes.Click += (sender, e) =>
            {
                listBoxkedvenchobbi.Items.Clear();



                string path = @"C:\Users\Diak\Desktop\RegisztracioAlkalmazas\betoltes.txt";

                 List<string> kiiratas = new List<string>();
                kiiratas.Add(neved);
                kiiratas.Add(szuletesidatumod);
                kiiratas.Add(nemed);
                kiiratas.Add(ujhobbi);

                foreach (var item in listBoxkedvenchobbi.Items)
                {
                    kiiratas.Add(item.ToString());
                }

                

                File.WriteAllLines(path, kiiratas);
               
                string[] betoltesfajlbol = File.ReadAllLines(path, Encoding.UTF8);
                listBoxkedvenchobbi.Items.Clear();
                textBoxnev.Text = betoltesfajlbol[0];
                szuldatum.Text = betoltesfajlbol[1];
                if (betoltesfajlbol[2] == "férfi")
                {
                    ferfi.Checked = true;
                    MessageBox.Show("A te nemed:" + nemed);
                }
                else
                {
                    no.Checked = true;
                    MessageBox.Show("A te nemed:" + nemed);

                }

                listBoxkedvenchobbi.Items.Add("Úszás.");
                listBoxkedvenchobbi.Items.Add("Horgászat.");
                listBoxkedvenchobbi.Items.Add("Futás.");
                for (int i = 3; i < betoltesfajlbol.Length; i++)
                {
                    listBoxkedvenchobbi.Items.Add(betoltesfajlbol[i]);
                }

            };
                      
        }
     
    }
}
