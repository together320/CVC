using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace CVC.Common.CustomEditors
{
    public partial class ActivationValueEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "CVC.Common.CustomEditors.ActivationValueEditor";

        public ActivationValueEditorAttribute()
            : base(Key)
        {
        }
    }
}

