using System;
using System.Windows.Forms;

namespace WebScraping.Classe
{
    internal class ValidaBrowse
    {
        private string cmbselecione;

        public bool Valida_Select(string text, string txtpesquisa)
        {
            if(text == "Selecione um item")
            {
                MessageBox.Show("É necessário informar um item!");
            } 
            else if (string.IsNullOrEmpty(txtpesquisa))
            {
                MessageBox.Show("Preencha o campo de pesquisa!");
            } 
            else
            {
                CapturaSelenium IniciaCaptura = new CapturaSelenium();
                IniciaCaptura.CapturaLink(text, txtpesquisa);
            }
           
            return true;
        }

        //var options = new ChromeOptions();
        //var driver = new ChromeDriver(options);


    }
}
