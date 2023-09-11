// Decompiled with JetBrains decompiler
// Type: CVC.Administration.Forms.UserForm
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Administration.Entities;
using CVC.Configuration.Entities;
using CVC.Configuration.Scripts;
using Serenity.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;


namespace CVC.Administration.Forms
{
    [FormScript("Administration.User")]
    [BasedOnRow(typeof(UserRow))]
    public class UserForm
    {
        [Category("User Login & Role")]
        [LabelWidth(190)]
        [HalfWidth]
        public string EmployeeId { get; set; }

        [LabelWidth(190)]
        [HalfWidth]
        public string FirstName { get; set; }

        [LabelWidth(190)]
        [HalfWidth]
        public string LastName { get; set; }

        [LabelWidth(190)]
        [HalfWidth]
        [LookupEditor(typeof(DepartmentRow))]
        public int DepartmentId { get; set; }

        [LabelWidth(190)]
        [HalfWidth]
        public string Designation { get; set; }

        [LabelWidth(190)]
        [HalfWidth]
        public int MobileCode { get; set; }

        [LabelWidth(190)]
        [HalfWidth]
        public Int64 MobileNumber { get; set; }

        [LabelWidth(190)]
        [HalfWidth]
        public DateTime BirthDate { get; set; }

        [EmailEditor]
        [LabelWidth(190)]
        [HalfWidth]
        public string Email { get; set; }

        [LabelWidth(190)]
        [HalfWidth]
        [Updatable(false)]
        public string Username { get; set; }

        [LabelWidth(190)]
        [HalfWidth]
        [PasswordEditor]
        [Required(true)]
        //[Updatable(false)]
        public string Password { get; set; }

        [LabelWidth(190)]
        [HalfWidth]
        [PasswordEditor]
        [OneWay]
        [Required(true)]
        //[Updatable(false)]
        public string PasswordConfirm { get; set; }

        [LabelWidth(190)]
        [HalfWidth]
        [LookupEditor(typeof(RoleRow))]
        //[LookupEditor(typeof(RoleLookup))]
        public int RoleId { get; set; }

        [Category("User Photograph")]
        public string UserImage { get; set; }

        [Category("User Address")]
        [LabelWidth(190)]
        [HalfWidth]
        public string Address { get; set; }

        [LabelWidth(190)]
        [HalfWidth]
        [LookupEditor(typeof(CityDetailsRow))]
        public int CityId { get; set; }

        [LabelWidth(190)]
        [HalfWidth]
        public string PinCode { get; set; }

        [Category("Status")]
        [LabelWidth(190)]
        [HalfWidth]
        [LookupEditor(typeof(StatusRow))]
        public int StatusId { get; set; }

        [Category("Recovery")]
        [LabelWidth(190)]
        [HalfWidth]
        //[LookupEditor(typeof(PickListValueLookup))]
        [LookupEditor(typeof(PickListValueLookup), CascadeField ="PickListId",CascadeValue ="15")]
        public int QuestionId { get; set; }

        [LabelWidth(190)]
        [HalfWidth]
        [Required]
        [DisplayName("Answer")]
        public string QuestionAns { get; set; }


        [LabelWidth(190)]
        [HalfWidth]
        [DisplayName("Is LockOut")]
        public bool IsLockOut { get; set; }

        [Visible(false)]
        public int CreatedBy { get; set; }

        [Visible(false)]
        public DateTime CreatedDate { get; set; }

        [Visible(false)]
        public int UpdatedBy { get; set; }

        [Visible(false)]
        public DateTime UpdatedDate { get; set; }


        [LabelWidth(190)]
        [HalfWidth]
        [DisplayName("Is ActiveDirectory")]
        [Updatable(false)]
        public bool IsActiveDirectory { get; set; }

        //[LabelWidth(190)]
        //[DisplayName("Business Entity")]
        //[HalfWidth]

        //[LookupEditor(typeof(MachineCustomization.Entities.MachineRow),Multiple =true)]
        //public string MachineId { get; set; }

    }
}
