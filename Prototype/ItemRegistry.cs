using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototype.Bows;
using Prototype.Swords;

namespace Prototype
{
    public sealed class ItemRegistry
    {

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
                        _instance = new ItemRegistry();
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
