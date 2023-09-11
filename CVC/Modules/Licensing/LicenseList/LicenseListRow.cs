using Serenity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CVC.Modules.Licensing.LicenseList
{
    [ReadPermission("Licensing:LicenseList:Read")]
    [ModifyPermission("Licensing:LicenseList:Modify")]
    public sealed class LicenseListRow
    {
    }
}