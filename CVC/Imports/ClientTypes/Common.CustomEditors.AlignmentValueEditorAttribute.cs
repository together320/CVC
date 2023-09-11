using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace CVC.Common.CustomEditors
{
    public partial class AlignmentValueEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "CVC.Common.CustomEditors.AlignmentValueEditor";

        public AlignmentValueEditorAttribute()
            : base(Key)
        {
        }
    }
}

