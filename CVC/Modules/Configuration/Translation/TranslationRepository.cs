// Decompiled with JetBrains decompiler
// Type: CVC.Configuration.Repositories.TranslationRepository
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Administration.Entities;
using Newtonsoft.Json.Linq;
using Serenity;
using Serenity.Abstractions;
using Serenity.ComponentModel;
using Serenity.Configuration;
using Serenity.Extensibility;
using Serenity.Localization;
using Serenity.Navigation;
using Serenity.Services;
using Serenity.Web;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web.Hosting;

namespace CVC.Configuration.Repositories
{
  public class TranslationRepository
  {
    private static string GetUserTextsFilePath(string languageID)
    {
      return HostingEnvironment.MapPath("~/App_Data/texts/") + "user.texts." + (languageID.TrimToNull() ?? "invariant") + ".json";
    }

    public ListResponse<TranslationItem> List(TranslationListRequest request)
    {
      ListResponse<TranslationItem> listResponse = new ListResponse<TranslationItem>();
      HashSet<string> availableLocalTextKeys = this.GetAllAvailableLocalTextKeys();
      string languageID1 = request.TargetLanguageID.TrimToNull();
      Dictionary<string, string> target = new Dictionary<string, string>((IEqualityComparer<string>) StringComparer.OrdinalIgnoreCase);
      string userTextsFilePath = TranslationRepository.GetUserTextsFilePath(languageID1);
      if (File.Exists(userTextsFilePath))
      {
        JsonLocalTextRegistration.ProcessNestedDictionary((IDictionary<string, JToken>) JsonConfigHelper.LoadConfig<Dictionary<string, JToken>>(userTextsFilePath), "", target);
        foreach (string key in target.Keys)
          availableLocalTextKeys.Add(key);
      }
      string[] array = new string[availableLocalTextKeys.Count];
      availableLocalTextKeys.CopyTo(array);
      Array.Sort<string>(array);
      ILocalTextRegistry localTextRegistry = Dependency.Resolve<ILocalTextRegistry>();
      string languageID2 = languageID1 ?? "";
      string empty = request.SourceLanguageID.TrimToEmpty();
      listResponse.Entities = new List<TranslationItem>();
      Func<string, string> func = (Func<string, string>) (key =>
      {
        if (key.StartsWith("Navigation."))
        {
          key = key.Substring("Navigation.".Length);
          return ((IEnumerable<string>) key.Split('/')).Last<string>();
        }
        if (!key.StartsWith("Forms.") || !key.Contains(".Categories."))
          return key;
        return ((IEnumerable<string>) key.Split('.')).Last<string>().TrimToNull();
      });
      foreach (string key in array)
      {
        string str;
        if (!target.TryGetValue(key, out str))
          str = (string) null;
        listResponse.Entities.Add(new TranslationItem()
        {
          Key = key,
          SourceText = localTextRegistry.TryGet(empty, key) ?? func(key),
          TargetText = localTextRegistry.TryGet(languageID2, key) ?? func(key),
          CustomText = str
        });
      }
      return listResponse;
    }

    public HashSet<string> GetAllAvailableLocalTextKeys()
    {
      HashSet<string> list = new HashSet<string>((IEqualityComparer<string>) StringComparer.OrdinalIgnoreCase);
      foreach (Assembly selfAssembly in ExtensibilityHelper.SelfAssemblies)
      {
        foreach (NavigationItemAttribute customAttribute in selfAssembly.GetCustomAttributes<NavigationItemAttribute>())
          list.Add("Navigation." + (customAttribute.Category.IsEmptyOrNull() ? "" : customAttribute.Category + "/") + customAttribute.Title);
        foreach (Type type in selfAssembly.GetTypes())
        {
          FormScriptAttribute customAttribute1 = type.GetCustomAttribute<FormScriptAttribute>();
          if (customAttribute1 != null)
          {
            foreach (MemberInfo member in type.GetMembers(BindingFlags.Instance | BindingFlags.Public))
            {
              CategoryAttribute customAttribute2 = member.GetCustomAttribute<CategoryAttribute>();
              if (customAttribute2 != null && !customAttribute2.Category.IsEmptyOrNull())
                list.Add("Forms." + customAttribute1.Key + ".Categories." + customAttribute2.Category);
            }
          }
        }
      }
      LocalTextRegistry localTextRegistry = Dependency.Resolve<ILocalTextRegistry>() as LocalTextRegistry;
      if (localTextRegistry != null)
        list.AddRange<string>((IEnumerable<string>) localTextRegistry.GetAllTextKeys(false));
      return list;
    }

    public SaveResponse Update(TranslationUpdateRequest request)
    {
      if (request.Translations == null)
        throw new ArgumentNullException("translations");
      List<TranslationItem> entities = this.List(new TranslationListRequest()
      {
        SourceLanguageID = request.TargetLanguageID
      }).Entities;
      Func<TranslationItem, string> func = (Func<TranslationItem, string>) (x => x.Key);
            Func<TranslationItem, string> keySelector = (Func<TranslationItem, string>)(x => x.Key);
      Dictionary<string, string> dictionary = entities.ToDictionary<TranslationItem, string, string>(keySelector, (Func<TranslationItem, string>) (x => x.CustomText));
      foreach (KeyValuePair<string, string> translation in request.Translations)
        dictionary[translation.Key] = translation.Value;
      SortedDictionary<string, string> sortedDictionary = new SortedDictionary<string, string>((IComparer<string>) StringComparer.OrdinalIgnoreCase);
      foreach (KeyValuePair<string, string> keyValuePair in dictionary)
      {
        if (!keyValuePair.Value.IsEmptyOrNull())
          sortedDictionary.Add(keyValuePair.Key, keyValuePair.Value);
      }
      string contents = JSON.StringifyIndented((object) sortedDictionary, 2);
      string userTextsFilePath = TranslationRepository.GetUserTextsFilePath(request.TargetLanguageID);
      Directory.CreateDirectory(Path.GetDirectoryName(userTextsFilePath));
      File.WriteAllText(userTextsFilePath, contents);
      Dependency.Resolve<IDependencyRegistrar>().RegisterInstance<ILocalTextRegistry>((ILocalTextRegistry) new LocalTextRegistry());
      CommonInitialization.InitializeLocalTexts();
      TwoLevelCache.ExpireGroupItems(UserRow.Fields.GenerationKey);
      DynamicScriptManager.Reset();
      return new SaveResponse();
    }
  }
}
