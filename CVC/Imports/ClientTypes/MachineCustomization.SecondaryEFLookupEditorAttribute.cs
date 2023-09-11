using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace CVC.MachineCustomization
{
    public partial class SecondaryEFLookupEditorAttribute : LookupEditorBaseAttribute
    {
        public const string Key = "CVC.MachineCustomization.SecondaryEFLookupEditor";

        public SecondaryEFLookupEditorAttribute()
            : base(Key)
        {
        }
    }
}

