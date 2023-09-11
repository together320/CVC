// Decompiled with JetBrains decompiler
// Type: CVC.Administration.IDirectoryService
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

namespace CVC.Administration
{
  public interface IDirectoryService
  {
    DirectoryEntry Validate(string username, string password);
  }
}
