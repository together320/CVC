using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.DirectoryServices.AccountManagement;
namespace CVC.Models
{
    public class ADUser
    {
        public string UserDetails(string gname)
        {
            string struserdetail = "";
            using (var context = new PrincipalContext(ContextType.Domain, "intelgain"))
            {
                using (var searcher = new PrincipalSearcher(new UserPrincipal(context)))
                {
                    foreach (var result in searcher.FindAll())
                    {
                        if (result.Name == gname)
                        {
                            System.DirectoryServices.DirectoryEntry de = result.GetUnderlyingObject() as System.DirectoryServices.DirectoryEntry;
                            struserdetail = de.Properties["givenName"].Value + " " + de.Properties["sn"].Value + " " + de.Properties["samAccountName"].Value + " " + de.Properties["userPrincipalName"].Value;
                        }

                    }



                }

            }
            return struserdetail;
        }
    }
}