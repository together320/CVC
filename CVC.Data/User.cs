// Decompiled with JetBrains decompiler
// Type: CVC.Data.User
// Assembly: CVC.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47E8AB0A-5811-4D94-AF76-6F9B6303484D
// Assembly location: D:\Anil\CVC\bin\CVC.Data.dll

using System;
using System.Collections.Generic;

namespace CVC.Data
{
   
    public class User
  {
    public User()
    {
      this.Alarms = (ICollection<Alarm>) new HashSet<Alarm>();
      this.Alarms1 = (ICollection<Alarm>) new HashSet<Alarm>();
      this.AlarmLogs = (ICollection<AlarmLog>) new HashSet<AlarmLog>();
      this.AlarmResetIds = (ICollection<AlarmResetId>) new HashSet<AlarmResetId>();
      this.AlarmResetIds1 = (ICollection<AlarmResetId>) new HashSet<AlarmResetId>();
      this.AuditLogs = (ICollection<AuditLog>) new HashSet<AuditLog>();
      this.Batches = (ICollection<Batch>) new HashSet<Batch>();
      this.Batches1 = (ICollection<Batch>) new HashSet<Batch>();
      this.BatchLogs = (ICollection<BatchLog>) new HashSet<BatchLog>();
      this.BatchMachineWises = (ICollection<BatchMachineWise>) new HashSet<BatchMachineWise>();
      this.BatchMachineWises1 = (ICollection<BatchMachineWise>) new HashSet<BatchMachineWise>();
      this.BatchRunDatas = (ICollection<BatchRunData>) new HashSet<BatchRunData>();
      this.Bottles = (ICollection<Bottle>) new HashSet<Bottle>();
      this.Bottles1 = (ICollection<Bottle>) new HashSet<Bottle>();
      this.Caps = (ICollection<Cap>) new HashSet<Cap>();
      this.Caps1 = (ICollection<Cap>) new HashSet<Cap>();
      this.CityDetails = (ICollection<CityDetail>) new HashSet<CityDetail>();
      this.CityDetails1 = (ICollection<CityDetail>) new HashSet<CityDetail>();
      this.Companies = (ICollection<Company>) new HashSet<Company>();
      this.Companies1 = (ICollection<Company>) new HashSet<Company>();
      this.Cotton = (ICollection<CVC.Data.Cotton>) new HashSet<CVC.Data.Cotton>();
      this.Cotton1 = (ICollection<CVC.Data.Cotton>) new HashSet<CVC.Data.Cotton>();
      this.Currencies = (ICollection<Currency>) new HashSet<Currency>();
      this.Currencies1 = (ICollection<Currency>) new HashSet<Currency>();
      this.DataTypes = (ICollection<DataType>) new HashSet<DataType>();
      this.DataTypes1 = (ICollection<DataType>) new HashSet<DataType>();
      this.Departments = (ICollection<Department>) new HashSet<Department>();
      this.Departments1 = (ICollection<Department>) new HashSet<Department>();
      this.Desiccants = (ICollection<Desiccant>) new HashSet<Desiccant>();
      this.Desiccants1 = (ICollection<Desiccant>) new HashSet<Desiccant>();
      this.EndOfLines = (ICollection<EndOfLine>) new HashSet<EndOfLine>();
      this.EndOfLines1 = (ICollection<EndOfLine>) new HashSet<EndOfLine>();
      this.EnvironmentVariables = (ICollection<EnvironmentVariable>) new HashSet<EnvironmentVariable>();
      this.EnvironmentVariables1 = (ICollection<EnvironmentVariable>) new HashSet<EnvironmentVariable>();
      this.IPCParameters = (ICollection<IPCParameter>) new HashSet<IPCParameter>();
      this.IPCParameters1 = (ICollection<IPCParameter>) new HashSet<IPCParameter>();
      this.Labels = (ICollection<Label>) new HashSet<Label>();
      this.Labels1 = (ICollection<Label>) new HashSet<Label>();
      this.LabelLosts = (ICollection<LabelLost>) new HashSet<LabelLost>();
      this.LabelLosts1 = (ICollection<LabelLost>) new HashSet<LabelLost>();
      this.LabelReconciliations = (ICollection<LabelReconciliation>) new HashSet<LabelReconciliation>();
      this.LabelReconciliations1 = (ICollection<LabelReconciliation>) new HashSet<LabelReconciliation>();
      this.LabelRolls = (ICollection<LabelRoll>) new HashSet<LabelRoll>();
      this.LabelRolls1 = (ICollection<LabelRoll>) new HashSet<LabelRoll>();
      this.Languages = (ICollection<Language>) new HashSet<Language>();
      this.Languages1 = (ICollection<Language>) new HashSet<Language>();
      this.LineMaintenanceSchedules = (ICollection<LineMaintenanceSchedule>) new HashSet<LineMaintenanceSchedule>();
      this.LineMaintenanceSchedules1 = (ICollection<LineMaintenanceSchedule>) new HashSet<LineMaintenanceSchedule>();
      this.Machines = (ICollection<Machine>) new HashSet<Machine>();
      this.Machines1 = (ICollection<Machine>) new HashSet<Machine>();
      this.MachineCommunications = (ICollection<MachineCommunication>) new HashSet<MachineCommunication>();
      this.MachineCommunications1 = (ICollection<MachineCommunication>) new HashSet<MachineCommunication>();
      this.MachineHelpFiles = (ICollection<MachineHelpFile>) new HashSet<MachineHelpFile>();
      this.MachineHelpFiles1 = (ICollection<MachineHelpFile>) new HashSet<MachineHelpFile>();
      this.MachineHistories = (ICollection<MachineHistory>) new HashSet<MachineHistory>();
      this.MachineHistories1 = (ICollection<MachineHistory>) new HashSet<MachineHistory>();
      this.MachineLines = (ICollection<MachineLine>) new HashSet<MachineLine>();
      this.MachineLines1 = (ICollection<MachineLine>) new HashSet<MachineLine>();
      this.MachineLineUsers = (ICollection<MachineLineUser>) new HashSet<MachineLineUser>();
      this.MachineLineUsers1 = (ICollection<MachineLineUser>) new HashSet<MachineLineUser>();
      this.MachineLineUsers2 = (ICollection<MachineLineUser>) new HashSet<MachineLineUser>();
      this.MachineMaintenanceSchedules = (ICollection<MachineMaintenanceSchedule>) new HashSet<MachineMaintenanceSchedule>();
      this.MachineMaintenanceSchedules1 = (ICollection<MachineMaintenanceSchedule>) new HashSet<MachineMaintenanceSchedule>();
      this.MachineParameters = (ICollection<MachineParameter>) new HashSet<MachineParameter>();
      this.MachineParameters1 = (ICollection<MachineParameter>) new HashSet<MachineParameter>();
      this.MachineRecipes = (ICollection<MachineRecipe>) new HashSet<MachineRecipe>();
      this.MachineRecipes1 = (ICollection<MachineRecipe>) new HashSet<MachineRecipe>();
      this.MachineRecipeParameters = (ICollection<MachineRecipeParameter>) new HashSet<MachineRecipeParameter>();
      this.MachineRecipeParameters1 = (ICollection<MachineRecipeParameter>) new HashSet<MachineRecipeParameter>();
      this.MachineSpareParts = (ICollection<MachineSparePart>) new HashSet<MachineSparePart>();
      this.MachineSpareParts1 = (ICollection<MachineSparePart>) new HashSet<MachineSparePart>();
      this.MachineSpecifications = (ICollection<MachineSpecification>) new HashSet<MachineSpecification>();
      this.MachineSpecifications1 = (ICollection<MachineSpecification>) new HashSet<MachineSpecification>();
      this.MachineUsers = (ICollection<MachineUser>) new HashSet<MachineUser>();
      this.MachineUsers1 = (ICollection<MachineUser>) new HashSet<MachineUser>();
      this.MachineUsers2 = (ICollection<MachineUser>) new HashSet<MachineUser>();
      this.MachineVideos = (ICollection<MachineVideo>) new HashSet<MachineVideo>();
      this.MachineVideos1 = (ICollection<MachineVideo>) new HashSet<MachineVideo>();
      this.Modules = (ICollection<Module>) new HashSet<Module>();
      this.Modules1 = (ICollection<Module>) new HashSet<Module>();
      this.ModuleAccesses = (ICollection<ModuleAccess>) new HashSet<ModuleAccess>();
      this.ModuleAccesses1 = (ICollection<ModuleAccess>) new HashSet<ModuleAccess>();
      this.Outserts = (ICollection<Outsert>) new HashSet<Outsert>();
      this.Outserts1 = (ICollection<Outsert>) new HashSet<Outsert>();
      this.Packs = (ICollection<Pack>) new HashSet<Pack>();
      this.Packs1 = (ICollection<Pack>) new HashSet<Pack>();
      this.PickLists = (ICollection<PickList>) new HashSet<PickList>();
      this.PickLists1 = (ICollection<PickList>) new HashSet<PickList>();
      this.PickListValues = (ICollection<PickListValue>) new HashSet<PickListValue>();
      this.PickListValues1 = (ICollection<PickListValue>) new HashSet<PickListValue>();
      this.PickListValueRoleAccesses = (ICollection<PickListValueRoleAccess>) new HashSet<PickListValueRoleAccess>();
      this.PickListValueRoleAccesses1 = (ICollection<PickListValueRoleAccess>) new HashSet<PickListValueRoleAccess>();
      this.Protocols = (ICollection<Protocol>) new HashSet<Protocol>();
      this.Protocols1 = (ICollection<Protocol>) new HashSet<Protocol>();
      this.RecipeSettings = (ICollection<RecipeSetting>) new HashSet<RecipeSetting>();
      this.RecipeSettings1 = (ICollection<RecipeSetting>) new HashSet<RecipeSetting>();
      this.RecipeSettingsParameters = (ICollection<RecipeSettingsParameter>) new HashSet<RecipeSettingsParameter>();
      this.RecipeSettingsParameters1 = (ICollection<RecipeSettingsParameter>) new HashSet<RecipeSettingsParameter>();
      this.UserLoginDetails = (ICollection<UserLoginDetail>) new HashSet<UserLoginDetail>();
      this.BatchRecipeModifies = (ICollection<BatchRecipeModify>) new HashSet<BatchRecipeModify>();
      this.ViewFields = (ICollection<ViewField>) new HashSet<ViewField>();
      this.ViewFields1 = (ICollection<ViewField>) new HashSet<ViewField>();
      this.ViewFieldAccesses = (ICollection<ViewFieldAccess>) new HashSet<ViewFieldAccess>();
      this.ViewFieldAccesses1 = (ICollection<ViewFieldAccess>) new HashSet<ViewFieldAccess>();
      this.Views = (ICollection<View>) new HashSet<View>();
      this.Views1 = (ICollection<View>) new HashSet<View>();
      this.ViewsAccesses = (ICollection<ViewsAccess>) new HashSet<ViewsAccess>();
      this.ViewsAccesses1 = (ICollection<ViewsAccess>) new HashSet<ViewsAccess>();
    }

    public int UserId { get; set; }

    public string EmployeeId { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public int? DepartmentId { get; set; }

    public string Designation { get; set; }

    public int? MobileCode { get; set; }

    public int? MobileNumber { get; set; }

    public string Email { get; set; }

    public string Username { get; set; }

    public string PasswordHash { get; set; }

    public string PasswordSalt { get; set; }

    public string UserImage { get; set; }

    public string Address { get; set; }

    public int? CityId { get; set; }

    public string PinCode { get; set; }

    public int? RoleId { get; set; }

    public DateTime? PasswordExpiryDate { get; set; }

    public bool? IsForgotPassword { get; set; }

    public bool? IsPasswordChangeOnLogin { get; set; }

    public bool? IsUserHidden { get; set; }

    public DateTime? BirthDate { get; set; }

    public int? StatusId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual ICollection<Alarm> Alarms { get; set; }

    public virtual ICollection<Alarm> Alarms1 { get; set; }

    public virtual ICollection<AlarmLog> AlarmLogs { get; set; }

    public virtual ICollection<AlarmResetId> AlarmResetIds { get; set; }

    public virtual ICollection<AlarmResetId> AlarmResetIds1 { get; set; }

    public virtual ICollection<AuditLog> AuditLogs { get; set; }

    public virtual ICollection<Batch> Batches { get; set; }

    public virtual ICollection<Batch> Batches1 { get; set; }

    public virtual ICollection<BatchLog> BatchLogs { get; set; }

    public virtual ICollection<BatchMachineWise> BatchMachineWises { get; set; }

    public virtual ICollection<BatchMachineWise> BatchMachineWises1 { get; set; }

    public virtual ICollection<BatchRunData> BatchRunDatas { get; set; }

    public virtual ICollection<Bottle> Bottles { get; set; }

    public virtual ICollection<Bottle> Bottles1 { get; set; }

    public virtual ICollection<Cap> Caps { get; set; }

    public virtual ICollection<Cap> Caps1 { get; set; }

    public virtual ICollection<CityDetail> CityDetails { get; set; }

    public virtual ICollection<CityDetail> CityDetails1 { get; set; }

    public virtual CityDetail CityDetail { get; set; }

    public virtual ICollection<Company> Companies { get; set; }

    public virtual ICollection<Company> Companies1 { get; set; }

    public virtual ICollection<CVC.Data.Cotton> Cotton { get; set; }

    public virtual ICollection<CVC.Data.Cotton> Cotton1 { get; set; }

    public virtual ICollection<Currency> Currencies { get; set; }

    public virtual ICollection<Currency> Currencies1 { get; set; }

    public virtual ICollection<DataType> DataTypes { get; set; }

    public virtual ICollection<DataType> DataTypes1 { get; set; }

    public virtual ICollection<Department> Departments { get; set; }

    public virtual ICollection<Department> Departments1 { get; set; }

    public virtual Department Department { get; set; }

    public virtual ICollection<Desiccant> Desiccants { get; set; }

    public virtual ICollection<Desiccant> Desiccants1 { get; set; }

    public virtual ICollection<EndOfLine> EndOfLines { get; set; }

    public virtual ICollection<EndOfLine> EndOfLines1 { get; set; }

    public virtual ICollection<EnvironmentVariable> EnvironmentVariables { get; set; }

    public virtual ICollection<EnvironmentVariable> EnvironmentVariables1 { get; set; }

    public virtual ICollection<IPCParameter> IPCParameters { get; set; }

    public virtual ICollection<IPCParameter> IPCParameters1 { get; set; }

    public virtual ICollection<Label> Labels { get; set; }

    public virtual ICollection<Label> Labels1 { get; set; }

    public virtual ICollection<LabelLost> LabelLosts { get; set; }

    public virtual ICollection<LabelLost> LabelLosts1 { get; set; }

    public virtual ICollection<LabelReconciliation> LabelReconciliations { get; set; }

    public virtual ICollection<LabelReconciliation> LabelReconciliations1 { get; set; }

    public virtual ICollection<LabelRoll> LabelRolls { get; set; }

    public virtual ICollection<LabelRoll> LabelRolls1 { get; set; }

    public virtual ICollection<Language> Languages { get; set; }

    public virtual ICollection<Language> Languages1 { get; set; }

    public virtual ICollection<LineMaintenanceSchedule> LineMaintenanceSchedules { get; set; }

    public virtual ICollection<LineMaintenanceSchedule> LineMaintenanceSchedules1 { get; set; }

    public virtual ICollection<Machine> Machines { get; set; }

    public virtual ICollection<Machine> Machines1 { get; set; }

    public virtual ICollection<MachineCommunication> MachineCommunications { get; set; }

    public virtual ICollection<MachineCommunication> MachineCommunications1 { get; set; }

    public virtual ICollection<MachineHelpFile> MachineHelpFiles { get; set; }

    public virtual ICollection<MachineHelpFile> MachineHelpFiles1 { get; set; }

    public virtual ICollection<MachineHistory> MachineHistories { get; set; }

    public virtual ICollection<MachineHistory> MachineHistories1 { get; set; }

    public virtual ICollection<MachineLine> MachineLines { get; set; }

    public virtual ICollection<MachineLine> MachineLines1 { get; set; }

    public virtual ICollection<MachineLineUser> MachineLineUsers { get; set; }

    public virtual ICollection<MachineLineUser> MachineLineUsers1 { get; set; }

    public virtual ICollection<MachineLineUser> MachineLineUsers2 { get; set; }

    public virtual ICollection<MachineMaintenanceSchedule> MachineMaintenanceSchedules { get; set; }

    public virtual ICollection<MachineMaintenanceSchedule> MachineMaintenanceSchedules1 { get; set; }

    public virtual ICollection<MachineParameter> MachineParameters { get; set; }

    public virtual ICollection<MachineParameter> MachineParameters1 { get; set; }

    public virtual ICollection<MachineRecipe> MachineRecipes { get; set; }

    public virtual ICollection<MachineRecipe> MachineRecipes1 { get; set; }

    public virtual ICollection<MachineRecipeParameter> MachineRecipeParameters { get; set; }

    public virtual ICollection<MachineRecipeParameter> MachineRecipeParameters1 { get; set; }

    public virtual ICollection<MachineSparePart> MachineSpareParts { get; set; }

    public virtual ICollection<MachineSparePart> MachineSpareParts1 { get; set; }

    public virtual ICollection<MachineSpecification> MachineSpecifications { get; set; }

    public virtual ICollection<MachineSpecification> MachineSpecifications1 { get; set; }

    public virtual ICollection<MachineUser> MachineUsers { get; set; }

    public virtual ICollection<MachineUser> MachineUsers1 { get; set; }

    public virtual ICollection<MachineUser> MachineUsers2 { get; set; }

    public virtual ICollection<MachineVideo> MachineVideos { get; set; }

    public virtual ICollection<MachineVideo> MachineVideos1 { get; set; }

    public virtual ICollection<Module> Modules { get; set; }

    public virtual ICollection<Module> Modules1 { get; set; }

    public virtual ICollection<ModuleAccess> ModuleAccesses { get; set; }

    public virtual ICollection<ModuleAccess> ModuleAccesses1 { get; set; }

    public virtual ICollection<Outsert> Outserts { get; set; }

    public virtual ICollection<Outsert> Outserts1 { get; set; }

    public virtual ICollection<Pack> Packs { get; set; }

    public virtual ICollection<Pack> Packs1 { get; set; }

    public virtual ICollection<PickList> PickLists { get; set; }

    public virtual ICollection<PickList> PickLists1 { get; set; }

    public virtual ICollection<PickListValue> PickListValues { get; set; }

    public virtual ICollection<PickListValue> PickListValues1 { get; set; }

    public virtual ICollection<PickListValueRoleAccess> PickListValueRoleAccesses { get; set; }

    public virtual ICollection<PickListValueRoleAccess> PickListValueRoleAccesses1 { get; set; }

    public virtual ICollection<Protocol> Protocols { get; set; }

    public virtual ICollection<Protocol> Protocols1 { get; set; }

    public virtual ICollection<RecipeSetting> RecipeSettings { get; set; }

    public virtual ICollection<RecipeSetting> RecipeSettings1 { get; set; }

    public virtual ICollection<RecipeSettingsParameter> RecipeSettingsParameters { get; set; }

    public virtual ICollection<RecipeSettingsParameter> RecipeSettingsParameters1 { get; set; }

    public virtual Role Role { get; set; }

    public virtual Status Status { get; set; }

    public virtual ICollection<UserLoginDetail> UserLoginDetails { get; set; }

    public virtual ICollection<BatchRecipeModify> BatchRecipeModifies { get; set; }

    public virtual ICollection<ViewField> ViewFields { get; set; }

    public virtual ICollection<ViewField> ViewFields1 { get; set; }

    public virtual ICollection<ViewFieldAccess> ViewFieldAccesses { get; set; }

    public virtual ICollection<ViewFieldAccess> ViewFieldAccesses1 { get; set; }

    public virtual ICollection<View> Views { get; set; }

    public virtual ICollection<View> Views1 { get; set; }

    public virtual ICollection<ViewsAccess> ViewsAccesses { get; set; }

    public virtual ICollection<ViewsAccess> ViewsAccesses1 { get; set; }
  }
}
