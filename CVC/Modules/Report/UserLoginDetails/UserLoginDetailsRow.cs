// Decompiled with JetBrains decompiler
// Type: CVC.Report.Entities.UserLoginDetailsRow
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace CVC.Report.Entities
{
  [ConnectionKey("Default")]
  [TableName("UserLoginDetails")]
  [DisplayName("User Login Details")]
  [InstanceName("User Login Details")]
  [TwoLevelCached(new string[] {})]
  //[ReadPermission("Administration:General")]
  //[ModifyPermission("Administration:General")]
    [ReadPermission("")]
    [ModifyPermission("")]

    public sealed class UserLoginDetailsRow : Row, IIdRow, IEntity
  {
    public static readonly UserLoginDetailsRow.RowFields Fields = new UserLoginDetailsRow.RowFields().Init<UserLoginDetailsRow.RowFields>();

    [DisplayName("User Login Details Id")]
    [Identity]
    public long? UserLoginDetailsId
    {
      get
      {
        return UserLoginDetailsRow.Fields.UserLoginDetailsId[(Row) this];
      }
      set
      {
        UserLoginDetailsRow.Fields.UserLoginDetailsId[(Row) this] = value;
      }
    }

    [DisplayName("User")]
    [ForeignKey("Users", "UserId")]
    [LeftJoin("jUser")]
    [TextualField("UserEmployeeId")]
    public int? UserId
    {
      get
      {
        return UserLoginDetailsRow.Fields.UserId[(Row) this];
      }
      set
      {
        UserLoginDetailsRow.Fields.UserId[(Row) this] = value;
      }
    }

    [DisplayName("Login Datetime")]
    public DateTime? LoginDatetime
    {
      get
      {
        return UserLoginDetailsRow.Fields.LoginDatetime[(Row) this];
      }
      set
      {
        UserLoginDetailsRow.Fields.LoginDatetime[(Row) this] = value;
      }
    }

    [DisplayName("Logout Datetime")]
    public DateTime? LogoutDatetime
    {
      get
      {
        return UserLoginDetailsRow.Fields.LogoutDatetime[(Row) this];
      }
      set
      {
        UserLoginDetailsRow.Fields.LogoutDatetime[(Row) this] = value;
      }
    }

    [DisplayName("Is Online")]
    public short? IsOnline
    {
      get
      {
        return UserLoginDetailsRow.Fields.IsOnline[(Row) this];
      }
      set
      {
        UserLoginDetailsRow.Fields.IsOnline[(Row) this] = value;
      }
    }

    [DisplayName("User Employee Id")]
    [Expression("jUser.[EmployeeId]")]
    public string UserEmployeeId
    {
      get
      {
        return UserLoginDetailsRow.Fields.UserEmployeeId[(Row) this];
      }
      set
      {
        UserLoginDetailsRow.Fields.UserEmployeeId[(Row) this] = value;
      }
    }

    [DisplayName("User First Name")]
    [Expression("jUser.[FirstName]")]
    public string UserFirstName
    {
      get
      {
        return UserLoginDetailsRow.Fields.UserFirstName[(Row) this];
      }
      set
      {
        UserLoginDetailsRow.Fields.UserFirstName[(Row) this] = value;
      }
    }

    [DisplayName("User Last Name")]
    [Expression("jUser.[LastName]")]
    public string UserLastName
    {
      get
      {
        return UserLoginDetailsRow.Fields.UserLastName[(Row) this];
      }
      set
      {
        UserLoginDetailsRow.Fields.UserLastName[(Row) this] = value;
      }
    }

    [DisplayName("User Department Id")]
    [Expression("jUser.[DepartmentId]")]
    public int? UserDepartmentId
    {
      get
      {
        return UserLoginDetailsRow.Fields.UserDepartmentId[(Row) this];
      }
      set
      {
        UserLoginDetailsRow.Fields.UserDepartmentId[(Row) this] = value;
      }
    }

    [DisplayName("User Designation")]
    [Expression("jUser.[Designation]")]
    public string UserDesignation
    {
      get
      {
        return UserLoginDetailsRow.Fields.UserDesignation[(Row) this];
      }
      set
      {
        UserLoginDetailsRow.Fields.UserDesignation[(Row) this] = value;
      }
    }

    [DisplayName("User Mobile Code")]
    [Expression("jUser.[MobileCode]")]
    public int? UserMobileCode
    {
      get
      {
        return UserLoginDetailsRow.Fields.UserMobileCode[(Row) this];
      }
      set
      {
        UserLoginDetailsRow.Fields.UserMobileCode[(Row) this] = value;
      }
    }

    [DisplayName("User Mobile Number")]
    [Expression("jUser.[MobileNumber]")]
    public int? UserMobileNumber
    {
      get
      {
        return UserLoginDetailsRow.Fields.UserMobileNumber[(Row) this];
      }
      set
      {
        UserLoginDetailsRow.Fields.UserMobileNumber[(Row) this] = value;
      }
    }

    [DisplayName("User Email")]
    [Expression("jUser.[Email]")]
    public string UserEmail
    {
      get
      {
        return UserLoginDetailsRow.Fields.UserEmail[(Row) this];
      }
      set
      {
        UserLoginDetailsRow.Fields.UserEmail[(Row) this] = value;
      }
    }

    [DisplayName("User Username")]
    [Expression("jUser.[Username]")]
    public string UserUsername
    {
      get
      {
        return UserLoginDetailsRow.Fields.UserUsername[(Row) this];
      }
      set
      {
        UserLoginDetailsRow.Fields.UserUsername[(Row) this] = value;
      }
    }

    [DisplayName("User Password Hash")]
    [Expression("jUser.[PasswordHash]")]
    public string UserPasswordHash
    {
      get
      {
        return UserLoginDetailsRow.Fields.UserPasswordHash[(Row) this];
      }
      set
      {
        UserLoginDetailsRow.Fields.UserPasswordHash[(Row) this] = value;
      }
    }

    [DisplayName("User Password Salt")]
    [Expression("jUser.[PasswordSalt]")]
    public string UserPasswordSalt
    {
      get
      {
        return UserLoginDetailsRow.Fields.UserPasswordSalt[(Row) this];
      }
      set
      {
        UserLoginDetailsRow.Fields.UserPasswordSalt[(Row) this] = value;
      }
    }

    [DisplayName("User User Image")]
    [Expression("jUser.[UserImage]")]
    public Stream UserUserImage
    {
      get
      {
        return UserLoginDetailsRow.Fields.UserUserImage[(Row) this];
      }
      set
      {
        UserLoginDetailsRow.Fields.UserUserImage[(Row) this] = value;
      }
    }

    [DisplayName("User Address")]
    [Expression("jUser.[Address]")]
    public string UserAddress
    {
      get
      {
        return UserLoginDetailsRow.Fields.UserAddress[(Row) this];
      }
      set
      {
        UserLoginDetailsRow.Fields.UserAddress[(Row) this] = value;
      }
    }

    [DisplayName("User City Id")]
    [Expression("jUser.[CityId]")]
    public int? UserCityId
    {
      get
      {
        return UserLoginDetailsRow.Fields.UserCityId[(Row) this];
      }
      set
      {
        UserLoginDetailsRow.Fields.UserCityId[(Row) this] = value;
      }
    }

    [DisplayName("User Pin Code")]
    [Expression("jUser.[PinCode]")]
    public string UserPinCode
    {
      get
      {
        return UserLoginDetailsRow.Fields.UserPinCode[(Row) this];
      }
      set
      {
        UserLoginDetailsRow.Fields.UserPinCode[(Row) this] = value;
      }
    }

    [DisplayName("User Role Id")]
    [Expression("jUser.[RoleId]")]
    public int? UserRoleId
    {
      get
      {
        return UserLoginDetailsRow.Fields.UserRoleId[(Row) this];
      }
      set
      {
        UserLoginDetailsRow.Fields.UserRoleId[(Row) this] = value;
      }
    }

    [DisplayName("User Password Expiry Date")]
    [Expression("jUser.[PasswordExpiryDate]")]
    public DateTime? UserPasswordExpiryDate
    {
      get
      {
        return UserLoginDetailsRow.Fields.UserPasswordExpiryDate[(Row) this];
      }
      set
      {
        UserLoginDetailsRow.Fields.UserPasswordExpiryDate[(Row) this] = value;
      }
    }

    [DisplayName("User Is Forgot Password")]
    [Expression("jUser.[IsForgotPassword]")]
    public short? UserIsForgotPassword
    {
      get
      {
        return UserLoginDetailsRow.Fields.UserIsForgotPassword[(Row) this];
      }
      set
      {
        UserLoginDetailsRow.Fields.UserIsForgotPassword[(Row) this] = value;
      }
    }

    [DisplayName("User Is Password Change On Login")]
    [Expression("jUser.[IsPasswordChangeOnLogin]")]
    public bool? UserIsPasswordChangeOnLogin
    {
      get
      {
        return UserLoginDetailsRow.Fields.UserIsPasswordChangeOnLogin[(Row) this];
      }
      set
      {
        UserLoginDetailsRow.Fields.UserIsPasswordChangeOnLogin[(Row) this] = value;
      }
    }

    [DisplayName("User Is User Hidden")]
    [Expression("jUser.[IsUserHidden]")]
    public short? UserIsUserHidden
    {
      get
      {
        return UserLoginDetailsRow.Fields.UserIsUserHidden[(Row) this];
      }
      set
      {
        UserLoginDetailsRow.Fields.UserIsUserHidden[(Row) this] = value;
      }
    }

    [DisplayName("User Status Id")]
    [Expression("jUser.[StatusId]")]
    public int? UserStatusId
    {
      get
      {
        return UserLoginDetailsRow.Fields.UserStatusId[(Row) this];
      }
      set
      {
        UserLoginDetailsRow.Fields.UserStatusId[(Row) this] = value;
      }
    }

    [DisplayName("User Created By")]
    [Expression("jUser.[CreatedBy]")]
    public int? UserCreatedBy
    {
      get
      {
        return UserLoginDetailsRow.Fields.UserCreatedBy[(Row) this];
      }
      set
      {
        UserLoginDetailsRow.Fields.UserCreatedBy[(Row) this] = value;
      }
    }

    [DisplayName("User Created Date")]
    [Expression("jUser.[CreatedDate]")]
    public DateTime? UserCreatedDate
    {
      get
      {
        return UserLoginDetailsRow.Fields.UserCreatedDate[(Row) this];
      }
      set
      {
        UserLoginDetailsRow.Fields.UserCreatedDate[(Row) this] = value;
      }
    }

    [DisplayName("User Updated By")]
    [Expression("jUser.[UpdatedBy]")]
    public int? UserUpdatedBy
    {
      get
      {
        return UserLoginDetailsRow.Fields.UserUpdatedBy[(Row) this];
      }
      set
      {
        UserLoginDetailsRow.Fields.UserUpdatedBy[(Row) this] = value;
      }
    }

    [DisplayName("User Updated Date")]
    [Expression("jUser.[UpdatedDate]")]
    public DateTime? UserUpdatedDate
    {
      get
      {
        return UserLoginDetailsRow.Fields.UserUpdatedDate[(Row) this];
      }
      set
      {
        UserLoginDetailsRow.Fields.UserUpdatedDate[(Row) this] = value;
      }
    }

    IIdField IIdRow.IdField
    {
      get
      {
        return (IIdField) UserLoginDetailsRow.Fields.UserLoginDetailsId;
      }
    }

    public UserLoginDetailsRow()
      : base((RowFieldsBase) UserLoginDetailsRow.Fields)
    {
    }

    public class RowFields : RowFieldsBase
    {
      public Int64Field UserLoginDetailsId;
      public Int32Field UserId;
      public DateTimeField LoginDatetime;
      public DateTimeField LogoutDatetime;
      public Int16Field IsOnline;
      public StringField UserEmployeeId;
      public StringField UserFirstName;
      public StringField UserLastName;
      public Int32Field UserDepartmentId;
      public StringField UserDesignation;
      public Int32Field UserMobileCode;
      public Int32Field UserMobileNumber;
      public StringField UserEmail;
      public StringField UserUsername;
      public StringField UserPasswordHash;
      public StringField UserPasswordSalt;
      public StreamField UserUserImage;
      public StringField UserAddress;
      public Int32Field UserCityId;
      public StringField UserPinCode;
      public Int32Field UserRoleId;
      public DateTimeField UserPasswordExpiryDate;
      public Int16Field UserIsForgotPassword;
      public BooleanField UserIsPasswordChangeOnLogin;
      public Int16Field UserIsUserHidden;
      public Int32Field UserStatusId;
      public Int32Field UserCreatedBy;
      public DateTimeField UserCreatedDate;
      public Int32Field UserUpdatedBy;
      public DateTimeField UserUpdatedDate;

      public RowFields()
        : base((string) null, "")
      {
        this.LocalTextPrefix = "Report.UserLoginDetails";
      }
    }
  }
}
