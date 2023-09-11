using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace CVC.Common.CustomColumnFormatters
{
    public partial class DefaultViewColumnFormattersAttribute : CustomFormatterAttribute
    {
        public const string Key = "CVC.Common.CustomColumnFormatters.DefaultViewColumnFormatters";

        public DefaultViewColumnFormattersAttribute()
            : base(Key)
        {
        }
    }
}

