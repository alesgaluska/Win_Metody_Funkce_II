using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_Metody_Funkce_II
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += SectiDvaCisla(10, 20).ToString() + Environment.NewLine;
            textBox1.Text += NasobDvaCisla(5, 5).ToString() + Environment.NewLine;
            textBox1.Text += SlucTriRetezce("Teta", "sla", "ven");
        }

        public int SectiDvaCisla(int cislo1, int cislo2)
        {
            return cislo1 + cislo2;
        }

        public int NasobDvaCisla(int cislo1, int cislo2)
        {
            return cislo1 * cislo2;
        }

        public string SlucTriRetezce(string retezec1, string retezec2, string retezec3)
        {
            return retezec1 + " " + retezec2 + " " + retezec3 + " ";
        }
    }
}
