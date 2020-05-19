using JksTstPrj01.Helper;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Install-Package Selenium.WebDriver -Version 3.141.0
//Install-Package Selenium.Firefox.WebDriver -Version 0.26.0
//Install-Package NUnit3TestAdapter -Version 3.16.1
//Install-Package NUnit -Version 3.12.0
//Install-Package NUnit.Runners -Version 3.11.1
//Install-Package Selenium.Support -Version 3.141.0

namespace JksTstPrj01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Der FireFox-Browser wurde initialisiert.");
        }

        [SetUp]
        public void Initialize()
        {
            PropertiesCollection.driver = new FirefoxDriver();
            PropertiesCollection.driver.Navigate().GoToUrl("http://www.google.de");

            Console.WriteLine("Die URL wird aufgerufen.");
        }

        [Test]
        public void ExecuteTest()
        {
            PageObjects page = new PageObjects();
            page.FillUserForn("Jenkins ci");

            Console.WriteLine("Test wird ausgeführt");
        }

        [TearDown]
        public void CleanUp()
        {
            PropertiesCollection.driver.Close();

            Console.WriteLine("Browser wird geschlossen");
        }
    }
}
