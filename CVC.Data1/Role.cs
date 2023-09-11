// Decompiled with JetBrains decompiler
// Type: CVC.Data.Role
// Assembly: CVC.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47E8AB0A-5811-4D94-AF76-6F9B6303484D
// Assembly location: D:\Anil\CVC\bin\CVC.Data.dll

using System;
using System.Collections.Generic;

namespace CVC.Data
{
  public class Role
  {
    public Role()
    {
      this.AlarmResetIds = (ICollection<AlarmResetId>) new HashSet<AlarmResetId>();
      this.ModuleAccesses = (ICollection<ModuleAccess>) new HashSet<ModuleAccess>();
      this.PickListValueRoleAccesses = (ICollection<PickListValueRoleAccess>) new HashSet<PickListValueRoleAccess>();
      this.RolePermissions = (ICollection<RolePermission>) new HashSet<RolePermission>();
      this.UserRoles = (ICollection<UserRole>) new HashSet<UserRole>();
      this.Users = (ICollection<User>) new HashSet<User>();
      this.ViewFieldAccesses = (ICollection<ViewFieldAccess>) new HashSet<ViewFieldAccess>();
      this.ViewsAccesses = (ICollection<ViewsAccess>) new HashSet<ViewsAccess>();
    }

    public int RoleId { get; set; }

    public string RoleName { get; set; }

    public int? StatusId { get; set; }

    public bool? IsHidden { get; set; }

    public int? ParentRoleId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual ICollection<AlarmResetId> AlarmResetIds { get; set; }

    public virtual ICollection<ModuleAccess> ModuleAccesses { get; set; }

    public virtual ICollection<PickListValueRoleAccess> PickListValueRoleAccesses { get; set; }

    public virtual ICollection<RolePermission> RolePermissions { get; set; }

    public virtual Status Status { get; set; }

    public virtual ICollection<UserRole> UserRoles { get; set; }

    public virtual ICollection<User> Users { get; set; }

    public virtual ICollection<ViewFieldAccess> ViewFieldAccesses { get; set; }

    public virtual ICollection<ViewsAccess> ViewsAccesses { get; set; }
  }
}
