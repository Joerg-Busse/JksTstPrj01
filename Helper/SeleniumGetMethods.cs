using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JksTstPrj01.Helper
{
    public static class SeleniumGetMethods
    {
        public static string GetText(IWebElement element)
        {
            //return element.GetAttribute("value");
            return new SelectElement(element).AllSelectedOptions.SingleOrDefault().Text;
        }

       
    }
}
