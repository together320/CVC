using Serenity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CVC.Modules.Licensing.License
{
    [ReadPermission("Licensing:License:Read")]
    [ModifyPermission("Licensing:License:Modify")]
    public sealed class LicenseRow
    {
    }
}