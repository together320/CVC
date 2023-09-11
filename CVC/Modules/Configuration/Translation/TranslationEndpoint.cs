// Decompiled with JetBrains decompiler
// Type: CVC.Configuration.Endpoints.TranslationController
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Configuration.Repositories;
using Serenity.Services;
using System.Web.Mvc;

namespace CVC.Configuration.Endpoints
{
  [RoutePrefix("Services/Configuration/Translation")]
  [Route("{action}")]
  [ServiceAuthorize("Administration:Translation")]
  public class TranslationController : ServiceEndpoint
  {
    public ListResponse<TranslationItem> List(TranslationListRequest request)
    {
      return new TranslationRepository().List(request);
    }

    [HttpPost]
    public SaveResponse Update(TranslationUpdateRequest request)
    {
      return new TranslationRepository().Update(request);
    }
  }
}
