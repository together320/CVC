using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CVC.Models
{
    public class TreeViewNodeVM
    {


        public TreeViewNodeVM()
        {

            RootNode = new List<parent>();
        }


        public List<parent> RootNode { get; set; }
    }

    public class parent
    {
        public parent()
        {
            ChildNode = new List<parent>();
        }
        
        public string TNode { get; set; }
        public string TUser { get; set; }

        public List<parent> ChildNode { get; set; }
    }

}