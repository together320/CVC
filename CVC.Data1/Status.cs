// Decompiled with JetBrains decompiler
// Type: CVC.Data.Status
// Assembly: CVC.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47E8AB0A-5811-4D94-AF76-6F9B6303484D
// Assembly location: D:\Anil\CVC\bin\CVC.Data.dll

using System.Collections.Generic;

namespace CVC.Data
{
  public class Status
  {
    public Status()
    {
      this.Alarms = (ICollection<Alarm>) new HashSet<Alarm>();
      this.AlarmResetIds = (ICollection<AlarmResetId>) new HashSet<AlarmResetId>();
      this.Batches = (ICollection<Batch>) new HashSet<Batch>();
      this.BatchMachineWises = (ICollection<BatchMachineWise>) new HashSet<BatchMachineWise>();
      this.Bottles = (ICollection<Bottle>) new HashSet<Bottle>();
      this.Caps = (ICollection<Cap>) new HashSet<Cap>();
      this.CityDetails = (ICollection<CityDetail>) new HashSet<CityDetail>();
      this.Currencies = (ICollection<Currency>) new HashSet<Currency>();
      this.DataTypes = (ICollection<DataType>) new HashSet<DataType>();
      this.Departments = (ICollection<Department>) new HashSet<Department>();
      this.Desiccants = (ICollection<Desiccant>) new HashSet<Desiccant>();
      this.EndOfLines = (ICollection<EndOfLine>) new HashSet<EndOfLine>();
      this.IPCParameters = (ICollection<IPCParameter>) new HashSet<IPCParameter>();
      this.Labels = (ICollection<Label>) new HashSet<Label>();
      this.LabelLosts = (ICollection<LabelLost>) new HashSet<LabelLost>();
      this.LabelReconciliations = (ICollection<LabelReconciliation>) new HashSet<LabelReconciliation>();
      this.LabelRolls = (ICollection<LabelRoll>) new HashSet<LabelRoll>();
      this.Languages = (ICollection<Language>) new HashSet<Language>();
      this.Languages1 = (ICollection<Language>) new HashSet<Language>();
      this.LineMaintenanceSchedules = (ICollection<LineMaintenanceSchedule>) new HashSet<LineMaintenanceSchedule>();
      this.Machines = (ICollection<Machine>) new HashSet<Machine>();
      this.MachineCommunications = (ICollection<MachineCommunication>) new HashSet<MachineCommunication>();
      this.MachineHelpFiles = (ICollection<MachineHelpFile>) new HashSet<MachineHelpFile>();
      this.MachineHistories = (ICollection<MachineHistory>) new HashSet<MachineHistory>();
      this.MachineLines = (ICollection<MachineLine>) new HashSet<MachineLine>();
      this.MachineLineUsers = (ICollection<MachineLineUser>) new HashSet<MachineLineUser>();
      this.MachineMaintenanceSchedules = (ICollection<MachineMaintenanceSchedule>) new HashSet<MachineMaintenanceSchedule>();
      this.MachineParameters = (ICollection<MachineParameter>) new HashSet<MachineParameter>();
      this.MachineRecipes = (ICollection<MachineRecipe>) new HashSet<MachineRecipe>();
      this.MachineRecipeParameters = (ICollection<MachineRecipeParameter>) new HashSet<MachineRecipeParameter>();
      this.MachineSpareParts = (ICollection<MachineSparePart>) new HashSet<MachineSparePart>();
      this.MachineSpecifications = (ICollection<MachineSpecification>) new HashSet<MachineSpecification>();
      this.MachineUsers = (ICollection<MachineUser>) new HashSet<MachineUser>();
      this.MachineVideos = (ICollection<MachineVideo>) new HashSet<MachineVideo>();
      this.Modules = (ICollection<Module>) new HashSet<Module>();
      this.ModuleAccesses = (ICollection<ModuleAccess>) new HashSet<ModuleAccess>();
      this.Outserts = (ICollection<Outsert>) new HashSet<Outsert>();
      this.Packs = (ICollection<Pack>) new HashSet<Pack>();
      this.PickLists = (ICollection<PickList>) new HashSet<PickList>();
      this.PickListValues = (ICollection<PickListValue>) new HashSet<PickListValue>();
      this.PickListValueRoleAccesses = (ICollection<PickListValueRoleAccess>) new HashSet<PickListValueRoleAccess>();
      this.Protocols = (ICollection<Protocol>) new HashSet<Protocol>();
      this.RecipeSettings = (ICollection<RecipeSetting>) new HashSet<RecipeSetting>();
      this.RecipeSettingsParameters = (ICollection<RecipeSettingsParameter>) new HashSet<RecipeSettingsParameter>();
      this.Roles = (ICollection<Role>) new HashSet<Role>();
      this.Screens = (ICollection<Screen>) new HashSet<Screen>();
      this.ScreenFields = (ICollection<ScreenField>) new HashSet<ScreenField>();
      this.ScreenModules = (ICollection<ScreenModule>) new HashSet<ScreenModule>();
      this.ScreenSections = (ICollection<ScreenSection>) new HashSet<ScreenSection>();
      this.Shifts = (ICollection<Shift>) new HashSet<Shift>();
      this.Suppliers = (ICollection<Supplier>) new HashSet<Supplier>();
      this.TabletDetails = (ICollection<TabletDetail>) new HashSet<TabletDetail>();
      this.Users = (ICollection<User>) new HashSet<User>();
      this.ViewFields = (ICollection<ViewField>) new HashSet<ViewField>();
      this.ViewFieldAccesses = (ICollection<ViewFieldAccess>) new HashSet<ViewFieldAccess>();
      this.Views = (ICollection<View>) new HashSet<View>();
      this.ViewsAccesses = (ICollection<ViewsAccess>) new HashSet<ViewsAccess>();
    }

    public int StatusId { get; set; }

    public string StatusName { get; set; }

    public virtual ICollection<Alarm> Alarms { get; set; }

    public virtual ICollection<AlarmResetId> AlarmResetIds { get; set; }

    public virtual ICollection<Batch> Batches { get; set; }

    public virtual ICollection<BatchMachineWise> BatchMachineWises { get; set; }

    public virtual ICollection<Bottle> Bottles { get; set; }

    public virtual ICollection<Cap> Caps { get; set; }

    public virtual ICollection<CityDetail> CityDetails { get; set; }

    public virtual Cotton Cotton { get; set; }

    public virtual ICollection<Currency> Currencies { get; set; }

    public virtual ICollection<DataType> DataTypes { get; set; }

    public virtual ICollection<Department> Departments { get; set; }

    public virtual ICollection<Desiccant> Desiccants { get; set; }

    public virtual ICollection<EndOfLine> EndOfLines { get; set; }

    public virtual ICollection<IPCParameter> IPCParameters { get; set; }

    public virtual ICollection<Label> Labels { get; set; }

    public virtual ICollection<LabelLost> LabelLosts { get; set; }

    public virtual ICollection<LabelReconciliation> LabelReconciliations { get; set; }

    public virtual ICollection<LabelRoll> LabelRolls { get; set; }

    public virtual ICollection<Language> Languages { get; set; }

    public virtual ICollection<Language> Languages1 { get; set; }

    public virtual ICollection<LineMaintenanceSchedule> LineMaintenanceSchedules { get; set; }

    public virtual ICollection<Machine> Machines { get; set; }

    public virtual ICollection<MachineCommunication> MachineCommunications { get; set; }

    public virtual ICollection<MachineHelpFile> MachineHelpFiles { get; set; }

    public virtual ICollection<MachineHistory> MachineHistories { get; set; }

    public virtual ICollection<MachineLine> MachineLines { get; set; }

    public virtual ICollection<MachineLineUser> MachineLineUsers { get; set; }

    public virtual ICollection<MachineMaintenanceSchedule> MachineMaintenanceSchedules { get; set; }

    public virtual ICollection<MachineParameter> MachineParameters { get; set; }

    public virtual ICollection<MachineRecipe> MachineRecipes { get; set; }

    public virtual ICollection<MachineRecipeParameter> MachineRecipeParameters { get; set; }

    public virtual ICollection<MachineSparePart> MachineSpareParts { get; set; }

    public virtual ICollection<MachineSpecification> MachineSpecifications { get; set; }

    public virtual ICollection<MachineUser> MachineUsers { get; set; }

    public virtual ICollection<MachineVideo> MachineVideos { get; set; }

    public virtual ICollection<Module> Modules { get; set; }

    public virtual ICollection<ModuleAccess> ModuleAccesses { get; set; }

    public virtual ICollection<Outsert> Outserts { get; set; }

    public virtual ICollection<Pack> Packs { get; set; }

    public virtual ICollection<PickList> PickLists { get; set; }

    public virtual ICollection<PickListValue> PickListValues { get; set; }

    public virtual ICollection<PickListValueRoleAccess> PickListValueRoleAccesses { get; set; }

    public virtual ICollection<Protocol> Protocols { get; set; }

    public virtual ICollection<RecipeSetting> RecipeSettings { get; set; }

    public virtual ICollection<RecipeSettingsParameter> RecipeSettingsParameters { get; set; }

    public virtual ICollection<Role> Roles { get; set; }

    public virtual ICollection<Screen> Screens { get; set; }

    public virtual ICollection<ScreenField> ScreenFields { get; set; }

    public virtual ICollection<ScreenModule> ScreenModules { get; set; }

    public virtual ICollection<ScreenSection> ScreenSections { get; set; }

    public virtual ICollection<Shift> Shifts { get; set; }

    public virtual ICollection<Supplier> Suppliers { get; set; }

    public virtual ICollection<TabletDetail> TabletDetails { get; set; }

    public virtual ICollection<User> Users { get; set; }

    public virtual ICollection<ViewField> ViewFields { get; set; }

    public virtual ICollection<ViewFieldAccess> ViewFieldAccesses { get; set; }

    public virtual ICollection<View> Views { get; set; }

    public virtual ICollection<ViewsAccess> ViewsAccesses { get; set; }
  }
}
