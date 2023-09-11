using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace CVC.Common.CustomEditors
{
    public partial class DefaultViewValueEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "CVC.Common.CustomEditors.DefaultViewValueEditor";

        public DefaultViewValueEditorAttribute()
            : base(Key)
        {
        }
    }
}

