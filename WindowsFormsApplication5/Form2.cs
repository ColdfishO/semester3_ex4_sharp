using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form2 : Form
    {
        int liczba=0;
        string nastroj= "domyslny";
        Image img = Properties.Resources.smile1;

        public Form2()
        {
            InitializeComponent();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            CheckBox[] listaodp = new CheckBox[]
            {
                checkBox1, checkBox2, checkBox3, checkBox4, checkBox5, checkBox6, checkBox7, checkBox8, checkBox9, checkBox10
            };
            foreach(CheckBox cb in listaodp)
            {
                if (cb.Checked == true)
                {
                    liczba++;
                }
                
            }
            panel1.Hide();
            if(liczba < 4)
            {
                nastroj = "Wesoły";
                 img = Properties.Resources.smile1;

            }
            else
            {
                if (liczba < 6)
                {
                    nastroj = "cool";
                     img = Properties.Resources.smile2;
                }
                else
                {
                    if (liczba < 8)
                    {
                        nastroj = "zdenerwowany";
                        img = Properties.Resources.smile3;
                    }
                    else
                    {
                        if (liczba < 9)
                        {
                            nastroj = "smutny";
                            img = Properties.Resources.smile4;
                        }
                        else
                        {
                            nastroj = "wystraszony";
                            img = Properties.Resources.smile5;
                        }
                    }
                }
            }
            pictureBox1.Image = img;
            label2.Text = nastroj;
            label2.Show();
            pictureBox1.Show();
            button1.Hide();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
