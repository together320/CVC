// Decompiled with JetBrains decompiler
// Type: CVC.Modules.Common.BaseClass.ExtensionMethods
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using System;
using System.ComponentModel;
using System.Reflection;

namespace CVC.Modules.Common.BaseClass
{
  public static class ExtensionMethods
  {
    public static string ToIndianDateFormat(this DateTime? dateTime)
    {
      if (!dateTime.HasValue)
        return "";
      return dateTime.Value.ToString("dd/MM/yyyy");
    }

    public static string GetEnumText(this object EnumObj)
    {
      Type type = EnumObj.GetType();
      if (!type.IsEnum)
        throw new ArgumentException("EnumerationValue must be of Enum type", nameof (EnumObj));
      MemberInfo[] member = type.GetMember(EnumObj.ToString());
      if (member != null && member.Length != 0)
      {
        object[] customAttributes = member[0].GetCustomAttributes(typeof (DescriptionAttribute), false);
        if (customAttributes != null && customAttributes.Length != 0)
          return ((DescriptionAttribute) customAttributes[0]).Description;
      }
      return EnumObj.ToString();
    }
  }
}
