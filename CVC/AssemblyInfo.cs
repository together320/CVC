﻿using CVC.Administration.Pages;
using CVC.Configuration.Pages;
using CVC.ExternalApplicationInterface.Pages;
using CVC.MachineCustomization.Pages;
using CVC.ModuleManagement.Pages;
using CVC.PackSettings.Pages;
using CVC.Report.Pages;
using Serenity.Navigation;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[assembly: Extension]
[assembly: NavigationLink(1000, "Dashboard", "~/AdminDashboard", "", "fa-tachometer")]
[assembly: NavigationMenu(9000, "Administration", "fa-desktop")]
[assembly: NavigationLink(9000, "Administration/Roles", typeof (RoleController), "fa-lock", "Index")]
[assembly: NavigationLink(9000, "Administration/User Management", typeof (UserController), "fa-users", "Index")]
[assembly: NavigationLink(2147483647, "Administration/Role Access", typeof (ViewFieldAccessController), null, "Index")]
[assembly: NavigationLink(1001, "Package Line", "~/LabelingMachine", "", "fa-industry")]
[assembly: AssemblyTitle("CVC.Web")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("CVC.Web")]
[assembly: AssemblyCopyright("Copyright ©  2014")]
[assembly: AssemblyTrademark("")]
[assembly: ComVisible(false)]
[assembly: Guid("84da6417-8089-4e8e-9306-400b1c96415f")]
[assembly: AssemblyFileVersion("1.0.0.0")]
[assembly: NavigationMenu(2147483647, "Pack Settings", "fa-folder")]
[assembly: NavigationLink(2147483647, "Pack Settings/Bottle", typeof (BottleController), null, "Index")]
[assembly: NavigationLink(2147483647, "Pack Settings/Cap", typeof (CapController), null, "Index")]
[assembly: NavigationLink(2147483647, "Pack Settings/Cotton", typeof (CottonController), null, "Index")]
[assembly: NavigationLink(2147483647, "Pack Settings/Desiccant", typeof (DesiccantController), null, "Index")]
[assembly: NavigationLink(2147483647, "Pack Settings/End Of Line", typeof (EndOfLineController), null, "Index")]
[assembly: NavigationLink(2147483647, "Pack Settings/Label", typeof (LabelController), null, "Index")]
[assembly: NavigationLink(2147483647, "Pack Settings/Outsert", typeof (OutsertController), null, "Index")]
[assembly: NavigationLink(2147483647, "Pack Settings/Pack", typeof (PackController), null, "Index")]
[assembly: NavigationLink(2147483647, "Pack Settings/Tablet Details", typeof (TabletDetailsController), null, "Index")]
[assembly: NavigationMenu(2147483647, "Configuration", "fa-wrench")]
[assembly: NavigationLink(2147483647, "Configuration/Company", typeof (CompanyController), null, "Index")]
[assembly: NavigationLink(2147483647, "Configuration/City Details", typeof (CityDetailsController), null, "Index")]
[assembly: NavigationLink(2147483647, "Configuration/Currency", typeof (CurrencyController), null, "Index")]
[assembly: NavigationLink(2147483647, "Configuration/Department", typeof (DepartmentController), null, "Index")]
[assembly: NavigationLink(2147483647, "Configuration/Environment Variables", typeof (EnvironmentVariablesController), null, "Index")]
[assembly: NavigationLink(2147483647, "Configuration/Pick List", typeof (PickListValueController), null, "Index")]
[assembly: NavigationLink(2147483647, "Configuration/Shift", typeof (ShiftController), null, "Index")]
[assembly: NavigationLink(2147483647, "Configuration/Supplier", typeof (SupplierController), null, "Index")]
[assembly: NavigationLink(9000, "Configuration/Languages", typeof (LanguageController), "fa-comments", "Index")]
[assembly: NavigationLink(9000, "Configuration/Translations", typeof (TranslationController), "fa-comment-o", "Index")]
[assembly: NavigationMenu(2147483647, "Machine Customization", "fa-cogs")]
[assembly: NavigationLink(2147483647, "Machine Customization/Package Line", typeof (MachineLineController), null, "Index")]
[assembly: NavigationLink(2147483647, "Machine Customization/Machine", typeof (MachineController), null, "Index")]
[assembly: NavigationLink(2147483647, "Machine Customization/Machine Parameter", typeof (MachineParameterController), null, "Index")]
[assembly: NavigationLink(2147483647, "Machine Customization/Alarm", typeof (AlarmController), null, "Index")]
[assembly: NavigationLink(2147483647, "Machine Customization/Machine History", typeof (MachineHistoryController), null, "Index")]
[assembly: NavigationLink(2147483647, "Machine Customization/Machine Recipe", typeof (MachineRecipeController), null, "Index")]
[assembly: NavigationLink(2147483647, "Machine Customization/Machine Spare Part", typeof (MachineSparePartController), null, "Index")]
[assembly: NavigationLink(2147483647, "Machine Customization/Machine Specification", typeof (MachineSpecificationController), null, "Index")]
[assembly: NavigationLink(2147483647, "Machine Customization/Machine Video", typeof (MachineVideoController), null, "Index")]
[assembly: NavigationLink(2147483647, "Machine Customization/Recipe Settings", typeof (RecipeSettingsController), null, "Index")]
[assembly: NavigationMenu(2147483647, "EAI", "fa-external-link")]
[assembly: NavigationLink(2147483647, "EAI/Machine Communication", typeof (MachineCommunicationController), null, "Index")]
[assembly: NavigationLink(2147483647, "EAI/Protocol", typeof (ProtocolController), null, "Index")]
[assembly: NavigationLink(2147483647, "EAI/Ipc Parameter", typeof (IpcParameterController), null, "Index")]
[assembly: NavigationMenu(2147483647, "Module Management", "fa-th-large")]
[assembly: NavigationLink(2147483647, "Module Management/Module", typeof (ModuleController), null, "Index")]
[assembly: NavigationLink(2147483647, "Module Management/View Field", typeof (ViewFieldController), null, "Index")]
[assembly: NavigationLink(2147483647, "Module Management/Views", typeof (ViewsController), null, "Index")]
[assembly: NavigationMenu(2147483647, "Report", "fa-files-o")]
[assembly: NavigationLink(2147483647, "Report/Alarm Log", typeof (AlarmLogController), null, "Index")]
[assembly: NavigationLink(2147483647, "Report/Audit Log", typeof (AuditLogController), null, "Index")]
[assembly: NavigationLink(2147483647, "Report/Batch Log", typeof (BatchLogController), null, "Index")]
[assembly: NavigationLink(2147483647, "Report/User Login Details", typeof (UserLoginDetailsController), null, "Index")]
[assembly: AssemblyVersion("1.0.0.0")]