using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amoba_Bodnar_Tesok
{
    public partial class Form1 : Form
    {
        static string nev1;
        static string nev2;
        static Button[,] gombtomb = new Button[10,10];
        string kezdo;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //40; 340   40; 370     114; 370    méret:75; 31
           
        }

        private void jatektergeneralas()
        {
            Random vsz = new Random();
            int kezdoszam = vsz.Next(0, 2);
            if(kezdoszam==0)
            {
                kezdo = nev1;
            }
            else
            {
                kezdo = nev2;
            }
            int seged = 0;
            for (int i = 0; i <10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    seged++;
                    Button button = new Button();
                    button.Location = new System.Drawing.Point((40 + (i * 75) + 20), (370 - (j * 30)));
                    button.Name = "gomb"+seged;
                    button.Text = seged.ToString();
                    button.Visible = true;
                    button.Size = new System.Drawing.Size(75, 31);
                    button.BackColor = Color.LightBlue;
                    button.TextAlign = ContentAlignment.MiddleCenter;              
                    button.Tag = "0";
                    Controls.Add(button);
                    button.BringToFront();
                    gombtomb[i, j] = button;
                    button.Click += new System.EventHandler(this.klikk);
                }
            }
            
        }
        private void klikk(object sender, EventArgs e)
        {
            Button klikkelt = sender as Button;
            MessageBox.Show($"{klikkelt.Text}");
        }
        private void Start_Click(object sender, EventArgs e)
        {
            ellenorzes();

        }

     

        private void ellenorzes()
        {
            nev1 =Name1.Text;
            nev2 = Name2.Text;
            if (nev1=="" || nev2=="")
            {
                MessageBox.Show("Add meg mind kettő játékos nevét.");
            }
            else
            {
                if (nev1==nev2)
                {
                    MessageBox.Show("Adj meg különböző neveket");
                }
                else
                {
                    jatektergeneralas();
                }
                
            }

        }
    }
}
