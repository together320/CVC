using Serenity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CVC.Modules.Licensing.LicenseUpload
{
    [ReadPermission("Licensing:LicenseUpload:Read")]
    [ModifyPermission("Licensing:LicenseUpload:Modify")]
    public sealed class LicenseUploadRow
    {
    }
}