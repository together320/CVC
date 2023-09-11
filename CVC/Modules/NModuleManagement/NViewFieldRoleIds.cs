using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CVC.Modules.NModuleManagement
{
    public class NViewFieldRoleIds
    {
        [Required]
        public int ViewFieldId { get; set; }
        public string RoleIds { get; set; }
    }
}