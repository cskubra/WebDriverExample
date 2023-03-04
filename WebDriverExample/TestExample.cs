using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Threading;

namespace WebDriverExample
{
    class TestExample
    {
        IWebDriver driver = new ChromeDriver(@"D:\WebDriver\Chrome");

        [SetUp]
        public void Initialize()
        {
            //navigate to URL  
            driver.Navigate().GoToUrl("http://www.ilkumut.biz/");

            //Maximize the browser window  
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);


        }


        [Test]
        public void ExecuteTest()
        {
            //find iletisim button and click  
            IWebElement iletisim = driver.FindElement(By.XPath("//a[@href='iletisim.aspx']"));
            iletisim.Click();

            //write name and surname
            IWebElement nameSurname = driver.FindElement(By.Id("ContentPlaceHolder1_txtadi"));
            nameSurname.SendKeys("Kubra Caliskan");
            //write email
            IWebElement eMail = driver.FindElement(By.Id("ContentPlaceHolder1_txtmail"));
            eMail.SendKeys("deneme@test.com");
            //write subject
            IWebElement konu = driver.FindElement(By.Id("ContentPlaceHolder1_txtkonu"));
            konu.SendKeys("Deneme Mesajı");
            //write message
            IWebElement mesaj = driver.FindElement(By.Id("ContentPlaceHolder1_txtmesaj"));
            mesaj.SendKeys("Deneme Mesajı");
                       
            //click on the send button  
            IWebElement gonder = driver.FindElement(By.Id("ContentPlaceHolder1_btngonder"));
            gonder.Click();
            Thread.Sleep(3000);
            //click close button after message send successfully
            IWebElement kapat = driver.FindElement(By.Id("ContentPlaceHolder1_WebMessageBox_btnClose"));
            kapat.Click();
            
        }

        [TearDown]
        public void EndTest()
        {
            //close the browser  
            driver.Close();
        }
    }
}
