using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Infobutton_Merck_Automation
{
    public class InfobuttonResponcePageICD9
    {
        public static void getResponce()
        {


            string newWindowHandler = Driver.Instance.WindowHandles.FirstOrDefault();
            var newWindow = Driver.Instance.SwitchTo().Window(newWindowHandler);

            string expectedNewWindowUrl = "https://www.merckmanuals.com/custom/Infobutton/Search";
            Assert.AreEqual(expectedNewWindowUrl, newWindow.Url);

            var codeVc =  Driver.Instance.FindElement(By.XPath(".//*[@scheme='mainSearchCriteria.v.c']")).GetAttribute("term");
            Assert.AreEqual("049", codeVc, "Wrong Vc code");

            var codeVsc = Driver.Instance.FindElement(By.XPath(".//*[@scheme='mainSearchCriteria.v.cs']")).GetAttribute("term");
            Assert.AreEqual("2.16.840.1.113883.6.42", codeVsc, "Wrong Vsc code");


            Assert.IsTrue(IsAt,"Wrong number of search results");

    }


        public static void getOutput()
        {   //TODO create universal assertion 
            var h2Element = Driver.Instance.FindElement(By.Id("feedSubtitleText")).Text;
            Assert.AreEqual("MerckManuals Healthlink results for ICD-9 049", h2Element);
        }


        public static bool IsAt
        {
            get
            {
                var element = Driver.Instance.FindElements(By.TagName("entry"));
                if (element.Count >= 1)
                    return true;
                return false;
            }

        }

    }


}