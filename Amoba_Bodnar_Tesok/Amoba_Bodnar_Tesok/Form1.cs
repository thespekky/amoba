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
        static Button[,] gombtomb = new Button[10,10];
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
            int seged = 0;
            for (int i = 0; i <10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    seged++;
                    Button button = new Button();
                    button.Location = new System.Drawing.Point((40 + (i * 75) + 20), (370 - (j * 30)));
                    button.Name = "gomb"+seged;
                    button.Text = "";
                    button.Visible = true;
                    button.Size = new System.Drawing.Size(75, 31);
                    button.BackColor = Color.LightBlue;
                    button.TextAlign = ContentAlignment.MiddleCenter;
                    Controls.Add(button);
                    button.BringToFront();
                    button.Tag = "0";
                    gombtomb[i, j] = button;
                }
            }
            
        }

        private void Start_Click(object sender, EventArgs e)
        {
            jatektergeneralas();
        }
    }
}
