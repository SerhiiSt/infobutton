using Infobutton_Merck_Automation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfobuttonMerckTests
{       [TestClass]
        public class InfobuttonICD10CmRequestTest : InfobuttonBaseMerckTest
        {
        [TestMethod]
        public void SubmitICD10CmRequestTest()
        {
            InfobuttonPage.InputCodeVc("F17.210").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.Icd10Cm).Submit();
            InfobuttonResponcePageICD10.getResponce();

        }


        [TestMethod]
        public void SubmitICD10CmWithHtmlKnowledgeResponceTypeRequestTest()
        {
            InfobuttonPage.SelectHtmlKnowledgeResponceType();
            InfobuttonPage.InputCodeVc("F17.210").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.Icd10Cm).Submit();

        }

        [TestMethod]
        public void GenerateQueryURLICD10CmRequestTest()
        {
            InfobuttonPage.InputCodeVc("F17.210").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.Icd10Cm).GenerateQueryUrl();

        }

        [TestMethod]
        public void GenerateQueryUrlICD10CmWithHtmlKnowledgeResponceTypeRequestTest()
        {
            InfobuttonPage.SelectHtmlKnowledgeResponceType();
            InfobuttonPage.InputCodeVc("F17.210").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.Icd10Cm).GenerateQueryUrl();

        }

        [TestMethod]
        public void SubmitICD10CmRequestWithEmptyVotFieldTest()
        {
            InfobuttonPage.EmptyVotField();
            InfobuttonPage.InputCodeVc("F17.210").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.Icd10Cm).Submit();

        }

        [TestMethod]
        public void SubmitICD10CmWithHtmlKnowledgeResponceTypeRequestWithEmptyVotFieldTest()
        {
            InfobuttonPage.SelectHtmlKnowledgeResponceType();
            InfobuttonPage.EmptyVotField();
            InfobuttonPage.InputCodeVc("F17.210").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.Icd10Cm).Submit();

        }

        [TestMethod]
        public void GenerateQueryUrlICD10CmRequestWithEmptyVotFieldTest()
        {
            InfobuttonPage.EmptyVotField();
            InfobuttonPage.InputCodeVc("F17.210").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.Icd10Cm).GenerateQueryUrl();

        }

        [TestMethod]
        public void GenerateQueryUrlICD10CmWithHtmlKnowledgeResponceTypeRequestWithEmptyVotFieldTest()
        {
            InfobuttonPage.SelectHtmlKnowledgeResponceType();
            InfobuttonPage.EmptyVotField();
            InfobuttonPage.InputCodeVc("F17.210").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.Icd10Cm).GenerateQueryUrl();
        }


        [TestMethod]
        public void SubmitICD10CmRequestWithEmptyVdnFieldTest()
        {
            InfobuttonPage.EmptyVdnField();
            InfobuttonPage.InputCodeVc("F17.210").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.Icd10Cm).Submit();

        }

        [TestMethod]
        public void SubmitICD10CmWithHtmlKnowledgeResponceTypeRequestWithEmptyVdnFieldTest()
        {
            InfobuttonPage.SelectHtmlKnowledgeResponceType();
            InfobuttonPage.EmptyVdnField();
            InfobuttonPage.InputCodeVc("F17.210").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.Icd10Cm).Submit();

        }

        [TestMethod]
        public void GenerateQueryUrlICD10CmRequestWithEmptyVdnFieldTest()
        {
            InfobuttonPage.EmptyVdnField();
            InfobuttonPage.InputCodeVc("F17.210").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.Icd10Cm).GenerateQueryUrl();

        }

        [TestMethod]
        public void GenerateQueryUrlICD10CmWithHtmlKnowledgeResponceTypeRequestWithEmptyVdnFieldTest()
        {
            InfobuttonPage.SelectHtmlKnowledgeResponceType();
            InfobuttonPage.EmptyVdnField();
            InfobuttonPage.InputCodeVc("F17.210").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.Icd10Cm).GenerateQueryUrl();

        }

        [TestMethod]
        public void SubmitICD10CmRequestWithEmptyVotAndVdnFieldTest()
        {
            InfobuttonPage.EmptyVotField();
            InfobuttonPage.EmptyVdnField();
            InfobuttonPage.InputCodeVc("F17.210").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.Icd10Cm).Submit();

        }

        [TestMethod]
        public void SubmitICD10CmWithHtmlKnowledgeResponceTypeRequestWithEmptyVotAndVdnFieldTest()
        {
            InfobuttonPage.SelectHtmlKnowledgeResponceType();
            InfobuttonPage.EmptyVotField();
            InfobuttonPage.EmptyVdnField();
            InfobuttonPage.InputCodeVc("F17.210").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.Icd10Cm).Submit();

        }

        [TestMethod]
        public void GenerateQueryUrlICD10CmRequestWithEmptyVotAndVdnFieldTest()
        {
            InfobuttonPage.EmptyVotField();
            InfobuttonPage.EmptyVdnField();
            InfobuttonPage.InputCodeVc("F17.210").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.Icd10Cm).GenerateQueryUrl();

        }

        [TestMethod]
        public void GenerateQueryUrlICD10CmWithHtmlKnowledgeResponceTypeRequestWithEmptyVotAndVdnFieldTest()
        {
            InfobuttonPage.SelectHtmlKnowledgeResponceType();
            InfobuttonPage.EmptyVotField();
            InfobuttonPage.EmptyVdnField();
            InfobuttonPage.InputCodeVc("F17.210").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.Icd10Cm).GenerateQueryUrl();

        }

        [TestMethod]
        public void SubmitICD10CmRequestWithVotFieldTest()
        {
            InfobuttonPage.InputVotField("nethritis");
            InfobuttonPage.InputCodeVc("F17.210").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.Icd10Cm).Submit();

        }

        [TestMethod]
        public void SubmitICD10CmWithHtmlKnowledgeResponceTypeRequestWithVotFieldTest()
        {
            InfobuttonPage.SelectHtmlKnowledgeResponceType();
            InfobuttonPage.InputVotField("nethritis");
            InfobuttonPage.InputCodeVc("F17.210").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.Icd10Cm).Submit();

        }

        [TestMethod]
        public void GenerateQueryICD10CmRequestWithVotFieldTest()
        {
            InfobuttonPage.InputVotField("nethritis");
            InfobuttonPage.InputCodeVc("F17.210").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.Icd10Cm).GenerateQueryUrl();

        }

        [TestMethod]
        public void GenerateQueryUrlICD10CmWithHtmlKnowledgeResponceTypeRequestWithVotFieldTest()
        {
            InfobuttonPage.SelectHtmlKnowledgeResponceType();
            InfobuttonPage.InputVotField("nethritis");
            InfobuttonPage.InputCodeVc("F17.210").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.Icd10Cm).GenerateQueryUrl();

        }

        [TestMethod]
        public void SubmitICD10CmRequestWithVdnFieldTest()
        {
            InfobuttonPage.InputVdnField("nethritis");
            InfobuttonPage.InputCodeVc("F17.210").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.Icd10Cm).Submit();

        }

        [TestMethod]
        public void SubmitICD10CmWithHtmlKnowledgeResponceTypeRequestWithVdnFieldTest()
        {
            InfobuttonPage.SelectHtmlKnowledgeResponceType();
            InfobuttonPage.InputVdnField("nethritis");
            InfobuttonPage.InputCodeVc("F17.210").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.Icd10Cm).Submit();

        }

        [TestMethod]
        public void GenerateQueryICD10CmRequestWithVdnFieldTest()
        {
            InfobuttonPage.InputVdnField("nethritis");
            InfobuttonPage.InputCodeVc("F17.210").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.Icd10Cm).GenerateQueryUrl();

        }

        [TestMethod]
        public void GenerateQueryUrlICD10CmWithHtmlKnowledgeResponceTypeRequestWithVdnFieldTest()
        {
            InfobuttonPage.SelectHtmlKnowledgeResponceType();
            InfobuttonPage.InputVdnField("nethritis");
            InfobuttonPage.InputCodeVc("F17.210").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.Icd10Cm).GenerateQueryUrl();

        }

        [TestMethod]
        public void SubmitICD10CmRequestWithVotAndVdnFieldTest()
        {
            InfobuttonPage.InputVotField("syndrome");
            InfobuttonPage.InputVdnField("nethritis");
            InfobuttonPage.InputCodeVc("F17.210").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.Icd10Cm).Submit();

        }

        [TestMethod]
        public void SubmitICD10CmWithHtmlKnowledgeResponceTypeRequestWithVotAndVdnFieldTest()
        {
            InfobuttonPage.SelectHtmlKnowledgeResponceType();
            InfobuttonPage.InputVotField("syndrome");
            InfobuttonPage.InputVdnField("nethritis");
            InfobuttonPage.InputCodeVc("F17.210").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.Icd10Cm).Submit();

        }

        [TestMethod]
        public void GenerateQueryUrlICD10CmRequestWithVotAndVdnFieldTest()
        {
            InfobuttonPage.InputVotField("syndrome");
            InfobuttonPage.InputVdnField("nethritis");
            InfobuttonPage.InputCodeVc("F17.210").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.Icd10Cm).GenerateQueryUrl();

        }

        [TestMethod]
        public void GenerateQueryUrlICD10CmWithHtmlKnowledgeResponceTypeRequestWithVotAndVdnFieldTest()
        {
            InfobuttonPage.SelectHtmlKnowledgeResponceType();
            InfobuttonPage.InputVotField("syndrome");
            InfobuttonPage.InputVdnField("nethritis");
            InfobuttonPage.InputCodeVc("F17.210").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.Icd10Cm).GenerateQueryUrl();

        }
    }
}
