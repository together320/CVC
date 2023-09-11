// Decompiled with JetBrains decompiler
// Type: MVC.Views
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

namespace MVC
{
  public static class Views
  {
    public static class Administration
    {
      public static class Role
      {
        public const string RoleIndex = "~/Modules/Administration/Role/RoleIndex.cshtml";
      }

      public static class User
      {
        public const string UserIndex = "~/Modules/Administration/User/UserIndex.cshtml";
      }
    }

    public static class Configuration
    {
      public static class Language
      {
        public const string LanguageIndex = "~/Modules/Configuration/Language/LanguageIndex.cshtml";
      }

      public static class Translation
      {
        public const string TranslationIndex = "~/Modules/Administration/Translation/TranslationIndex.cshtml";
      }
    }

    public static class Admin
    {
      public const string _Layout = "~/Views/Admin/_Layout.cshtml";
    }

    public static class AdminDashboard
    {
      public static class Dashboard
      {
        public const string DashboardIndex = "~/Modules/AdminDashboard/AdminDashboardIndex.cshtml";
      }
    }

    public static class Common
    {
      public static class Dashboard
      {
        public const string DashboardIndex = "~/Modules/Common/Dashboard/DashboardIndex.cshtml";
      }

      public static class MachineDashboard
      {
        public const string MachineDashboardIndex = "~/Modules/Common/MachineDashboard/MachineDashboardIndex.cshtml";
      }

      public static class Reporting
      {
        public const string ReportPage = "~/Modules/Common/Reporting/ReportPage.cshtml";
      }
    }

    public static class Dashboard
    {
      public const string _Layout = "~/Views/Dashboard/_Layout.cshtml";
    }

    public static class Errors
    {
      public const string AccessDenied = "~/Views/Errors/AccessDenied.cshtml";
      public const string ValidationError = "~/Views/Errors/ValidationError.cshtml";
    }

    public static class Machine
    {
      public const string _Layout = "~/Views/Machine/_Layout.cshtml";
      public const string MachineIndex = "~/Modules/Machine/MachineIndex.cshtml";
      public const string SettingsIndex = "~/Modules/Machine/SettingsIndex.cshtml";
      public const string LabelRollIndex = "~/Modules/Machine/LabelRollIndex.cshtml";
      public const string ReconcilationIndex = "~/Modules/Machine/ReconcilationIndex.cshtml";
      public const string TechnicalSettingsIndex = "~/Modules/Machine/TechnicalSettingsIndex.cshtml";
      public const string EquipmentOptionsIndex = "~/Modules/Machine/EquipmentOptionsIndex.cshtml";
      public const string ManualServiceModeIndex = "~/Modules/Machine/ManualServiceModeIndex.cshtml";
    }

    public static class Membership
    {
      public static class Account
      {
        public const string AccountLogin = "~/Modules/Membership/Account/c";
        public const string AccountLogin_AdminLTE = "~/Modules/Membership/Account/AccountLogin.AdminLTE.cshtml";

        public static class ChangePassword
        {
          public const string AccountChangePassword = "~/Modules/Membership/Account/ChangePassword/AccountChangePassword.cshtml";
        }

        public static class ForgotPassword
        {
          public const string AccountForgotPassword = "~/Modules/Membership/Account/ForgotPassword/AccountForgotPassword.cshtml";
          public const string AccountForgotPassword_AdminLTE = "~/Modules/Membership/Account/ForgotPassword/AccountForgotPassword.AdminLTE.cshtml";
        }

        public static class ResetPassword
        {
          public const string AccountResetPassword = "~/Modules/Membership/Account/ResetPassword/AccountResetPassword.cshtml";
          public const string AccountResetPassword_AdminLTE = "~/Modules/Membership/Account/ResetPassword/AccountResetPassword.AdminLTE.cshtml";
          public const string AccountResetPasswordEmail = "~/Modules/Membership/Account/ResetPassword/AccountResetPasswordEmail.cshtml";
        }

        public static class SignUp
        {
          public const string AccountActivateEmail = "~/Modules/Membership/Account/SignUp/AccountActivateEmail.cshtml";
          public const string AccountSignUp = "~/Modules/Membership/Account/SignUp/AccountSignUp.cshtml";
          public const string AccountSignUp_AdminLTE = "~/Modules/Membership/Account/SignUp/AccountSignUp.AdminLTE.cshtml";
        }
      }
    }

    public static class Shared
    {
      public const string _Layout = "~/Views/Shared/_Layout.cshtml";
      public const string _LayoutHead = "~/Views/Shared/_LayoutHead.cshtml";
      public const string _LayoutNoNavigation = "~/Views/Shared/_LayoutNoNavigation.cshtml";
      public const string _LayoutSlim = "~/Views/Shared/_LayoutSlim.cshtml";
      public const string _LayoutSlimHead = "~/Views/Shared/_LayoutSlimHead.cshtml";
      public const string Error = "~/Views/Shared/Error.cshtml";
      public const string HorizontalNavigation = "~/Views/Shared/HorizontalNavigation.cshtml";
      public const string LeftNavigation = "~/Views/Shared/LeftNavigation.cshtml";
    }

    public static class NewTheme
    {
      public const string _Layout = "~/Views/NewTheme/_Layout.cshtml";
      public const string _LayoutHead = "~/Views/NewTheme/_LayoutHead.cshtml";
      public const string _LayoutNoNavigation = "~/Views/NewTheme/_LayoutNoNavigation.cshtml";
      public const string _LayoutSlim = "~/Views/NewTheme/_LayoutSlim.cshtml";
      public const string _LayoutSlimHead = "~/Views/NewTheme/_LayoutSlimHead.cshtml";
      public const string Error = "~/Views/NewTheme/Error.cshtml";
      public const string HorizontalNavigation = "~/Views/NewTheme/HorizontalNavigation.cshtml";
      public const string LeftNavigation = "~/Views/NewTheme/LeftNavigation.cshtml";
    }

    public static class PackageLineSettings
    {
      public const string _Layout = "~/Views/PackageLineSettings/_Layout.cshtml";
      public const string _LayoutHead = "~/Views/PackageLineSettings/_LayoutHead.cshtml";
      public const string _LayoutNoNavigation = "~/Views/PackageLineSettings/_LayoutNoNavigation.cshtml";
      public const string _LayoutSlim = "~/Views/PackageLineSettings/_LayoutSlim.cshtml";
      public const string _LayoutSlimHead = "~/Views/PackageLineSettings/_LayoutSlimHead.cshtml";
      public const string Error = "~/Views/PackageLineSettings/Error.cshtml";
      public const string HorizontalNavigation = "~/Views/PackageLineSettings/HorizontalNavigation.cshtml";
      public const string LeftNavigation = "~/Views/PackageLineSettings/LeftNavigation.cshtml";
    }
  }
}
