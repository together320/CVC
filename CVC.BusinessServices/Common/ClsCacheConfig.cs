using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;

namespace CVC.BusinessServices.Common
{
   public class ClsCacheConfig
    {
        ObjectCache cache = MemoryCache.Default;

        public static class CacheKeys
        {
            public const string OPCUaClientSession = "OPCUaClientSession";
            public const string ImportedFileName = "ImportedFileName";
            public const string ImportedFileData = "ImportedFileData";
            public const string ImportedFileFormName = "ImportedFileFormName";
            public const string ImportedFilePreviousPageUrl= "ImportedFilePreviousPageUrl";
            public const string ImportedFileDataAfterColumnFieldMapping = "ImportedFileDataAfterColumnFieldMapping";
            public const string ImportedFileColumnFieldMappingList = "ImportedFileColumnFieldMappingList";
            public const string LoggedUserId = "LoggedUserId";
            public const string NextSessionRenewalTime = "NextSessionRenewalTime";
            public const string OPCUaConfigurationParameter = "OPCUaConfigurationParameter";
            public const string MachineCommunication = "MachineCommunication";


        }

        public static class CacheExpiry
        {
            public static DateTime CacheExpiryTime =DateTime.Now.AddDays(30.0);
        }

        public void AddItemToCache(string cacheKey,object cacheItem)
        {
            RemoveItemFromCache(cacheKey);
            CacheItemPolicy cacheItemPolicy = new CacheItemPolicy();
            cacheItemPolicy.AbsoluteExpiration = CacheExpiry.CacheExpiryTime;
            cache.Add(cacheKey, cacheItem, cacheItemPolicy);
        }

        public void RemoveItemFromCache(string cacheKey)
        {
            cache.Remove(cacheKey);

        }

        public object GetCacheData(string cacheKey)
        {
            object cacheData = null;
            if (cache.Contains(cacheKey))
            {
             return cacheData = cache.Get(cacheKey);

            }
            return cacheData;
        }

    }
}
