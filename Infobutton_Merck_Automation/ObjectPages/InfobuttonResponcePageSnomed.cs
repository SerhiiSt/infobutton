using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infobutton_Merck_Automation
{
   public class InfobuttonResponcePageSnomed
    {
        public static void getResponce()
        {


            string newWindowHandler = Driver.Instance.WindowHandles.FirstOrDefault();
            var newWindow = Driver.Instance.SwitchTo().Window(newWindowHandler);

            string expectedNewWindowUrl = "https://www.merckmanuals.com/custom/Infobutton/Search";
            Assert.AreEqual(expectedNewWindowUrl, newWindow.Url);

            var codeVc = Driver.Instance.FindElement(By.XPath(".//*[@scheme='mainSearchCriteria.v.c']")).GetAttribute("term");
            Assert.AreEqual("222008", codeVc, "Wrong Vc code");

            var codeVsc = Driver.Instance.FindElement(By.XPath(".//*[@scheme='mainSearchCriteria.v.cs']")).GetAttribute("term");
            Assert.AreEqual("2.16.840.1.113883.6.96", codeVsc, "Wrong Vsc code");


            Assert.IsTrue(IsAt, "Wrong number of search results");



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

