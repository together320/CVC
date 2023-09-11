
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace CVC.ModuleManagement.Entities
{
    [ConnectionKey("Default")]
    [TableName("AlarmLogArchive")]
    [DisplayName("AlarmLogArchive")]
    [InstanceName("AlarmLogArchive")]
    [TwoLevelCached(new string[] { })]
    [ReadPermission("ModuleManagement:ModuleView:Read")]
    [ModifyPermission("ModuleManagement:ModuleView:Modify")]
    public sealed class ModuleViewRow
    {

    }
}
