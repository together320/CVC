
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace CVC.ExternalApplicationInterface.Entities
{
    [ReadPermission("ExternalApplicationInterface:LDAP:Read")]
    [ModifyPermission("ExternalApplicationInterface:LDAP:Modify")]
    public sealed class LDAPRow
    {
    }
}
