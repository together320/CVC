
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
    [ReadPermission("ModuleManagement:ModuleAccess:Read")]
    [ModifyPermission("ModuleManagement:ModuleAccess:Modify")]
    public sealed class ModuleAccessRow
    {

    }
}
