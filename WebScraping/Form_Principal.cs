using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebScraping.Classe;

namespace WebScraping
{
    public partial class Form_Principal : Form
    {
        public Form_Principal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ValidaBrowse Valida = new ValidaBrowse();
            Valida.Valida_Select(cmbselecione.Text, txtpesquisar.Text);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtpesquisar_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
