using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace CVC.MachineCustomization
{
    public partial class ListDisplayEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "CVC.MachineCustomization.ListDisplayEditor";

        public ListDisplayEditorAttribute()
            : base(Key)
        {
        }
    }
}

