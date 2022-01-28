using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using System.Threading;
using System.Collections.ObjectModel;
using System.IO;
using System.Text.RegularExpressions;
using OpenQA.Selenium.Interactions;

namespace WebScraping.Classe
{
    internal class CapturaSelenium
    {
        public string produto;
        public string url_pesquisa;
        public IWebDriver driver;
        private string baseURL;
        public string screenshotsPasta;
        int contador = 1;

        public bool CapturaLink(string text, string txtpesquisa)
        {
            if (text == "Amazon")
            {
                string BaseURL = "https://www.amazon.com.br/";
                CapturaAmazon(BaseURL, txtpesquisa);
            }
            else
            {
                string BaseURL = "https://www.magazineluiza.com.br/";
                CapturaMaga(BaseURL, txtpesquisa);
            }

            return true;

        }

        public bool CapturaAmazon(string text, string txtpesquisa)
        {

            try
            {

                ChromeDriverService service = ChromeDriverService.CreateDefaultService();
                service.HideCommandPromptWindow = true;

                var options = new ChromeOptions();

                #region Talvez seja util
                // options.AddArguments("--headless", "--no-sandbox", "--disable-web-security", "--disable-gpu", "--incognito", "--proxy-bypass-list=*", "--proxy-server='direct://'", "--log-level=3", "--hide-scrollbars");
                #endregion

                driver = new ChromeDriver(service, options);

                screenshotsPasta = @"E:\Curso\WebScraping\WebScraping\Util";


                driver.Navigate().GoToUrl(text);
                Thread.Sleep(3000);

                driver.FindElement(By.Id("twotabsearchtextbox")).SendKeys(txtpesquisa);
                driver.FindElement(By.Id("nav-search-submit-button")).Click();
                Thread.Sleep(2000);

                ReadOnlyCollection<IWebElement> allRows = driver.FindElements(By.ClassName("sg-col-4-of-12"));

                foreach (IWebElement row in allRows)
                {
                    #region pode ser util
                    //ReadOnlyCollection<IWebElement> cells = row.FindElements(By.TagName("td"));
                    //foreach (IWebElement cell in cells)
                    //{
                    //    Console.WriteLine("\t" + cell.Text);
                    //}
                    #endregion

                    if (row.Text.Contains("Patrocinados") || !row.Text.ToLower().Contains(txtpesquisa.ToLower()))
                    {
                        continue;
                    }
                    Regex informacoes = new Regex(row.Text.ToString());
                    produto = informacoes.Replace(informacoes.ToString(), txtpesquisa);
                    url_pesquisa = row.FindElement(By.ClassName("a-link-normal")).GetAttribute("href");

                    break;

                }

                Console.WriteLine("Criando um CSV!!!");

                string strSeperator = ";;;;;";
                StringBuilder sbOutput = new StringBuilder();
                sbOutput.AppendLine("Informações");
                sbOutput.AppendLine(string.Join(strSeperator, produto));
                sbOutput.AppendLine(url_pesquisa);

                string nameArquivo = screenshotsPasta + "\\" + txtpesquisa + "_Amazon.csv";
                // Create and write the csv file
                File.WriteAllText(nameArquivo, sbOutput.ToString());

                // To append more lines to the csv file
                //  File.AppendAllText(nameArquivo, sbOutput.ToString());


            }
            catch (Exception ex)
            {
                driver.Close();
                driver.Dispose();
                Console.WriteLine(ex.Message + " : " + ex.StackTrace);
                throw new Exception(ex.Message);
            }
            finally
            {
                driver.Close();
                driver.Dispose();
            }

            return true;
        }

        public bool CapturaMaga(string text, string txtpesquisa)
        {

            try
            {
                ChromeDriverService service = ChromeDriverService.CreateDefaultService();
                service.HideCommandPromptWindow = true;

                var options = new ChromeOptions();

                #region Pode ser util algum dia
                // options.AddArguments("--headless", "--no-sandbox", "--disable-web-security", "--disable-gpu", "--incognito", "--proxy-bypass-list=*", "--proxy-server='direct://'", "--log-level=3", "--hide-scrollbars");
                #endregion

                driver = new ChromeDriver(service, options);

                screenshotsPasta = @"E:\Curso\WebScraping\WebScraping\Util";


                driver.Navigate().GoToUrl(text);
                Thread.Sleep(3000);

                driver.FindElement(By.Id("input-search")).SendKeys(txtpesquisa);

                Actions action = new Actions(driver);
                IWebElement search = driver.FindElement(By.CssSelector("#search-container > div.sc-eCImPb.dAIaCU.sc-jYmNlR.fVizLQ > svg"));

                action.KeyDown(Keys.Enter).SendKeys(search, "qwerty").KeyUp(Keys.Enter).SendKeys("qwerty").Perform();

                Thread.Sleep(2000);


                ReadOnlyCollection<IWebElement> allRows = driver.FindElements(By.ClassName("sc-UMyrj"));

                foreach (IWebElement row in allRows)
                {
                    #region pode ser util
                    //ReadOnlyCollection<IWebElement> cells = row.FindElements(By.TagName("td"));
                    //foreach (IWebElement cell in cells)
                    //{
                    //    Console.WriteLine("\t" + cell.Text);
                    //}
                    #endregion

                    if (!row.Text.ToLower().Contains(txtpesquisa.ToLower()))
                    {
                        continue;
                    }

                    produto = row.Text.ToString();

                    url_pesquisa = row.FindElement(By.TagName("a")).GetAttribute("href");

                    break;

                }


                Console.WriteLine("Criando um CSV!!!");

                string strSeperator = ";;;;;";
                StringBuilder sbOutput = new StringBuilder();
                sbOutput.AppendLine("Informações");
                sbOutput.AppendLine(string.Join(strSeperator, produto));
                sbOutput.AppendLine(url_pesquisa);

                string nameArquivo = screenshotsPasta + "\\" + txtpesquisa + "_Maga.csv";
                // Create and write the csv file
                File.WriteAllText(nameArquivo, sbOutput.ToString());


            }
            catch (Exception ex)
            {
                driver.Close();
                driver.Dispose();
                Console.WriteLine(ex.Message + " : " + ex.StackTrace);
                throw new Exception(ex.Message);
            }
            finally
            {
                driver.Close();
                driver.Dispose();
            }

            return true;
        }

        public class Project
        {
            public string Product { get; set; }

        }

    }
}
