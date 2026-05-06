using System.Xml;
using System;
using System.IO;
using System.Collections.Generic;

namespace editor
{
    namespace cfg
    {
        public sealed class CfgMgr
        {
            public delegate byte[] onLoadConfigDelegate(string file);
            public static string BinDir { get; set; } = "config";

            public static string XmlDir { get; set; } = "csv";
            public static onLoadConfigDelegate onLoadConfig;

            public static volatile CfgMgr Ins;

            private Dictionary<string, bool> configNotLoadDic = new Dictionary<string, bool>();

            private Perfect.Marshal.Octets CreateOctets(string file)
            {
                return new Perfect.Marshal.Octets(onLoadConfig?.Invoke(file));
            }

            private static List<string> GetDirFileNames(string[] dirs)
            {
                List<string> dirNames = new List<string>();
                foreach (string dir in dirs)
                {
                    string[] fileNames = Directory.GetFiles(XmlDir + "/" + dir);
                    dirNames.AddRange(fileNames);
                }

                return dirNames;
            }

            private static XmlElement CreateXmlElement(string file)
            {
                var doc = new XmlDocument();
                doc.Load(file);
                return doc.DocumentElement;
            }

            private System.Collections.Generic.Dictionary<cfg.common.ECurrencyType,cfg.common.Currency> currencyMap;
            public cfg.common.Currency GetCurrency(cfg.common.ECurrencyType key) { return currencyMap.TryGetValue(key, out var v) ? v : null; }
            public System.Collections.Generic.Dictionary<cfg.common.ECurrencyType,cfg.common.Currency> GetCurrencyMap() { return currencyMap; }
            private System.Collections.Generic.List<cfg.common.Currency> currencyList;
            public System.Collections.Generic.List<cfg.common.Currency> GetCurrencyList() { return currencyList; }
             

            private CfgMgr() {
                var currencyOctets = CreateOctets("currency.bytes");
                if(currencyOctets != null)
                {
                currencyList = cfg.Extensions.unmarshal_list_cfg_common_Currency(currencyOctets);
                currencyMap = new System.Collections.Generic.Dictionary<cfg.common.ECurrencyType,cfg.common.Currency>();
                foreach(var v in currencyList) { currencyMap.Add(v.currencyType, v); }
                }
                else{
                configNotLoadDic.Add("currency.bytes", false);
                }
                 

            }

            public static void Load() {
                Ins = new CfgMgr();
            }

            public bool IsConfigLoad(string configName)
            {
                if(configNotLoadDic.TryGetValue(configName, out bool state))
                {
                    return state;
                }

                return false;
            }
        }
    }
}
