using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CVC.Modules.NModuleManagement
{
    public class NViewFieldForm
    {
        //[LookupEditor(typeof(ViewsRow))]
        public int ViewField { get; set; }
        [Required]
        public int ViewsId { get; set; }
        [Required]
        public string ViewFieldName { get; set; }
        //[LookupEditor(typeof(MachineParameterRow))]
        [Required]
        public int MachineParameterId { get; set; }
        //[LookupEditor(typeof(StatusRow))]
        [Required]
        public int StatusId { get; set; }

        public int? Sequence { get; set; }

        public int ModuleId { get; set; }

        public bool IsPopUpRequired { get; set; }

        public bool IsCommentRequired { get; set; }

        public bool IsAuthenticationRequired { get; set; }

        public string RoleIds { get; set; }

        public string RoleIdsArray { get; set; }

        public IEnumerable<SelectListItem> RoleList { get; set; }
        //public int CreatedBy { get; set; }
        //public DateTime CreatedDate { get; set; }
        //public int UpdatedBy { get; set; }
        //public DateTime UpdatedDate { get; set; }
    }
}