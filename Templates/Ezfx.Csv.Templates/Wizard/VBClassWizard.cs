﻿using Microsoft.VisualStudio.TemplateWizard;

namespace Ezfx.Csv.Templates
{
    public class VBClassWizard : ClassWizard, IWizard
    {
        protected override string GetPropertyCode(CsvColumn col)
        {
            return col.ToVBCode();
        }
    }
}
