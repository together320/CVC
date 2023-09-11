// Decompiled with JetBrains decompiler
// Type: CVC.Texts
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using Serenity;
using Serenity.Extensibility;

namespace CVC
{
    [NestedLocalTexts]
    public static class Texts
    {
        public static class Db
        {
            public static class Administration
            {
                public static class Translation
                {
                    public static LocalText EntityPlural = (LocalText)"Translations";
                    public static LocalText Key = (LocalText)"Local Text Key";
                    public static LocalText SourceLanguage = (LocalText)"Source Language";
                    public static LocalText SourceText = (LocalText)"Effective Translation in Source Language";
                    public static LocalText TargetLanguage = (LocalText)"Target Language";
                    public static LocalText TargetText = (LocalText)"Effective Translation in Target Language";
                    public static LocalText CustomText = (LocalText)"User Translation in Target Language";
                    public static LocalText OverrideConfirmation = (LocalText)"Overwrite user translation with clicked text?";
                    public static LocalText SaveChangesButton = (LocalText)"Save Changes";
                }
            }
        }

        public static class Forms
        {
            public static class Membership
            {
                public static class ChangePassword
                {
                    public static LocalText FormTitle = (LocalText)"Change Password";
                    public static LocalText SubmitButton = (LocalText)"Change Password";
                    public static LocalText Success = (LocalText)"Your password is changed.";
                    public static LocalText BackButton = (LocalText)"Cancel";
                }

                public static class ForgotPassword
                {
                    public static LocalText FormInfo = (LocalText)"Please enter the Username you used to login.";
                    public static LocalText FormTitle = (LocalText)"Forgot My Password";
                    public static LocalText SubmitButton = (LocalText)"Reset My Password";
                    public static LocalText Success = (LocalText)"Password changed successfully";
                    public static LocalText BackToLogin = (LocalText)"I remember my password";
                    public static LocalText BackButton = (LocalText)"Back To Login";   
                }

                public static class ResetPassword
                {
                    public static LocalText EmailSubject = (LocalText)"Reset Your CVC Machine Password";
                    public static LocalText FormTitle = (LocalText)"Reset Password";
                    public static LocalText SubmitButton = (LocalText)"Reset Password";
                    public static LocalText Success = (LocalText)"Your password is changed. Please login with your new password.";
                    public static LocalText BackToLogin = (LocalText)"I remember my password. Don't reset it!";
                }

                public static class Login
                {
                    public static LocalText FormTitle = (LocalText)"Welcome to CVC Machine";
                    public static LocalText SignInButton = (LocalText)"Sign In";
                    public static LocalText ForgotPassword = (LocalText)"Forgot password?";
                    public static LocalText SignUpButton = (LocalText)"Register a new account";
                    public static LocalText RememberMe = (LocalText)"Remember Me";
                    public static LocalText OR = (LocalText)nameof(OR);
                    public static LocalText FacebookButton = (LocalText)"Sign in using Facebook";
                    public static LocalText GoogleButton = (LocalText)"Sign in using Google+";
                }

                public static class SignUp
                {
                    public static LocalText ActivateEmailSubject = (LocalText)"Activate Your CVC Account";
                    public static LocalText ActivationCompleteMessage = (LocalText)"Your account is now activated. Use the e-mail and password you used while signing up to login.";
                    public static LocalText FormInfo = (LocalText)"Enter your details to create a free account.";
                    public static LocalText FormTitle = (LocalText)"Sign up for CVC";
                    public static LocalText SubmitButton = (LocalText)"Sign Up";
                    public static LocalText Success = (LocalText)"An e-mail with instructions to active your account is sent to your e-mail address. Please check your e-mails.";
                    public static LocalText DisplayName = (LocalText)"Full Name";
                    public static LocalText Email = (LocalText)"E-mail";
                    public static LocalText ConfirmEmail = (LocalText)"Confirm Email";
                    public static LocalText Password = (LocalText)nameof(Password);
                    public static LocalText ConfirmPassword = (LocalText)"Confirm Password";
                    public static LocalText AcceptTerms = (LocalText)"I agree to the terms";
                    public static LocalText BackToLogin = (LocalText)"I already have a membership";
                }
            }
        }

        public static class Navigation
        {
            public static LocalText LogoutLink = (LocalText)"Logout";
            public static LocalText SiteTitle = (LocalText)"CVC Machine";
        }

        public static class Site
        {
            public static class AccessDenied
            {
                public static LocalText PageTitle = (LocalText)"Unauthorized Access";
                public static LocalText LackPermissions = (LocalText)"You don't have required permissions to access this page!";
                public static LocalText NotLoggedIn = (LocalText)"You need to be logged in to access this page!";
                public static LocalText ClickToChangeUser = (LocalText)"click here to login with another user...";
                public static LocalText ClickToLogin = (LocalText)"clik here to return to login page...";
            }

            public static class Dashboard
            {
                public static LocalText ContentDescription = (LocalText)"a sample with random data (from free <em><a href = \"https://almsaeedstudio.com/\" target= \"_blank\">AdminLTE theme</a></em>)";
            }

            public static class BasicProgressDialog
            {
                public static LocalText CancelTitle = (LocalText)"Operation cancelled. Waiting for in progress calls to complete...";
                public static LocalText PleaseWait = (LocalText)"Please wait...";
            }

            public static class BulkServiceAction
            {
                public static LocalText AllHadErrorsFormat = (LocalText)"All {0} record(s) that are processed had errors!";
                public static LocalText AllSuccessFormat = (LocalText)"Finished processing on {0} record(s) with success.";
                public static LocalText ConfirmationFormat = (LocalText)"Perform this operation on {0} selected record(s)?";
                public static LocalText ErrorCount = (LocalText)"{0} error(s)";
                public static LocalText NothingToProcess = (LocalText)"Please select some records to process!";
                public static LocalText SomeHadErrorsFormat = (LocalText)"Finished processing on {0} record(s) with success. {1} record(s) had errors!";
                public static LocalText SuccessCount = (LocalText)"{0} done";
            }

            public static class UserDialog
            {
                public static LocalText EditPermissionsButton = (LocalText)"Edit Permissions";
                public static LocalText EditRolesButton = (LocalText)"Edit Roles";
            }

            public static class UserRoleDialog
            {
                public static LocalText DialogTitle = (LocalText)"Edit User Roles ({0})";
                public static LocalText SaveSuccess = (LocalText)"Updated user roles.";
            }

            public static class UserPermissionDialog
            {
                public static LocalText DialogTitle = (LocalText)"Edit User Permissions ({0})";
                public static LocalText SaveSuccess = (LocalText)"Updated user permissions.";
                public static LocalText Permission = (LocalText)nameof(Permission);
                public static LocalText Grant = (LocalText)nameof(Grant);
                public static LocalText Revoke = (LocalText)nameof(Revoke);
            }

            public static class RolePermissionDialog
            {
                public static LocalText EditButton = (LocalText)"Edit Permissions";
                public static LocalText DialogTitle = (LocalText)"Edit Role Permissions ({0})";
                public static LocalText SaveSuccess = (LocalText)"Updated role permissions.";
            }

            public static class Layout
            {
                public static LocalText FooterCopyright = (LocalText)"Copyright (c) 2018.";
                public static LocalText FooterInfo = (LocalText)"CVC Technologies, Inc.";
                public static LocalText FooterRights = (LocalText)"All rights reserved.";
                public static LocalText GeneralSettings = (LocalText)"General Settings";
                public static LocalText Language = (LocalText)nameof(Language);
                public static LocalText Theme = (LocalText)nameof(Theme);
                public static LocalText ThemeBlack = (LocalText)"Black";
                public static LocalText ThemeBlackLight = (LocalText)"Black Light";
                public static LocalText ThemeBlue = (LocalText)"Blue";
                public static LocalText ThemeBlueLight = (LocalText)"Blue Light";
                public static LocalText ThemeGreen = (LocalText)"Green";
                public static LocalText ThemeGreenLight = (LocalText)"Green Light";
                public static LocalText ThemePurple = (LocalText)"Purple";
                public static LocalText ThemePurpleLight = (LocalText)"Purple Light";
                public static LocalText ThemeRed = (LocalText)"Red";
                public static LocalText ThemeRedLight = (LocalText)"Red Light";
                public static LocalText ThemeYellow = (LocalText)"Yellow";
                public static LocalText ThemeYellowLight = (LocalText)"Yellow Light";
            }

            public static class ValidationError
            {
                public static LocalText Title = (LocalText)"ERROR";
            }
        }

        public static class Validation
        {
            public static LocalText AuthenticationError = (LocalText)"Invalid username or password!";
            public static LocalText CurrentPasswordMismatch = (LocalText)"Your current password is not valid!";
            public static LocalText MinRequiredPasswordLength = (LocalText)"Entered password doesn't have enough characters (min {0})!";
            public static LocalText PreviousPasswordError = (LocalText)"Your New password can not be last Number Passwords";

            public static LocalText InvalidResetToken = (LocalText)"Your token to reset your password is invalid or has expired!";
            public static LocalText InvalidActivateToken = (LocalText)"Your token to activate your account is invalid or has expired!";
            public static LocalText CantFindUserWithEmail = (LocalText)"Can't find a user with that e-mail adress!";
            public static LocalText CantFindUserWithUsername = (LocalText)"Can't find a user with that username!";
            public static LocalText EmailInUse = (LocalText)"Another user with this e-mail exists!";
            public static LocalText EmailConfirm = (LocalText)"Emails entered doesn't match!";
            public static LocalText DeleteForeignKeyError = (LocalText)"Can't delete record. '{0}' table has records that depends on this one!";
            public static LocalText SavePrimaryKeyError = (LocalText)"Can't save record. There is another record with the same {1} value!";
        }
    }
}
