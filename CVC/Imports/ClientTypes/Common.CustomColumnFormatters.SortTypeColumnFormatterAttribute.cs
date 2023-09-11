using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace CVC.Common.CustomColumnFormatters
{
    public partial class SortTypeColumnFormatterAttribute : CustomFormatterAttribute
    {
        public const string Key = "CVC.Common.CustomColumnFormatters.SortTypeColumnFormatter";

        public SortTypeColumnFormatterAttribute()
            : base(Key)
        {
        }
    }
}

