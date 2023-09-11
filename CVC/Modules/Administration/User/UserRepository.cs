// Decompiled with JetBrains decompiler
// Type: CVC.Administration.Repositories.UserRepository
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Administration.Entities;
using CVC.Data.EDMX;
using Serenity;
using Serenity.Data;
using Serenity.Services;
using Serenity.Web.Providers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data;
using System.Linq;

namespace CVC.Administration.Repositories
{
    public class UserRepository
    {
        public static readonly bool isPublicDemo = ConfigurationManager.AppSettings["IsPublicDemo"] == "1";

        private static UserRow.RowFields fld
        {
            get
            {
                return UserRow.Fields;
            }
        }

        public static void CheckPublicDemo(int? userID)
        {
            int? nullable = userID;
            int num = 1;
            if ((nullable.GetValueOrDefault() == num ? (nullable.HasValue ? 1 : 0) : 0) != 0 && UserRepository.isPublicDemo)
                throw new ValidationException("Sorry, but no changes are allowed in public demo on ADMIN user!");
        }

        public SaveResponse Create(IUnitOfWork uow, SaveRequest<UserRow> request)
        {
            //CVCEntities cvcEntities = new CVCEntities();
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                var environment = cvcEntities.EnvironmentVariables.FirstOrDefault();
                if (environment != null)
                {
                    request.Entity.IsPasswordChangeOnLogin = environment.IsPasswordChangeRequired;
                    if (environment.PasswordExpiryInDays != null)
                        request.Entity.PasswordExpiryDate = DateTime.Now.Date.AddDays(environment.PasswordExpiryInDays.Value);
                }
            }
            return new UserRepository.MySaveHandler().Process(uow, request, SaveRequestType.Create);
        }

        public SaveResponse Update(IUnitOfWork uow, SaveRequest<UserRow> request)
        {
            return new UserRepository.MySaveHandler().Process(uow, request, SaveRequestType.Update);
        }

        public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
        {
            return new UserRepository.MyDeleteHandler().Process(uow, request);
        }

        public UndeleteResponse Undelete(IUnitOfWork uow, UndeleteRequest request)
        {
            return new UserRepository.MyUndeleteHandler().Process(uow, request);
        }

        public RetrieveResponse<UserRow> Retrieve(IDbConnection connection, RetrieveRequest request)
        {
            return new UserRepository.MyRetrieveHandler().Process(connection, request);
        }

        public ListResponse<UserRow> List(IDbConnection connection, ListRequest request)
        {
            var RoleId=new int?();
            //CVCEntities cvcEntities = new CVCEntities();
            var GetUserId = Serenity.Authorization.UserId;
            var UserId = Convert.ToInt32(GetUserId);
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                RoleId = cvcEntities.Users.FirstOrDefault(u => u.UserId == UserId).RoleId;
            }

            //Serenity.Services.ListResponse<CVC.Administration.Entities.UserRow> lstUserRow = new ListResponse<UserRow>();
           // lstUserRow.Entities = RoleId == 1 ? new UserRepository.MyListHandler().Process(connection, request).Entities.ToList() : new UserRepository.MyListHandler().Process(connection, request).Entities.Where(a => a.RoleId != 1).ToList();
            Serenity.Services.ListResponse<CVC.Administration.Entities.UserRow> lstUserRow = new ListResponse<UserRow>
            {
                Entities = RoleId == 1 ? new UserRepository.MyListHandler().Process(connection, request).Entities.ToList() : new UserRepository.MyListHandler().Process(connection, request).Entities.Where(a => a.RoleId != 1).ToList()
            };
            return lstUserRow;
            // return new UserRepository.MyListHandler().Process(connection, request);
        }

        public static string ValidateFirstName(IDbConnection connection, string firstName, int? existingUserId)
        {
            firstName = firstName.TrimToNull();
            if (firstName == null)
                throw DataValidation.RequiredError(UserRepository.fld.FirstName.Name, UserRepository.fld.FirstName.Title);
            return firstName;
        }

        public static string ValidateLastName(IDbConnection connection, string lastName, int? existingUserId)
        {
            lastName = lastName.TrimToNull();
            if (lastName == null)
                throw DataValidation.RequiredError(UserRepository.fld.LastName.Name, UserRepository.fld.LastName.Title);
            return lastName;
        }

        public static int LettersCount(string s)
        {
            int count = 0;
            foreach (char c in s)
            {
                if (Char.IsLetter(c))
                    count++;
            }
            return count;
        }
        public static int DigitCount(string s)
        {
            int count = 0;
            foreach (char c in s)
            {
                if (Char.IsDigit(c))
                    count++;
            }
            return count;
        }

        public static int SpecialCharacterCount(string s)
        {
            int count = 0;
            foreach (char c in s)
            {
                if (!Char.IsLetterOrDigit(c))
                    count++;
            }
            return count;
        }

        public static bool CheckCapitalCharacter(string s, int? caplettercount)
        {
            bool ret = false;
            foreach (char c in s)
            {
                if (caplettercount != 0)
                {
                    if (Char.IsUpper(c))
                    {
                        return ret = true;
                    }
                }
            }
            return ret;
        }

        public static string ValidatePassword(string username, string password, bool isNewUser)
        {
            password = password.TrimToNull();

            if (password != null)
            {
                // CVCEntities cvcEntities = new CVCEntities();
                using (CVCEntities cvcEntities = new CVCEntities())
                {
                    var environment = cvcEntities.EnvironmentVariables.FirstOrDefault();
                    if (password.Length < environment.PasswordMinLength)
                    {
                        throw new Serenity.Services.ValidationError("PasswordLength", "Password", string.Format((string)CVC.Texts.Validation.MinRequiredPasswordLength, (object)environment.PasswordMinLength));
                    }
                    if (password.Length > environment.PasswordMaxLength)
                    {
                        throw new Serenity.Services.ValidationError("PasswordLength", "Password", string.Format("Password Length cannot be greater than {0}", (object)environment.PasswordMaxLength));
                    }
                    if (LettersCount(password) < environment.MinAlphaChars)
                    {
                        throw new Serenity.Services.ValidationError("PasswordLength", "Password", string.Format("Letters count in Password cannot be less than {0}", (object)environment.MinAlphaChars));
                    }
                    if (DigitCount(password) < environment.MinNumericChars)
                    {
                        throw new Serenity.Services.ValidationError("PasswordLength", "Password", string.Format("Digit count in Password cannot be less than {0}", (object)environment.MinNumericChars));
                    }
                    if (SpecialCharacterCount(password) < environment.MinSpecialChars)
                    {
                        throw new Serenity.Services.ValidationError("PasswordLength", "Password", string.Format("Special Character count in Password cannot be less than {0}", (object)environment.MinSpecialChars));
                    }

                    if (!CheckCapitalCharacter(password, environment.MinCapitalLetter))
                    {
                        throw new Serenity.Services.ValidationError("PasswordLength", "Password", string.Format("Capital Letter Character count in Password cannot be less than {0}", (object)environment.MinCapitalLetter));
                    }
                }
            }



            return password;
        }

        public static string CalculateHash(string password, string salt)
        {
            return SiteMembershipProvider.ComputeSHA512(password + salt);
        }

        public static string GenerateHash(string password, ref string salt)
        {
            salt = salt ?? System.Web.Security.Membership.GeneratePassword(5, 1);
            return UserRepository.CalculateHash(password, salt);
        }

        private class MySaveHandler : SaveRequestHandler<UserRow>
        {
            private string password;

            public static UserRow GetUser(IDbConnection connection, BaseCriteria filter)
            {
                UserRow userRow = new UserRow();
                if (new SqlQuery().From((IEntity)userRow).Select((IField)UserRepository.fld.UserId, (IField)UserRepository.fld.Username, (IField)UserRepository.fld.FirstName, (IField)UserRepository.fld.LastName, (IField)UserRepository.fld.PasswordHash, (IField)UserRepository.fld.PasswordSalt, (IField)UserRepository.fld.StatusId).Where<SqlQuery>((ICriteria)filter).GetFirst(connection))
                    return userRow;
                return (UserRow)null;
            }

            protected override void GetEditableFields(HashSet<Field> editable)
            {
                base.GetEditableFields(editable);
                if (Authorization.HasPermission("Administration:Security"))
                    return;
                editable.Remove((Field)UserRepository.fld.StatusId);
            }

            private static bool IsInvariantLetter(char c)
            {
                if (c >= 'A' && c <= 'Z')
                    return true;
                if (c >= 'a')
                    return c <= 'z';
                return false;
            }

            private static bool IsDigit(char c)
            {
                if (c >= '0')
                    return c <= '9';
                return false;
            }

            private static bool IsValidEmailChar(char c)
            {
                if (!UserRepository.MySaveHandler.IsInvariantLetter(c) && !UserRepository.MySaveHandler.IsDigit(c) && (c != '.' && c != '_'))
                    return c == '@';
                return true;
            }

            public static bool IsValidUsername(string name)
            {
                if (name == null || name.Length < 0 || !UserRepository.MySaveHandler.IsInvariantLetter(name[0]))
                    return false;
                for (int index = 1; index < name.Length - 1; ++index)
                {
                    if (!UserRepository.MySaveHandler.IsValidEmailChar(name[index]))
                        return false;
                }
                return true;
            }

            public static string ValidateUsername(IDbConnection connection, string username, int? existingUserId)
            {
                username = username.TrimToNull();
                if (username == null)
                    throw DataValidation.RequiredError(UserRepository.fld.Username.Name, UserRepository.fld.Username.Title);
                if (!UserRepository.MySaveHandler.IsValidUsername(username))
                    throw new Serenity.Services.ValidationError("InvalidUsername", "Username", "Usernames should start with letters, only contain letters and numbers!");
                UserRow user = UserRepository.MySaveHandler.GetUser(connection, (BaseCriteria)new Criteria((IField)UserRepository.fld.Username) == username | (BaseCriteria)new Criteria((IField)UserRepository.fld.Username) == username.Replace('I', 'İ'));
                if (user != null)
                {
                    int? nullable = existingUserId;
                    int? userId = user.UserId;
                    if ((nullable.GetValueOrDefault() == userId.GetValueOrDefault() ? (nullable.HasValue != userId.HasValue ? 1 : 0) : 1) != 0)
                        throw new Serenity.Services.ValidationError("UniqueViolation", "Username", "A user with same name exists. Please choose another!");
                }
                return username;
            }

            protected override void ValidateRequest()
            {
                base.ValidateRequest();




                if (this.IsUpdate)
                {
                    UserRepository.CheckPublicDemo(this.Row.UserId);
                    if (this.Row.IsAssigned((Field)UserRepository.fld.Password) && !this.Row.Password.IsEmptyOrNull())
                        this.password = this.Row.Password = UserRepository.ValidatePassword(this.Old.Username, this.Row.Password, false);
                    if (this.Row.Username != this.Old.Username)
                        this.Row.Username = UserRepository.MySaveHandler.ValidateUsername(this.Connection, this.Row.Username, new int?(this.Old.UserId.Value));
                    if (this.Row.FirstName != this.Old.FirstName)
                        this.Row.FirstName = UserRepository.ValidateFirstName(this.Connection, this.Row.FirstName, new int?(this.Old.UserId.Value));
                    if (this.Row.LastName != this.Old.LastName)
                        this.Row.LastName = UserRepository.ValidateLastName(this.Connection, this.Row.LastName, new int?(this.Old.UserId.Value));
                }
                if (!this.IsCreate)
                    return;
                this.Row.Username = UserRepository.MySaveHandler.ValidateUsername(this.Connection, this.Row.Username, new int?());
                this.Row.FirstName = UserRepository.ValidateFirstName(this.Connection, this.Row.FirstName, new int?());
                this.Row.LastName = UserRepository.ValidateLastName(this.Connection, this.Row.LastName, new int?());
                this.password = UserRepository.ValidatePassword(this.Row.Username, this.Row.Password, true);
            }

            protected override void SetInternalFields()
            {
                base.SetInternalFields();
                if (this.IsCreate)
                {
                    UserRow row = this.Row;
                    short? statusId = this.Row.StatusId;
                    short? nullable = new short?(statusId.HasValue ? statusId.GetValueOrDefault() : (short)1);
                    row.StatusId = nullable;
                }
                if (!this.IsCreate && this.Row.Password.IsEmptyOrNull())
                    return;
                string salt = (string)null;
                this.Row.PasswordHash = UserRepository.GenerateHash(this.password, ref salt);
                this.Row.PasswordSalt = salt;
            }

            protected override void AfterSave()
            {
                base.AfterSave();
                BatchGenerationUpdater.OnCommit(this.UnitOfWork, UserRepository.fld.GenerationKey);
            }
        }

        private class MyDeleteHandler : DeleteRequestHandler<UserRow>
        {
            protected override void ValidateRequest()
            {
                base.ValidateRequest();
                UserRepository.CheckPublicDemo(this.Row.UserId);
            }
        }

        private class MyUndeleteHandler : UndeleteRequestHandler<UserRow>
        {
        }

        private class MyRetrieveHandler : RetrieveRequestHandler<UserRow>
        {
        }

        private class MyListHandler : ListRequestHandler<UserRow>
        {
        }
    }
}
