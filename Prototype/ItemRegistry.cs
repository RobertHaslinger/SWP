using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Prototype.Bows;
using Prototype.Swords;

namespace Prototype
{
    public sealed class ItemRegistry
    {

        private ItemRegistry(string configPath)
        {
            try
            {
                JObject items= JObject.Parse(File.ReadAllText(configPath));
                foreach (KeyValuePair<string, JToken> item in items)
                {
                    Type type = Type.GetType("Prototype."+item.Key);
                    if (type.BaseType == typeof(SwordPrototype))
                    {
                        AddSword(item.Value["Name"].ToString(), Activator.CreateInstance(type, item.Value) as SwordPrototype);
                    }
                    else if (type.BaseType == typeof(BowPrototype))
                    {
                        AddBow(item.Value["Name"].ToString(), Activator.CreateInstance(type, item.Value) as BowPrototype);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        
        private static readonly object _objLock = new object();
        private static ItemRegistry _instance = null;
        public static ItemRegistry Instance
        {
            get
            {
                lock (_objLock)
                {
                    if (_instance == null)
                    {
                        _instance = new ItemRegistry("itemconfig.json");
                    }
                    return _instance;
                }
            }
        }

        private Dictionary<string, SwordPrototype> _swords = new Dictionary<string, SwordPrototype>();
        private Dictionary<string, BowPrototype> _bows = new Dictionary<string, BowPrototype>();

        public SwordPrototype GetSword(string key)
        {
            return _swords.TryGetValue(key, out var sword) ? sword : null;
        }

        public BowPrototype GetBow(string key)
        {
            return _bows.TryGetValue(key, out var bow) ? bow : null;
        }

        public Dictionary<string, IItem> GetAllItems()
        {
            Dictionary<string, IItem> items = new Dictionary<string, IItem>();
            foreach (var sword in _swords)
            {
                items.Add(sword.Key, sword.Value);
            }
            foreach (var bow in _bows)
            {
                items.Add(bow.Key, bow.Value);
            }

            return items;
        }

        public void AddSword(string key, SwordPrototype sword)
        {
            _swords.Add(key, sword);
        }

        public void AddBow(string key, BowPrototype bow)
        {
            _bows.Add(key, bow);
        }
    }
}
