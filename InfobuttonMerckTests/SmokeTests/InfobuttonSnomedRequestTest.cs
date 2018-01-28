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
  public  class InfobuttonSnomedRequestTest : InfobuttonBaseMerckTest
    {
        [TestMethod]
        public void SubmitSnomedRequestTest()
        {
            InfobuttonPage.InputCodeVc("222008").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.SnomedCt).Submit();

        }

        [TestMethod]
        public void SubmitSnomedWithHtmlKnowledgeResponceTypeRequestTest()
        {
            InfobuttonPage.SelectHtmlKnowledgeResponceType();
            InfobuttonPage.InputCodeVc("222008").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.SnomedCt).Submit();

        }

        [TestMethod]
        public void GenerateQueryURLSnomedRequestTest()
        {
            InfobuttonPage.InputCodeVc("222008").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.SnomedCt).GenerateQueryUrl();

        }

        [TestMethod]
        public void GenerateQueryUrlSnomedWithHtmlKnowledgeResponceTypeRequestTest()
        {
            InfobuttonPage.SelectHtmlKnowledgeResponceType();
            InfobuttonPage.InputCodeVc("222008").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.SnomedCt).GenerateQueryUrl();

        }

        [TestMethod]
        public void SubmitSnomedRequestWithEmptyVotFieldTest()
        {
            InfobuttonPage.EmptyVotField();
            InfobuttonPage.InputCodeVc("222008").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.SnomedCt).Submit();

        }

        [TestMethod]
        public void SubmitSnomedWithHtmlKnowledgeResponceTypeRequestWithEmptyVotFieldTest()
        {
            InfobuttonPage.SelectHtmlKnowledgeResponceType();
            InfobuttonPage.EmptyVotField();
            InfobuttonPage.InputCodeVc("222008").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.SnomedCt).Submit();

        }

        [TestMethod]
        public void GenerateQueryUrlSnomedRequestWithEmptyVotFieldTest()
        {
            InfobuttonPage.EmptyVotField();
            InfobuttonPage.InputCodeVc("222008").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.SnomedCt).GenerateQueryUrl();

        }

        [TestMethod]
        public void GenerateQueryUrlSnomedWithHtmlKnowledgeResponceTypeRequestWithEmptyVotFieldTest()
        {
            InfobuttonPage.SelectHtmlKnowledgeResponceType();
            InfobuttonPage.EmptyVotField();
            InfobuttonPage.InputCodeVc("222008").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.SnomedCt).GenerateQueryUrl();

        }


        [TestMethod]
        public void SubmitSnomedRequestWithEmptyVdnFieldTest()
        {
            InfobuttonPage.EmptyVdnField();
            InfobuttonPage.InputCodeVc("222008").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.SnomedCt).Submit();

        }

        [TestMethod]
        public void SubmitSnomedWithHtmlKnowledgeResponceTypeRequestWithEmptyVdnFieldTest()
        {
            InfobuttonPage.SelectHtmlKnowledgeResponceType();
            InfobuttonPage.EmptyVdnField();
            InfobuttonPage.InputCodeVc("222008").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.SnomedCt).Submit();

        }

        [TestMethod]
        public void GenerateQueryUrlSnomedRequestWithEmptyVdnFieldTest()
        {
            InfobuttonPage.EmptyVdnField();
            InfobuttonPage.InputCodeVc("222008").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.SnomedCt).GenerateQueryUrl();

        }

        [TestMethod]
        public void GenerateQueryUrlSnomedWithHtmlKnowledgeResponceTypeRequestWithEmptyVdnFieldTest()
        {
            InfobuttonPage.SelectHtmlKnowledgeResponceType();
            InfobuttonPage.EmptyVdnField();
            InfobuttonPage.InputCodeVc("222008").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.SnomedCt).GenerateQueryUrl();

        }

        [TestMethod]
        public void SubmitSnomedRequestWithEmptyVotAndVdnFieldTest()
        {
            InfobuttonPage.EmptyVotField();
            InfobuttonPage.EmptyVdnField();
            InfobuttonPage.InputCodeVc("222008").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.SnomedCt).Submit();

        }

        [TestMethod]
        public void SubmitSnomedWithHtmlKnowledgeResponceTypeRequestWithEmptyVotAndVdnFieldTest()
        {
            InfobuttonPage.SelectHtmlKnowledgeResponceType();
            InfobuttonPage.EmptyVotField();
            InfobuttonPage.EmptyVdnField();
            InfobuttonPage.InputCodeVc("222008").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.SnomedCt).Submit();

        }

        [TestMethod]
        public void GenerateQueryUrlSnomedRequestWithEmptyVotAndVdnFieldTest()
        {
            InfobuttonPage.EmptyVotField();
            InfobuttonPage.EmptyVdnField();
            InfobuttonPage.InputCodeVc("222008").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.SnomedCt).GenerateQueryUrl();

        }

        [TestMethod]
        public void GenerateQueryUrlSnomedWithHtmlKnowledgeResponceTypeRequestWithEmptyVotAndVdnFieldTest()
        {
            InfobuttonPage.SelectHtmlKnowledgeResponceType();
            InfobuttonPage.EmptyVotField();
            InfobuttonPage.EmptyVdnField();
            InfobuttonPage.InputCodeVc("222008").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.SnomedCt).GenerateQueryUrl();

        }

        [TestMethod]
        public void SubmitSnomedRequestWithVotFieldTest()
        {
            InfobuttonPage.InputVotField("nethritis");
            InfobuttonPage.InputCodeVc("222008").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.SnomedCt).Submit();

        }

        [TestMethod]
        public void SubmitSnomedWithHtmlKnowledgeResponceTypeRequestWithVotFieldTest()
        {
            InfobuttonPage.SelectHtmlKnowledgeResponceType();
            InfobuttonPage.InputVotField("nethritis");
            InfobuttonPage.InputCodeVc("222008").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.SnomedCt).Submit();

        }

        [TestMethod]
        public void GenerateQuerySnomedRequestWithVotFieldTest()
        {
            InfobuttonPage.InputVotField("nethritis");
            InfobuttonPage.InputCodeVc("222008").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.SnomedCt).GenerateQueryUrl();

        }

        [TestMethod]
        public void GenerateQueryUrlSnomedWithHtmlKnowledgeResponceTypeRequestWithVotFieldTest()
        {
            InfobuttonPage.SelectHtmlKnowledgeResponceType();
            InfobuttonPage.InputVotField("nethritis");
            InfobuttonPage.InputCodeVc("222008").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.SnomedCt).GenerateQueryUrl();

        }

        [TestMethod]
        public void SubmitSnomedRequestWithVdnFieldTest()
        {
            InfobuttonPage.InputVdnField("nethritis");
            InfobuttonPage.InputCodeVc("222008").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.SnomedCt).Submit();

        }

        [TestMethod]
        public void SubmitSnomedWithHtmlKnowledgeResponceTypeRequestWithVdnFieldTest()
        {
            InfobuttonPage.SelectHtmlKnowledgeResponceType();
            InfobuttonPage.InputVdnField("nethritis");
            InfobuttonPage.InputCodeVc("222008").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.SnomedCt).Submit();

        }

        [TestMethod]
        public void GenerateQuerySnomedRequestWithVdnFieldTest()
        {
            InfobuttonPage.InputVdnField("nethritis");
            InfobuttonPage.InputCodeVc("222008").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.SnomedCt).GenerateQueryUrl();

        }

        [TestMethod]
        public void GenerateQueryUrlSnomedWithHtmlKnowledgeResponceTypeRequestWithVdnFieldTest()
        {
            InfobuttonPage.SelectHtmlKnowledgeResponceType();
            InfobuttonPage.InputVdnField("nethritis");
            InfobuttonPage.InputCodeVc("222008").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.SnomedCt).GenerateQueryUrl();

        }

        [TestMethod]
        public void SubmitSnomedRequestWithVotAndVdnFieldTest()
        {
            InfobuttonPage.InputVotField("syndrome");
            InfobuttonPage.InputVdnField("nethritis");
            InfobuttonPage.InputCodeVc("222008").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.SnomedCt).Submit();

        }

        [TestMethod]
        public void SubmitSnomedWithHtmlKnowledgeResponceTypeRequestWithVotAndVdnFieldTest()
        {
            InfobuttonPage.SelectHtmlKnowledgeResponceType();
            InfobuttonPage.InputVotField("syndrome");
            InfobuttonPage.InputVdnField("nethritis");
            InfobuttonPage.InputCodeVc("222008").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.SnomedCt).Submit();

        }

        [TestMethod]
        public void GenerateQueryUrlSnomedRequestWithVotAndVdnFieldTest()
        {
            InfobuttonPage.InputVotField("syndrome");
            InfobuttonPage.InputVdnField("nethritis");
            InfobuttonPage.InputCodeVc("222008").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.SnomedCt).GenerateQueryUrl();

        }

        [TestMethod]
        public void GenerateQueryUrlSnomedWithHtmlKnowledgeResponceTypeRequestWithVotAndVdnFieldTest()
        {
            InfobuttonPage.SelectHtmlKnowledgeResponceType();
            InfobuttonPage.InputVotField("syndrome");
            InfobuttonPage.InputVdnField("nethritis");
            InfobuttonPage.InputCodeVc("222008").WithMainSearchCriteriaCodeSystemVcs(VcsCodes.SnomedCt).GenerateQueryUrl();

        }

    }
}
