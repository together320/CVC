using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace CVC.Common.CustomEditors
{
    public partial class ColorPickerEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "CVC.Common.CustomEditors.ColorPickerEditor";

        public ColorPickerEditorAttribute()
            : base(Key)
        {
        }
    }
}

