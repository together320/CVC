// Decompiled with JetBrains decompiler
// Type: CVC.Common.EmailHelper
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using System.IO;
using System.Net.Mail;
using System.Web.Hosting;

namespace CVC.Common
{
  public class EmailHelper
  {
    public static void Send(string subject, string body, string address, string displayName = "")
    {
      MailMessage message = new MailMessage();
      message.To.Add(new MailAddress(address, ""));
      message.Subject = subject;
      message.Body = body;
      message.IsBodyHtml = true;
      SmtpClient smtpClient = new SmtpClient();
      if (smtpClient.DeliveryMethod == SmtpDeliveryMethod.SpecifiedPickupDirectory && string.IsNullOrEmpty(smtpClient.PickupDirectoryLocation))
      {
        string path = Path.Combine(HostingEnvironment.MapPath("~/App_Data"), "Mail");
        Directory.CreateDirectory(path);
        smtpClient.PickupDirectoryLocation = path;
      }
      smtpClient.Send(message);
    }
  }
}
