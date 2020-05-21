using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool sprawdzLiczbePierwsza(int value)
        {
            if (value < 2)
                return false; //gdy liczba jest mniejsza niż 2 to nie jest pierwszą

            for (int i = 2; i * i <= value; i++)
                if (value % i == 0)
                    return false; //gdy znajdziemy dzielnik, to dana liczba nie jest pierwsza

            return true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            label1.Text = " ";
            int value = int.Parse(textBox1.Text);

            if (sprawdzLiczbePierwsza(value))
            {
                label1.Text = "Liczba " + value + " jest liczba pierwsza";
            }
            else
            {
                label1.Text = "Liczba " + value + "nie jest liczba pierwsza";
            }
            
        }
    }
}
