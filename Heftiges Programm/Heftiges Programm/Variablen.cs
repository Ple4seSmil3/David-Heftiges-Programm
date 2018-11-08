using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heftiges_Programm
{
    public partial class Variablen : Form
    {
        public Variablen()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "32 bits (4byte)" + Environment.NewLine + "Nur Ganzzahlig" + Environment.NewLine + "Zahlen von -2.147.483.648 bis 2.147.483.647";

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "32 bits (4byte)" + Environment.NewLine + "Kommezahlen moeglich" + Environment.NewLine + " Zahlen von -9.223.372.036.854.775.808 bis " + Environment.NewLine + "9.223.372.036.854.775.807	moglich";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "64 bits (8byte)" + Environment.NewLine + "Hoch genaue Kommzahl" + Environment.NewLine + "Zahlen von -1,79769313486232x10^308 bis " + Environment.NewLine + "1,79769313486232x10^308 moeglich";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "8 bits (1byte)" + Environment.NewLine + "Kleine Ganzzahl" + Environment.NewLine + "Zahlen von 0 bis " + Environment.NewLine + "255 moeglich";
        }

        private void Variablen_Load(object sender, EventArgs e)
        {
            
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "Kein oder mehrere Unicode-Zeichen " + Environment.NewLine + "innerhalb doppelten Anführungsstrichen";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "16 bits (2byte)" + Environment.NewLine + "Einzelnes Unicode-Zeichen innerhalb " + Environment.NewLine + "einfachen Anführungsstrichen";
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "8 bita (1byte)" + Environment.NewLine + "true oder false";
        }
    }
}
