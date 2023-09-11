using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using CVC.Administration;
using Serenity.Abstractions;
using Serenity.Data;
using Serenity.Services;
using Serenity.Web;
using Serenity.Web.Providers;
using System.Web.Mvc;
using System.Web.Security;
using CVC.Membership;
namespace CVC.Models
{
    [RoutePrefix("LDAP")]
    [Route("{action=index}")]
    public class TreeViewModel : ServiceEndpoint
    {


        public TreeViewNodeVM GetTreeview(string username, string password, string LDAPUrl)
        {
            TreeViewNodeVM rootnode = new TreeViewNodeVM();
            if (username != null && password != null)
            {

                //string strLDAP = System.Configuration.ConfigurationManager.ConnectionStrings["ADConnectionString"].ToString();
                System.DirectoryServices.DirectoryEntry ADentry = new System.DirectoryServices.DirectoryEntry(LDAPUrl, username, password, AuthenticationTypes.Secure);
                DirectorySearcher Searcher = new DirectorySearcher(ADentry);
                Searcher.Filter = ("(&(objectCategory=Person)(objectClass=user)");

                foreach (System.DirectoryServices.DirectoryEntry firstChild in ADentry.Children)
                {



                    string rootName = string.Empty;
                    parent ChildNode = new parent();



                    if (firstChild.Name.Contains("OU"))
                    {

                        rootName = firstChild.Name.Remove(0, 3);


                        if (firstChild.Name.Remove(0, 3) != "Domain Controllers")
                        {
                            foreach (System.DirectoryServices.DirectoryEntry secondchild in firstChild.Children)
                            {
                                parent ChildNode1 = new parent();
                                ChildNode1.TNode = secondchild.Name.Remove(0, 3);
                                //string struser = UserDetails(secondchild.Name.Remove(0, 3));
                                //  ChildNode1.TUser = struser;
                                ChildNode.ChildNode.Add(ChildNode1);

                                if (secondchild.Children != null)
                                {

                                }
                            }
                        }


                        ChildNode.TNode = firstChild.Name.Remove(0, 3);
                        //ChildNode.TUser = firstChild.Username;
                        rootnode.RootNode.Add(ChildNode);
                    }
                }



                return rootnode;
            }
            else
            {
                return null;
            }
        }

    }
}