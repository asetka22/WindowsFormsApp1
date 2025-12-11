using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace drugizadatak
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            string linija;
            linija = txtIme.Text + "|" + txtPrezime.Text + "|" + cbRazred.Text + "|" + cbUspjeh.Text;
            StreamWriter sw = new StreamWriter("imena.txt", true);
            sw.WriteLine(linija);
            sw.Close();
            txtIme.Text = "";
            txtPrezime.Text = "";
            cbRazred.Text = "";
            cbUspjeh.Text = "";

            MessageBox.Show("Podaci su spremljeni!");

        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
