using Infobutton_Merck_Automation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfobuttonMerckTests
{  [TestClass]
   public class InfobuttonICD9RequestTests : InfobuttonBaseMerckTest
    {   
        
        [TestMethod]
        public void SubmitICD9RequestTest()
        {
             InfobuttonPage.InputCodeVc("049").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.Icd9).Submit();
             

             
             
            
        }

        [TestMethod]
        public void SubmitICD9WithHtmlKnowledgeResponceTypeRequestTest()
        {
            InfobuttonPage.SelectHtmlKnowledgeResponceType();
            InfobuttonPage.InputCodeVc("049").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.Icd9).Submit();

        }

        [TestMethod]
        public void GenerateQueryURLICD9RequestTest()
        {
            InfobuttonPage. InputCodeVc("049"). WithMainSearchCriteriaCodeSystemVcs(VcsCodes.Icd9).GenerateQueryUrl();

        }


        [TestMethod]
        public void GenerateQueryUrlICD9WithHtmlKnowledgeResponceTypeRequestTest()
        {
            InfobuttonPage.SelectHtmlKnowledgeResponceType();
            InfobuttonPage.InputCodeVc("049").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.Icd9).GenerateQueryUrl();

        }

        [TestMethod]
        public void SubmitICD9RequestWithEmptyVotFieldTest()
        {
            InfobuttonPage.EmptyVotField();
            InfobuttonPage.InputCodeVc("049").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.Icd9).Submit();

        }

        [TestMethod]
        public void SubmitICD9WithHtmlKnowledgeResponceTypeRequestWithEmptyVotFieldTest()
        {
            InfobuttonPage.SelectHtmlKnowledgeResponceType();
            InfobuttonPage.EmptyVotField();
            InfobuttonPage.InputCodeVc("049").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.Icd9).Submit();

        }


        [TestMethod]
        public void GenerateQueryUrlICD9RequestWithEmptyVotFieldTest()
        {
            InfobuttonPage.EmptyVotField();
            InfobuttonPage.InputCodeVc("049").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.Icd9).GenerateQueryUrl();

        }

        [TestMethod]
        public void GenerateQueryUrlICD9WithHtmlKnowledgeResponceTypeRequestWithEmptyVotFieldTest()
        {
            InfobuttonPage.SelectHtmlKnowledgeResponceType();
            InfobuttonPage.EmptyVotField();
            InfobuttonPage.InputCodeVc("049").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.Icd9).GenerateQueryUrl();

        }


        [TestMethod]
        public void SubmitICD9RequestWithEmptyVdnFieldTest()
        {
            InfobuttonPage.EmptyVdnField();
            InfobuttonPage.InputCodeVc("049").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.Icd9).Submit();

        }

        [TestMethod]
        public void SubmitICD9WithHtmlKnowledgeResponceTypeRequestWithEmptyVdnFieldTest()
        {
            InfobuttonPage.SelectHtmlKnowledgeResponceType();
            InfobuttonPage.EmptyVdnField();
            InfobuttonPage.InputCodeVc("049").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.Icd9).Submit();

        }

        [TestMethod]
        public void GenerateQueryUrlICD9RequestWithEmptyVdnFieldTest()
        {
            InfobuttonPage.EmptyVdnField();
            InfobuttonPage.InputCodeVc("049").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.Icd9).GenerateQueryUrl();

        }

        [TestMethod]
        public void GenerateQueryUrlICD9WithHtmlKnowledgeResponceTypeRequestWithEmptyVdnFieldTest()
        {
            InfobuttonPage.SelectHtmlKnowledgeResponceType();
            InfobuttonPage.EmptyVdnField();
            InfobuttonPage.InputCodeVc("049").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.Icd9).GenerateQueryUrl();

        }

        [TestMethod]
        public void SubmitICD9RequestWithEmptyVotAndVdnFieldTest()
        {
            InfobuttonPage.EmptyVotField();
            InfobuttonPage.EmptyVdnField();
            InfobuttonPage.InputCodeVc("049").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.Icd9).Submit();

        }

        [TestMethod]
        public void SubmitICD9WithHtmlKnowledgeResponceTypeRequestWithEmptyVotAndVdnFieldTest()
        {
            InfobuttonPage.SelectHtmlKnowledgeResponceType();
            InfobuttonPage.EmptyVotField();
            InfobuttonPage.EmptyVdnField();
            InfobuttonPage.InputCodeVc("049").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.Icd9).Submit();

        }

        [TestMethod]
        public void GenerateQueryUrlICD9RequestWithEmptyVotAndVdnFieldTest()
        {
            InfobuttonPage.EmptyVotField();
            InfobuttonPage.EmptyVdnField();
            InfobuttonPage.InputCodeVc("049").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.Icd9).GenerateQueryUrl();

        }

        [TestMethod]
        public void GenerateQueryUrlICD9WithHtmlKnowledgeResponceTypeRequestWithEmptyVotAndVdnFieldTest()
        {
            InfobuttonPage.SelectHtmlKnowledgeResponceType();
            InfobuttonPage.EmptyVotField();
            InfobuttonPage.EmptyVdnField();
            InfobuttonPage.InputCodeVc("049").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.Icd9).GenerateQueryUrl();

        }

        [TestMethod]
        public void SubmitICD9RequestWithVotFieldTest()
        {
            InfobuttonPage.InputVotField("nethritis");
            InfobuttonPage.InputCodeVc("049").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.Icd9).Submit();

        }

        [TestMethod]
        public void SubmitICD9WithHtmlKnowledgeResponceTypeRequestWithVotFieldTest()
        {
            InfobuttonPage.SelectHtmlKnowledgeResponceType();
            InfobuttonPage.InputVotField("nethritis");
            InfobuttonPage.InputCodeVc("049").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.Icd9).Submit();

        }

        [TestMethod]
        public void GenerateQueryICD9RequestWithVotFieldTest()
        {
            InfobuttonPage.InputVotField("nethritis");
            InfobuttonPage.InputCodeVc("049").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.Icd9).GenerateQueryUrl();

        }

        [TestMethod]
        public void GenerateQueryUrlICD9WithHtmlKnowledgeResponceTypeRequestWithVotFieldTest()
        {
            InfobuttonPage.SelectHtmlKnowledgeResponceType();
            InfobuttonPage.InputVotField("nethritis");
            InfobuttonPage.InputCodeVc("049").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.Icd9).GenerateQueryUrl();

        }

        [TestMethod]
        public void SubmitICD9RequestWithVdnFieldTest()
        {
            InfobuttonPage.InputVdnField("nethritis");
            InfobuttonPage.InputCodeVc("049").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.Icd9).Submit();

        }

        [TestMethod]
        public void SubmitICD9WithHtmlKnowledgeResponceTypeRequestWithVdnFieldTest()
        {
            InfobuttonPage.SelectHtmlKnowledgeResponceType();
            InfobuttonPage.InputVdnField("nethritis");
            InfobuttonPage.InputCodeVc("049").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.Icd9).Submit();

        }

        [TestMethod]
        public void GenerateQueryICD9RequestWithVdnFieldTest()
        {
            InfobuttonPage.InputVdnField("nethritis");
            InfobuttonPage.InputCodeVc("049").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.Icd9).GenerateQueryUrl();

        }

        [TestMethod]
        public void GenerateQueryUrlICD9WithHtmlKnowledgeResponceTypeRequestWithVdnFieldTest()
        {
            InfobuttonPage.SelectHtmlKnowledgeResponceType();
            InfobuttonPage.InputVdnField("nethritis");
            InfobuttonPage.InputCodeVc("049").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.Icd9).GenerateQueryUrl();

        }

        [TestMethod]
        public void SubmitICD9RequestWithVotAndVdnFieldTest()
        {
            InfobuttonPage.InputVotField("syndrome");
            InfobuttonPage.InputVdnField("nethritis");
            InfobuttonPage.InputCodeVc("049").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.Icd9).Submit();

        }

        [TestMethod]
        public void SubmitICD9WithHtmlKnowledgeResponceTypeRequestWithVotAndVdnFieldTest()
        {
            InfobuttonPage.SelectHtmlKnowledgeResponceType();
            InfobuttonPage.InputVotField("syndrome");
            InfobuttonPage.InputVdnField("nethritis");
            InfobuttonPage.InputCodeVc("049").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.Icd9).Submit();

        }

        [TestMethod]
        public void GenerateQueryUrlICD9RequestWithVotAndVdnFieldTest()
        {
            InfobuttonPage.InputVotField("syndrome");
            InfobuttonPage.InputVdnField("nethritis");
            InfobuttonPage.InputCodeVc("049").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.Icd9).GenerateQueryUrl();

        }

        [TestMethod]
        public void GenerateQueryUrlICD9WithHtmlKnowledgeResponceTypeRequestWithVotAndVdnFieldTest()
        {
            InfobuttonPage.SelectHtmlKnowledgeResponceType();
            InfobuttonPage.InputVotField("syndrome");
            InfobuttonPage.InputVdnField("nethritis");
            InfobuttonPage.InputCodeVc("049").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.Icd9).GenerateQueryUrl();

        }
    }
}
