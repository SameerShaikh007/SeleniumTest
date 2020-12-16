using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Selenium_POC
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            IWebDriver webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("http://www.google.com");
            webDriver.FindElement(By.Name("q")).SendKeys("Learn Selenuim");
            webDriver.TakeScreenshot();
            //webDriver.Quit();
            //webDriver.Close();
        }
    }
}
