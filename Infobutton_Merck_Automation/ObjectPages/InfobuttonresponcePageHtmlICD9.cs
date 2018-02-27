using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infobutton_Merck_Automation
{
    public class InfobuttonResponcePageHtmlICD9
    {

        public static void getResponce()
        {

            var wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(30));
            wait.Until(d => d.SwitchTo().ActiveElement().FindElement(By.TagName("h4")));

            var searchResults = Driver.Instance.FindElement(By.XPath(".//span[@data-bind='text: totalResults']")).Text;
            var number = int.Parse(searchResults.Split(' ')[0]);
            var h4s = Driver.Instance.FindElements(By.TagName("h4")).Count;

            Assert.AreEqual(number,h4s,"Wrong number search results");



        }




        public static bool IsAt
        {
            get
            {
                var h4s = Driver.Instance.FindElements(By.TagName("h4"));
                if (h4s.Count > 0)
                    return h4s[0].Text == "Medical Topic";
                return false;
            }

        }
    }
}
