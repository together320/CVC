// Decompiled with JetBrains decompiler
// Type: CVC.Navigation.NavigationModel
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Administration.Entities;
using Serenity;
using Serenity.Navigation;
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Hosting;
using System.Linq;

namespace CVC.Navigation
{
  public class NavigationModel
  {
    public List<NavigationItem> Items { get; private set; }

    public int[] ActivePath { get; set; }

    public NavigationModel()
    {
      this.Items = TwoLevelCache.GetLocalStoreOnly<List<NavigationItem>>("LeftNavigationModel:NavigationItems:" + (Authorization.UserId ?? "-1"), TimeSpan.Zero, UserPermissionRow.Fields.GenerationKey, (Func<List<NavigationItem>>) (() => NavigationHelper.GetNavigationItems((Func<string, string>) (x =>
      {
        if (x == null || !x.StartsWith("~/"))
          return x;
        return VirtualPathUtility.ToAbsolute(x);
      }), (Func<NavigationItemAttribute, bool>) null)));
      foreach (NavigationItem link in this.Items)
        {
            if(link.Title=="Pack Settings")
            {
                foreach (NavigationItem child in link.Children)
                {
                    if (child.Title == "Bottle")
                    {
                            child.Title = GetBottleNamefromPicklist();
                    }
                }     
            }
        }
        this.SetActivePath();
    }

    private static string GetBottleNamefromPicklist()
    {
        string strBottle = string.Empty;
        using (CVC.Data.EDMX.CVCEntities cvcEntities = new CVC.Data.EDMX.CVCEntities())
        {
            var PickListId = cvcEntities.PickLists?.FirstOrDefault(pl => pl.PickListName.ToUpper() == "BOTTLE")?.PickListId ?? null;
            if (PickListId != null)
            {
                strBottle = cvcEntities.PickListValues?.FirstOrDefault(pl => pl.PickListId == PickListId)?.PickListValueName ?? "Bottle";
            }
        }
        return strBottle;
    }

        private void SetActivePath()
    {
      string currentUrl = "";
      if (HttpContext.Current != null)
      {
        Uri url = HttpContext.Current.Request.Url;
        currentUrl = url.ToString();
        if (!url.ToString().EndsWith("/") && string.Compare(url.AbsolutePath, HostingEnvironment.ApplicationVirtualPath, StringComparison.OrdinalIgnoreCase) == 0)
          currentUrl += "/";
      }
      int[] currentPath = new int[10];
      int[] bestMatch = (int[]) null;
      int bestMatchLength = 0;
      foreach (NavigationItem link in this.Items)
        this.SearchActivePath(link, currentUrl, currentPath, 0, ref bestMatch, ref bestMatchLength);
      int[] numArray;
      if (bestMatch != null)
        numArray = bestMatch;
      else
        numArray = new int[10]
        {
          -1,
          -1,
          -1,
          -1,
          -1,
          -1,
          -1,
          -1,
          -1,
          -1
        };
      this.ActivePath = numArray;
    }

    private void SearchActivePath(NavigationItem link, string currentUrl, int[] currentPath, int depth, ref int[] bestMatch, ref int bestMatchLength)
    {
      currentPath[depth + 1] = 0;
      string virtualPath = link.Url ?? "";
      if (virtualPath != null && virtualPath.StartsWith("~/", StringComparison.Ordinal))
        virtualPath = VirtualPathUtility.ToAbsolute(virtualPath);
      if (currentUrl.IndexOf(virtualPath, StringComparison.OrdinalIgnoreCase) >= 0 && (bestMatchLength == 0 || virtualPath.Length > bestMatchLength))
      {
        bestMatch = (int[]) currentPath.Clone();
        bestMatchLength = virtualPath.Length;
      }
      if (depth <= 9)
      {
        foreach (NavigationItem child in link.Children)
          this.SearchActivePath(child, currentUrl, currentPath, depth + 1, ref bestMatch, ref bestMatchLength);
      }
      ++currentPath[depth];
    }
  }
}
