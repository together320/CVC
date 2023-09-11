// Decompiled with JetBrains decompiler
// Type: CVC.Common.Pages.FileController
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using Serenity;
using Serenity.Services;
using Serenity.Web;
using System;
using System.IO;
using System.Web;
using System.Web.Mvc;

namespace CVC.Common.Pages
{
  public class FileController : Controller
  {
    [Route("upload/{*pathInfo}")]
    public ActionResult Read(string pathInfo)
    {
      UploadHelper.CheckFileNameSecurity(pathInfo);
      string fileName = UploadHelper.DbFilePath(pathInfo);
      return (ActionResult) new FilePathResult(fileName, UploadHelper.GetMimeType(fileName));
    }

    [Route("File/TemporaryUpload")]
    [AcceptVerbs(new string[] {"POST"})]
    public ActionResult TemporaryUpload()
    {
      Result<ServiceResponse> result = this.ExecuteMethod<ServiceResponse>((Func<ServiceResponse>) (() => this.HandleUploadRequest(this.HttpContext)));
      if (!(this.Request.Headers["Accept"] ?? "").Contains("json"))
        result.ContentType = "text/plain";
      return (ActionResult) result;
    }

    [Route("File/HandleUploadRequest")]
    private ServiceResponse HandleUploadRequest(HttpContextBase context)
    {
      if (context.Request.Files.Count != 1)
        throw new ArgumentOutOfRangeException("files");
      HttpPostedFileBase file = context.Request.Files[0];
      if (file == null)
        throw new ArgumentNullException("file");
      if (file.FileName.IsEmptyOrNull())
        throw new ArgumentNullException("filename");
      UploadProcessor uploadProcessor = new UploadProcessor()
      {
        ThumbWidth = 128,
        ThumbHeight = 96
      };
      if (uploadProcessor.ProcessStream(file.InputStream, Path.GetExtension(file.FileName)))
      {
        string dbFileName = "temporary/" + Path.GetFileName(uploadProcessor.FilePath);
        using (StreamWriter streamWriter = new StreamWriter(Path.ChangeExtension(UploadHelper.DbFilePath(dbFileName), ".orig")))
          streamWriter.WriteLine(file.FileName);
        return (ServiceResponse) new FileController.UploadResponse()
        {
          TemporaryFile = dbFileName,
          Size = uploadProcessor.FileSize,
          IsImage = uploadProcessor.IsImage,
          Width = uploadProcessor.ImageWidth,
          Height = uploadProcessor.ImageHeight
        };
      }
      FileController.UploadResponse uploadResponse = new FileController.UploadResponse();
      uploadResponse.Error = new ServiceError()
      {
        Code = "Exception",
        Message = uploadProcessor.ErrorMessage
      };
      return (ServiceResponse) uploadResponse;
    }

    private class UploadResponse : ServiceResponse
    {
      public string TemporaryFile { get; set; }

      public long Size { get; set; }

      public bool IsImage { get; set; }

      public int Width { get; set; }

      public int Height { get; set; }
    }
  }
}
