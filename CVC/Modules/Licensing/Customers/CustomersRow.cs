using Serenity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CVC.Modules.Licensing.Customers
{
    [ReadPermission("Licensing:Customers:Read")]
    [ModifyPermission("Licensing:Customers:Modify")]
    public sealed class CustomersRow
    {
    }
}