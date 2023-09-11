// Decompiled with JetBrains decompiler
// Type: CVC.Data.Exception
// Assembly: CVC.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47E8AB0A-5811-4D94-AF76-6F9B6303484D
// Assembly location: D:\Anil\CVC\bin\CVC.Data.dll

using System;

namespace CVC.Data
{
  public class Exception
  {
    public long Id { get; set; }

    public string GUID { get; set; }

    public string ApplicationName { get; set; }

    public string MachineName { get; set; }

    public DateTime CreationDate { get; set; }

    public string Type { get; set; }

    public bool IsProtected { get; set; }

    public string Host { get; set; }

    public string Url { get; set; }

    public string HTTPMethod { get; set; }

    public string IPAddress { get; set; }

    public string Source { get; set; }

    public string Message { get; set; }

    public string Detail { get; set; }

    public int? StatusCode { get; set; }

    public string SQL { get; set; }

    public DateTime? DeletionDate { get; set; }

    public string FullJson { get; set; }

    public int? ErrorHash { get; set; }

    public int DuplicateCount { get; set; }
  }
}
