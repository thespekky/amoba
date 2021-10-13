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
        static int hanyadik = 0;
        static int[,] helyek = new int[10, 10];
        static string name = "";
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
                    button.Location = new System.Drawing.Point((450 + (i * 40) + 20), (400 - (j * 40)));
                    button.Name = i + " " + j;
                    button.Text = "";
                    button.Visible = true;
                    button.Size = new System.Drawing.Size(40, 40);
                    button.BackColor = Color.LightBlue;
                    button.TextAlign = ContentAlignment.MiddleCenter;              
                    button.Tag = "0";
                    Controls.Add(button);
                    button.BringToFront();
                    gombtomb[i, j] = button;
                    button.Click += new System.EventHandler(this.klikk);
                    helyek[i, j] = 0;
                }
            }
            MessageBox.Show("A kezdő játkos (aki az X): "+kezdo);
            
        }
        private void klikk(object sender, EventArgs e)
        {

            if (label3.Text=="X")
            {
                label3.Text = "O";
            }
            else
            {
                label3.Text = "X";
            }
            Button klikkelt = sender as Button;
            int i =Convert.ToInt32(klikkelt.Name.Split(' ')[0]);
            int j =Convert.ToInt32(klikkelt.Name.Split(' ')[1]);

            if (hanyadik%2==0)
            {
                klikkelt.Text = "X";
                klikkelt.Enabled = false;
                helyek[i, j] = 1;
                hanyadik++;
            }
            else
            {
                klikkelt.Text = "O";
                klikkelt.Enabled = false;
                helyek[i, j] = 2;
                hanyadik++;
            }
            label1.Focus();

            kinyert();

        }

        private void kinyert()
        {
            int X = 0;
            int O = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    
                    if (helyek[i,j]==1)
                    {
                        X++;
                        O = 0;
                    }
                    if (helyek[i, j] == 2)
                    {
                        O++;
                        X = 0;
                    }
                    if (O==5 || X==5)
                    {
                        nyert(hanyadik % 2);
                    }

                }
                O = 0;
                X = 0;
                
            }
            O = 0;
            X = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {

                    if (helyek[j, i] == 1)
                    {
                        X++;
                        O = 0;
                    }
                    if (helyek[j, i] == 2)
                    {
                        O++;
                        X = 0;
                    }
                    if (O == 5 || X == 5)
                    {
                        nyert(hanyadik%2);
                    }

                }
                O = 0;
                X = 0;

            }
            O = 0;
            X = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if(i+1<10&&i+2<10&&i+3<10&&i + 4 < 10&&j + 1 < 10 && j + 2 < 10 && j + 3 < 10 && j + 4 < 10)
                    { 
                        if(helyek[i,j]==1&& helyek[i+1, j+1] == 1 && helyek[i+2, j+2] == 1 && helyek[i+3, j+3] == 1 && helyek[i+4, j+4] == 1)
                        {
                            nyert(hanyadik % 2);
                            
                        }
                        if (helyek[i, j] == 2 && helyek[i + 1, j + 1] == 2 && helyek[i + 2, j + 2] == 2 && helyek[i + 3, j + 3] == 2 && helyek[i + 4, j + 4] == 2)
                        {
                            nyert(hanyadik % 2);
                           
                        }
                    }
                    if (i<=5&&j>=4)
                    {
                        if(helyek[i,j]==1&&helyek[i+1,j-1]==1&& helyek[i + 2, j - 2] == 1 && helyek[i + 3, j - 3] == 1 && helyek[i + 4, j - 4] == 1)
                        {
                            nyert(hanyadik % 2);
                            
                        }
                        if (helyek[i, j] == 2 && helyek[i + 1, j - 1] == 2 && helyek[i + 2, j - 2] == 2 && helyek[i + 3, j - 3] == 2 && helyek[i + 4, j - 4] == 2)
                        {
                            nyert(hanyadik % 2);
                            
                        }
                    }   
                }
                O = 0;
                X = 0;

            }
        }

        private void nyert(int nyertes)
        {
            //valamiért többször fut le 2 ször, de van hogy 3 szor
            if (nyertes==1)
            {
                MessageBox.Show("A Nyertesünk: "+kezdo);
            }
            else
            {
                if (nyertes == 0)
                {
                    if (kezdo == nev1)
                    {
                        MessageBox.Show("A Nyertesünk:  else1  " + nev2);
                    }
                    if (kezdo == nev2)
                    {
                        MessageBox.Show("A Nyertesünk: else2  " + nev1);
                    }

                }

            }
            
        }

        private void Start_Click(object sender, EventArgs e)
        {
            label1.Focus();
            
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
