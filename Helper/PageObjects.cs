using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JksTstPrj01.Helper
{
    class PageObjects
    {
        public PageObjects()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.Name, Using = "q")]
        public IWebElement txtQ { get; set; }

        [FindsBy(How = How.Name, Using = "btnK")]
        public IWebElement btnBtnK { get; set; }

        public void FillUserForn(string q)
        {
            txtQ.EnterText(q);
            // funktioniert bei firefox irgendwie nicht ??? => btnBtnK.Click(); => also =>
            IWebElement eleBtn = PropertiesCollection.driver.FindElement(By.Name("btnK"));
            IJavaScriptExecutor js = (IJavaScriptExecutor)PropertiesCollection.driver;
            js.ExecuteScript("arguments[0].click()", eleBtn);
            Thread.Sleep(2000);
        }
    }
}
