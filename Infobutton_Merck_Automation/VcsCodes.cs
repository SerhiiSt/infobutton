using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infobutton_Merck_Automation
{
  public  enum VcsCodes
    {
        [Description("2.16.840.1.113883.6.42")] Icd9 ,
        [Description("2.16.840.1.113883.6.103")] Icd9Cm,
        [Description("2.16.840.1.113883.6.3")] Icd10,
        [Description("2.16.840.1.113883.6.90")] Icd10Cm,
        [Description("2.16.840.1.113883.6.1")] Loinc,
        [Description("2.16.840.1.113883.6.96")] SnomedCt,
        [Description("2.16.840.1.113883.6.1033")] Icd11,
        [Description("2.16.840.1.113883.6.88")] RxNorm

    }
}
