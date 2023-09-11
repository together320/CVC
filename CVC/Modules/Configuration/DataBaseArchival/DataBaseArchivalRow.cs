// Decompiled with JetBrains decompiler
// Type: CVC.Report.Entities.ArchivalRow
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace CVC.Configuration.Entities
{
    //[ConnectionKey("Default")]
    //[TableName("AlarmLogArchive")]
    //[DisplayName("AlarmLogArchive")]
    //[InstanceName("AlarmLogArchive")]
    //[TwoLevelCached(new string[] { })]
    [ReadPermission("Configuration:DataBaseArchival:Read")]
    [ModifyPermission("Configuration:DataBaseArchival:Modify")]

    public sealed class DataBaseArchivalRow
    {
    }
}
