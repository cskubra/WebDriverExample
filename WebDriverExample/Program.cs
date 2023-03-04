using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WebDriverExample
{
    internal class Program
    {

        //1.	Open the Google Chrome browser.
        //2.	Navigate to the BBC homepage.
        //3.	Maximize window
        //4.    Find "Sport" then click 
        //5.	Close the browser.
        static void Main(string[] args)
        {

            Console.Write("test case started ");
            //1
            IWebDriver driver = new ChromeDriver(@"D:\WebDriver\Chrome");
            //2
            driver.Navigate().GoToUrl("https://www.bbc.com/");
            //3
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            //4
            IWebElement ele = driver.FindElement(By.XPath("(//span[text()='Sport'])[2]"));
            ele.Click();
            Thread.Sleep(3000);

            //5
            driver.Close();
            Console.Write("test case ended ");
        }
    }
}
