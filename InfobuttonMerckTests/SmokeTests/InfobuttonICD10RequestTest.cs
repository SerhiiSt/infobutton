using Infobutton_Merck_Automation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfobuttonMerckTests
{
        [TestClass]
     public   class InfobuttonICD10RequestTest : InfobuttonBaseMerckTest
    {
        [TestMethod]
        public void SubmitICD10RequestTest()
        {
            InfobuttonPage.InputCodeVc("F17.210").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.Icd10).Submit();
            InfobuttonResponcePageICD10.getResponce();

        }


        [TestMethod]
        public void SubmitICD10WithHtmlKnowledgeResponceTypeRequestTest()
        {
            InfobuttonPage.SelectHtmlKnowledgeResponceType();
            InfobuttonPage.InputCodeVc("F17.210").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.Icd10).Submit();

        }

        [TestMethod]
        public void GenerateQueryURLICD10RequestTest()
        {
            InfobuttonPage.InputCodeVc("F17.210").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.Icd10).GenerateQueryUrl();

        }

        [TestMethod]
        public void GenerateQueryUrlICD10WithHtmlKnowledgeResponceTypeRequestTest()
        {
            InfobuttonPage.SelectHtmlKnowledgeResponceType();
            InfobuttonPage.InputCodeVc("F17.210").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.Icd10).GenerateQueryUrl();

        }

        [TestMethod]
        public void SubmitICD10RequestWithEmptyVotFieldTest()
        {
            InfobuttonPage.EmptyVotField();
            InfobuttonPage.InputCodeVc("F17.210").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.Icd10).Submit();

        }

        [TestMethod]
        public void SubmitICD10WithHtmlKnowledgeResponceTypeRequestWithEmptyVotFieldTest()
        {
            InfobuttonPage.SelectHtmlKnowledgeResponceType();
            InfobuttonPage.EmptyVotField();
            InfobuttonPage.InputCodeVc("F17.210").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.Icd10).Submit();

        }

        [TestMethod]
        public void GenerateQueryUrlICD10RequestWithEmptyVotFieldTest()
        {
            InfobuttonPage.EmptyVotField();
            InfobuttonPage.InputCodeVc("F17.210").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.Icd10).GenerateQueryUrl();

        }

        [TestMethod]
        public void GenerateQueryUrlICD10WithHtmlKnowledgeResponceTypeRequestWithEmptyVotFieldTest()
        {
            InfobuttonPage.SelectHtmlKnowledgeResponceType();
            InfobuttonPage.EmptyVotField();
            InfobuttonPage.InputCodeVc("F17.210").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.Icd10).GenerateQueryUrl();
        }


        [TestMethod]
        public void SubmitICD10RequestWithEmptyVdnFieldTest()
        {
            InfobuttonPage.EmptyVdnField();
            InfobuttonPage.InputCodeVc("F17.210").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.Icd10).Submit();

        }

        [TestMethod]
        public void SubmitICD10WithHtmlKnowledgeResponceTypeRequestWithEmptyVdnFieldTest()
        {
            InfobuttonPage.SelectHtmlKnowledgeResponceType();
            InfobuttonPage.EmptyVdnField();
            InfobuttonPage.InputCodeVc("F17.210").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.Icd10).Submit();

        }

        [TestMethod]
        public void GenerateQueryUrlICD10RequestWithEmptyVdnFieldTest()
        {
            InfobuttonPage.EmptyVdnField();
            InfobuttonPage.InputCodeVc("F17.210").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.Icd10).GenerateQueryUrl();

        }

        [TestMethod]
        public void GenerateQueryUrlICD10WithHtmlKnowledgeResponceTypeRequestWithEmptyVdnFieldTest()
        {
            InfobuttonPage.SelectHtmlKnowledgeResponceType();
            InfobuttonPage.EmptyVdnField();
            InfobuttonPage.InputCodeVc("F17.210").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.Icd10).GenerateQueryUrl();

        }

        [TestMethod]
        public void SubmitICD10RequestWithEmptyVotAndVdnFieldTest()
        {
            InfobuttonPage.EmptyVotField();
            InfobuttonPage.EmptyVdnField();
            InfobuttonPage.InputCodeVc("F17.210").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.Icd10).Submit();

        }

        [TestMethod]
        public void SubmitICD10WithHtmlKnowledgeResponceTypeRequestWithEmptyVotAndVdnFieldTest()
        {
            InfobuttonPage.SelectHtmlKnowledgeResponceType();
            InfobuttonPage.EmptyVotField();
            InfobuttonPage.EmptyVdnField();
            InfobuttonPage.InputCodeVc("F17.210").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.Icd10).Submit();

        }

        [TestMethod]
        public void GenerateQueryUrlICD10RequestWithEmptyVotAndVdnFieldTest()
        {
            InfobuttonPage.EmptyVotField();
            InfobuttonPage.EmptyVdnField();
            InfobuttonPage.InputCodeVc("F17.210").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.Icd10).GenerateQueryUrl();

        }

        [TestMethod]
        public void GenerateQueryUrlICD10WithHtmlKnowledgeResponceTypeRequestWithEmptyVotAndVdnFieldTest()
        {
            InfobuttonPage.SelectHtmlKnowledgeResponceType();
            InfobuttonPage.EmptyVotField();
            InfobuttonPage.EmptyVdnField();
            InfobuttonPage.InputCodeVc("F17.210").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.Icd10).GenerateQueryUrl();

        }

        [TestMethod]
        public void SubmitICD10RequestWithVotFieldTest()
        {
            InfobuttonPage.InputVotField("nethritis");
            InfobuttonPage.InputCodeVc("F17.210").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.Icd10).Submit();

        }

        [TestMethod]
        public void SubmitICD10WithHtmlKnowledgeResponceTypeRequestWithVotFieldTest()
        {
            InfobuttonPage.SelectHtmlKnowledgeResponceType();
            InfobuttonPage.InputVotField("nethritis");
            InfobuttonPage.InputCodeVc("F17.210").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.Icd10).Submit();

        }

        [TestMethod]
        public void GenerateQueryICD10RequestWithVotFieldTest()
        {
            InfobuttonPage.InputVotField("nethritis");
            InfobuttonPage.InputCodeVc("F17.210").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.Icd10).GenerateQueryUrl();

        }

        [TestMethod]
        public void GenerateQueryUrlICD10WithHtmlKnowledgeResponceTypeRequestWithVotFieldTest()
        {
            InfobuttonPage.SelectHtmlKnowledgeResponceType();
            InfobuttonPage.InputVotField("nethritis");
            InfobuttonPage.InputCodeVc("F17.210").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.Icd10).GenerateQueryUrl();

        }

        [TestMethod]
        public void SubmitICD10RequestWithVdnFieldTest()
        {
            InfobuttonPage.InputVdnField("nethritis");
            InfobuttonPage.InputCodeVc("F17.210").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.Icd10).Submit();

        }

        [TestMethod]
        public void SubmitICD10WithHtmlKnowledgeResponceTypeRequestWithVdnFieldTest()
        {
            InfobuttonPage.SelectHtmlKnowledgeResponceType();
            InfobuttonPage.InputVdnField("nethritis");
            InfobuttonPage.InputCodeVc("F17.210").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.Icd10).Submit();

        }

        [TestMethod]
        public void GenerateQueryICD10RequestWithVdnFieldTest()
        {
            InfobuttonPage.InputVdnField("nethritis");
            InfobuttonPage.InputCodeVc("F17.210").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.Icd10).GenerateQueryUrl();

        }

        [TestMethod]
        public void GenerateQueryUrlICD10WithHtmlKnowledgeResponceTypeRequestWithVdnFieldTest()
        {
            InfobuttonPage.SelectHtmlKnowledgeResponceType();
            InfobuttonPage.InputVdnField("nethritis");
            InfobuttonPage.InputCodeVc("F17.210").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.Icd10).GenerateQueryUrl();

        }

        [TestMethod]
        public void SubmitICD10RequestWithVotAndVdnFieldTest()
        {
            InfobuttonPage.InputVotField("syndrome");
            InfobuttonPage.InputVdnField("nethritis");
            InfobuttonPage.InputCodeVc("F17.210").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.Icd10).Submit();

        }

        [TestMethod]
        public void SubmitICD10WithHtmlKnowledgeResponceTypeRequestWithVotAndVdnFieldTest()
        {
            InfobuttonPage.SelectHtmlKnowledgeResponceType();
            InfobuttonPage.InputVotField("syndrome");
            InfobuttonPage.InputVdnField("nethritis");
            InfobuttonPage.InputCodeVc("F17.210").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.Icd10).Submit();

        }

        [TestMethod]
        public void GenerateQueryUrlICD10RequestWithVotAndVdnFieldTest()
        {
            InfobuttonPage.InputVotField("syndrome");
            InfobuttonPage.InputVdnField("nethritis");
            InfobuttonPage.InputCodeVc("F17.210").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.Icd10).GenerateQueryUrl();

        }

        [TestMethod]
        public void GenerateQueryUrlICD10WithHtmlKnowledgeResponceTypeRequestWithVotAndVdnFieldTest()
        {
            InfobuttonPage.SelectHtmlKnowledgeResponceType();
            InfobuttonPage.InputVotField("syndrome");
            InfobuttonPage.InputVdnField("nethritis");
            InfobuttonPage.InputCodeVc("F17.210").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.Icd10).GenerateQueryUrl();

        }


    }
}
