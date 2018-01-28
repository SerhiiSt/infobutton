using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Infobutton_Merck_Automation
{
    public class InfobuttonPage
    {
        public static void GoTo()
        {

            Driver.Instance.Navigate().GoToUrl(Driver.BaseAddress + "professional/infobutton/test");
            var wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(5));
            wait.Until(d => d.SwitchTo().ActiveElement().FindElement(By.XPath(".//input[@name='mainSearchCriteria.v.c']")));

        }

        public static void SelectHtmlKnowledgeResponceType()
        {
            var element = Driver.Instance.FindElement(By.XPath(".//select[@name='knowledgeResponseType']"));
            new Actions(Driver.Instance).MoveToElement(element).Click();

            var subElement = Driver.Instance.FindElement(By.XPath(".//option[@value='text/html']"));
            new Actions(Driver.Instance).MoveToElement(subElement).Click();
            subElement.Click();

        }

        public static CodeCommand InputCodeVc(string code)
        {
            return new CodeCommand(code);
        }

        public static void GenerateQueryrequest()
        {
            var generateQueryRequestButton = Driver.Instance.FindElement(By.Id("generate-get-query"));
            generateQueryRequestButton.Click();
        }

        public static void EmptyVotField()
        {
            Driver.Instance.FindElement(By.XPath(".//input[@name='mainSearchCriteria.v.ot']")).Clear();
        }

        public static void EmptyVdnField()
        {
            Driver.Instance.FindElement(By.XPath(".//input[@name='mainSearchCriteria.v.dn']")).Clear();
        }

        public static void InputVotField(string keyWord)
        {
            EmptyVotField();
            Driver.Instance.FindElement(By.XPath(".//input[@name='mainSearchCriteria.v.ot']")).SendKeys(keyWord);
        }

        public static void InputVdnField(string keyWord)
        {
            EmptyVdnField();
            Driver.Instance.FindElement(By.XPath(".//input[@name='mainSearchCriteria.v.dn']")).SendKeys(keyWord);
        }
    }

    public class CodeCommand
    {
        private string code;
        private VcsCodes vcsCodes;

        public CodeCommand(string code)
        {
            this.code = code;
        }

        public  void Submit()
        {
            var mainSearchCriteriaCodeVc = Driver.Instance.FindElement(By.XPath(".//input[@name='mainSearchCriteria.v.c']"));
            mainSearchCriteriaCodeVc.Clear();
            mainSearchCriteriaCodeVc.SendKeys(Convert.ToString(code));

            var element = Driver.Instance.FindElement(By.XPath(".//select[@name='mainSearchCriteria.v.cs']"));
            new Actions(Driver.Instance).MoveToElement(element).Perform();
           
            var subElement = Driver.Instance.FindElement(By.XPath(".//option[@value='"+GetDescription(vcsCodes)+"']"));
            new Actions(Driver.Instance).MoveToElement(subElement).Perform();
            subElement.Click();
            
            var sendButton = Driver.Instance.FindElement(By.XPath(".//input[@value='Submit']"));
            sendButton.Click();
        }

        public void GenerateQueryUrl()
        {
            var mainSearchCriteriaCodeVc = Driver.Instance.FindElement(By.XPath(".//input[@name='mainSearchCriteria.v.c']"));
            mainSearchCriteriaCodeVc.Clear();
            mainSearchCriteriaCodeVc.SendKeys(Convert.ToString(code));

            var element = Driver.Instance.FindElement(By.XPath(".//select[@name='mainSearchCriteria.v.cs']"));
            new Actions(Driver.Instance).MoveToElement(element).Perform();

            var subElement = Driver.Instance.FindElement(By.XPath(".//option[@value='" + GetDescription(vcsCodes) + "']"));
            new Actions(Driver.Instance).MoveToElement(subElement).Perform();
            subElement.Click();

            var generateQueryRequestButton = Driver.Instance.FindElement(By.Id("generate-get-query"));
            generateQueryRequestButton.Click();
        }

        public CodeCommand WithMainSearchCriteriaCodeSystemVcs(VcsCodes vcsCodes)
        {
            this.vcsCodes = vcsCodes;
            return this;
        }

        public static string GetDescription(Enum value)
        {
            return
                value
                    .GetType()
                    .GetMember(value.ToString())
                    .FirstOrDefault()
                    .GetCustomAttribute<DescriptionAttribute>()
                    .Description;
        }
  
    }
}
