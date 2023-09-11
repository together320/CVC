using CVC.Administration.Pages;
using CVC.Batch.Pages;
using CVC.Configuration.Pages;
using CVC.Controllers;
using CVC.ExternalApplicationInterface.Pages;
using CVC.MachineCustomization.Pages;
using CVC.ModuleManagement.Pages;
using CVC.PackSettings.Pages;
using CVC.Report.Pages;
using Serenity.Navigation;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("CVC")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("CVC")]
[assembly: AssemblyCopyright("Copyright ©  2018")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible
// to COM components.  If you need to access a type in this assembly from
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("a6165728-6f0b-4a24-8b55-d5a79451f051")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Revision and Build Numbers
// by using the '*' as shown below:
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]

//[assembly: NavigationLink(1000, "Dashboard", "~/AdminDashboard", "", "fa-tachometer")]
[assembly: NavigationMenu(9000, "Administration", icon: "fa-desktop")]
[assembly: NavigationLink(9000, "Administration/Roles", typeof (RoleController), "fa-lock", "Index")]
[assembly: NavigationLink(9000, "Administration/User Management", typeof (UserController), "fa-users", "Index")]
[assembly: NavigationLink(2147483647, "Administration/Module Access", typeof(RoleViewAccessController), "fa-lock", "Index")]
[assembly: NavigationLink(2147483647, "Administration/Language", typeof(LanguageController), "fa-lock", "Index")]

//[assembly: NavigationLink(2147483647, "Administration/View Access", typeof(ViewsAccessController), null, "Index")]
//[assembly: NavigationLink(2147483647, "Administration/View Field Access", typeof (ViewFieldAccessController), null, "Index")]
[assembly: NavigationLink(1001, "Dashboard", "~/SettingsMachine", "", "fa-gift")]
[assembly: NavigationMenu(2147483647, "Pack Settings", "fa-folder")]
[assembly: NavigationLink(2147483647, "Pack Settings/Bottle", typeof (BottleController), null, "Index")]
[assembly: NavigationLink(2147483647, "Pack Settings/Cap", typeof (CapController), null, "Index")]
[assembly: NavigationLink(2147483647, "Pack Settings/Cotton", typeof (CottonController), null, "Index")]
[assembly: NavigationLink(2147483647, "Pack Settings/Desiccant", typeof (DesiccantController), null, "Index")]
[assembly: NavigationLink(2147483647, "Pack Settings/End Of Line", typeof (EndOfLineController), null, "Index")]
[assembly: NavigationLink(2147483647, "Pack Settings/Label", typeof (LabelController), null, "Index")]
[assembly: NavigationLink(2147483647, "Pack Settings/Outsert", typeof (OutsertController), null, "Index")]
[assembly: NavigationLink(2147483647, "Pack Settings/Pack", typeof (PackController), null, "Index")]
[assembly: NavigationLink(2147483647, "Pack Settings/Product Details", typeof (TabletDetailsController), null, "Index")]
[assembly: NavigationMenu(2147483647, "Configuration", "fa-wrench")]
[assembly: NavigationLink(2147483647, "Configuration/Company", typeof (CompanyController), null, "Index")]
[assembly: NavigationLink(2147483647, "Configuration/City Details", typeof (CityDetailsController), null, "Index")]
//[assembly: NavigationLink(2147483647, "Configuration/Currency", typeof (CurrencyController), null, "Index")]
[assembly: NavigationLink(2147483647, "Configuration/Department", typeof (DepartmentController), null, "Index")]
[assembly: NavigationLink(2147483647, "Configuration/Environment Variables", typeof (EnvironmentVariablesController), null, "Index")]
[assembly: NavigationLink(2147483647, "Configuration/Archival", typeof(ArchivalRestoreController), null, "Index")]
[assembly: NavigationLink(2147483647, "Configuration/Pick List", typeof (PickListValueController), null, "Index")]
[assembly: NavigationLink(2147483647, "Configuration/Shift", typeof (ShiftController), null, "Index")]
[assembly: NavigationLink(2147483647, "Configuration/Supplier", typeof (SupplierController), null, "Index")]
//[assembly: NavigationLink(2147483647, "Configuration/Entity Recipe", typeof(MachineRecipeController), null, "Index")]
[assembly: NavigationLink(2147483647, "Configuration/Entity Recipe Parameter", typeof(MachineRecipeParameterController), null, "Index")]
[assembly: NavigationLink(2147483647, "Configuration/Translation", typeof(TranslationController), null, "Index")]


//[assembly: NavigationLink(9000, "Configuration/Languages", typeof (LanguageController), "fa-comments", "Index")]
//[assembly: NavigationLink(9000, "Configuration/Translations", typeof (TranslationController), "fa-comment-o", "Index")]
[assembly: NavigationMenu(2147483647, "Entity Customization", "fa-cogs")]
[assembly: NavigationLink(2147483647, "Entity Customization/Package Line", typeof (MachineLineController), null, "Index")]
[assembly: NavigationLink(2147483647, "Entity Customization/Entity", typeof (MachineController), null, "Index")]
[assembly: NavigationLink(2147483647, "Entity Customization/Entity Field", typeof (MachineParameterController), null, "Index")]
[assembly: NavigationLink(2147483647, "Entity Customization/Alarm", typeof (AlarmController), null, "Index")]
//[assembly: NavigationLink(2147483647, "Entity Customization/Entity History", typeof (MachineHistoryController), null, "Index")]
//[assembly: NavigationLink(2147483647, "Entity Customization/Entity Recipe", typeof (MachineRecipeController), null, "Index")]
//[assembly: NavigationLink(2147483647, "Entity Customization/Entity Recipe Parameter", typeof(MachineRecipeParameterController), null, "Index")]
//[assembly: NavigationLink(2147483647, "Entity Customization/Entity Spare Part", typeof (MachineSparePartController), null, "Index")]
//[assembly: NavigationLink(2147483647, "Entity Customization/Entity Specification", typeof (MachineSpecificationController), null, "Index")]
//[assembly: NavigationLink(2147483647, "Entity Customization/Entity Video", typeof (MachineVideoController), null, "Index")]
//[assembly: NavigationLink(2147483647, "Entity Customization/Recipe Settings", typeof (RecipeSettingsController), null, "Index")]
[assembly: NavigationLink(2147483647, "Entity Customization/Module View", typeof(NModuleManagementController), null, "Index")]
[assembly: NavigationLink(2147483647, "Entity Customization/Terminal Type", typeof(TerminalTypeController), null, "Index")]
[assembly: NavigationLink(2147483647, "Entity Customization/Terminal Master", typeof(TerminalMasterController), null, "Index")]
[assembly: NavigationLink(2147483647, "Entity Customization/Terminal View", typeof(TerminalTabController), null, "Index")]
[assembly: NavigationLink(2147483647, "Entity Customization/Message", typeof(MessageMasterController), null, "Index")]
// added by Denis for RS 6.1 dated 8/2/2021
[assembly: NavigationLink(2147483647, "Entity Customization/Display Object", typeof(DisplayObjectController), null, "Index")]
// added by Denis for RS 7 dated 10/4/2021
//[assembly: NavigationLink(2147483647, "Entity Customization/Display Object Field", typeof(DisplayObjectFieldController), null, "Index")]

[assembly: NavigationMenu(2147483647, "EAI", "fa-external-link")]
[assembly: NavigationLink(2147483647, "EAI/Machine Communication", typeof (MachineCommunicationController), null, "Index")]
[assembly: NavigationLink(2147483647, "EAI/Protocol", typeof (ProtocolController), null, "Index")]
[assembly: NavigationLink(2147483647, "EAI/Ipc Parameter", typeof (IpcParameterController), null, "Index")]
[assembly: NavigationLink(2147483647, "EAI/LDAP", typeof(LDAPController), null, "Index")]
//[assembly: NavigationMenu(2147483647, "Module Management", "fa-th-large")]
//[assembly: NavigationLink(2147483647, "Module Management/Module View", typeof(NModuleManagementController), null, "Index")]
//[assembly: NavigationLink(2147483647, "Module Management/Module Access", typeof(RoleViewAccessController), "fa-lock", "Index")]

//[assembly: NavigationMenu(2147483647, "Module Management", "fa-th-large")]
//[assembly: NavigationLink(2147483647, "Module Management/Module", typeof (ModuleController), null, "Index")]
//[assembly: NavigationLink(2147483647, "Module Management/View Field", typeof (ViewFieldController), null, "Index")]
//[assembly: NavigationLink(2147483647, "Module Management/Views", typeof (ViewsController), null, "Index")]
[assembly: NavigationMenu(2147483647, "Report", "fa-files-o")]

[assembly: NavigationLink(2147483647, "Report/Audit Log Live", typeof (AuditLogController), null, "Index")]
[assembly: NavigationLink(2147483647, "Report/Audit Log Archive", typeof(AuditLogArchiveController), null, "Index")]
[assembly: NavigationLink(2147483647, "Report/Alarm Log", typeof(AlarmLogController), null, "Index")]
[assembly: NavigationLink(2147483647, "Report/Alarm Log Archive", typeof(AlarmLogArchiveController), null, "Index")]

//[assembly: NavigationLink(2147483647, "Report/Batch Log", typeof(CVC.Report.Pages.BatchLogController), null, "Index")]
[assembly: NavigationLink(2147483647, "Report/Batch Log", typeof(BatchController), null, "Index")]

[assembly: NavigationLink(2147483647, "Report/Batch Log Archive", typeof(BatchLogArchiveController), null, "Index")]

[assembly: NavigationLink(2147483647, "Report/Entity Recipe Log", typeof(MachineRecipeController), null, "Index")]
[assembly: NavigationLink(2147483647, "Report/User Log", typeof(UserLogController), null, "Index")]
[assembly: NavigationLink(2147483647, "Report/User Log Archive", typeof (UserLogArchiveController), null, "Index")]
[assembly: NavigationLink(2147483647, "Report/Exception Log", typeof(ExceptionLogController), null, "Index")]

//[assembly: NavigationLink(2147483647, "Report/User Login Details", typeof (UserLoginDetailsController), null, "Index")]
//[assembly: NavigationLink(9000, "NAdmin/RoleAccess", typeof(RoleViewAccessController), "fa-lock", "Index")]

[assembly: NavigationMenu(2147483647, "Licensing", "fa-external-link")]
[assembly: NavigationLink(2147483647, "Licensing/Customers", typeof(LicenseCustomerController), null, "Index")]
[assembly: NavigationLink(2147483647, "Licensing/Template", typeof(LicenseTemplateController), null, "Index")]
[assembly: NavigationLink(2147483647, "Licensing/License", typeof(LicenseController), null, "Index")]
[assembly: NavigationLink(2147483647, "Licensing/License Upload", typeof(LicenseUploadController), null, "Index")]
[assembly: NavigationLink(2147483647, "Licensing/License List", typeof(LicenseListController), null, "Index")]


