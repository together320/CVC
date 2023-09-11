using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace CVC.Common.CustomEditors
{
    public partial class NumberInputEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "CVC.Common.CustomEditors.NumberInputEditor";

        public NumberInputEditorAttribute()
            : base(Key)
        {
        }

        public Double Max
        {
            get { return GetOption<Double>("max"); }
            set { SetOption("max", value); }
        }

        public Double Min
        {
            get { return GetOption<Double>("min"); }
            set { SetOption("min", value); }
        }
    }
}

