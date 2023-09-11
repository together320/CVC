using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace CVC.Common.CustomColumnFormatters
{
    public partial class DOTypeColumnFormatterAttribute : CustomFormatterAttribute
    {
        public const string Key = "CVC.Common.CustomColumnFormatters.DOTypeColumnFormatter";

        public DOTypeColumnFormatterAttribute()
            : base(Key)
        {
        }
    }
}

