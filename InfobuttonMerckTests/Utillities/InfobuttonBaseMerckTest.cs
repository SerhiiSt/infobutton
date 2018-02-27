using Infobutton_Merck_Automation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfobuttonMerckTests
{
 public   class InfobuttonBaseMerckTest
    {
        [TestInitialize]
        public void Init()
        {
           Driver.Initialize();
           InfobuttonPage.GoTo();
            
        }

        [TestCleanup]
        public void Cleanup()
        {
         //  Driver.Close();
        }
    }
}
