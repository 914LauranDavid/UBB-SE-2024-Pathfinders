using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace board_games.Model.CacheManager
{
    internal class CacheManager
    {
        private Dictionary<object, object> cache;


        public CacheManager()
        {
            cache = new Dictionary<object, object>();
        }

        public object? Get(object keyToGet)
        {
            if (cache.ContainsKey(keyToGet))
            {
                return cache[keyToGet];
            }
            return null;
        }

        public void Update(object keyToUpdate, object valueToUpdateTo)
        {
            if (cache.ContainsKey(keyToUpdate))
            {

                cache[keyToUpdate] = valueToUpdateTo;
            }
            else
            {
                cache.Add(keyToUpdate, valueToUpdateTo);
            }
        }

        public void Clear(object keyToClear)
        {
            if (cache.ContainsKey(keyToClear))
            {
                cache.Remove(keyToClear);
            }
        }

        public void ClearAll()
        {
            cache.Clear();
        }

        public bool Contains(object keyToCheckFor)
        {
            return cache.ContainsKey(keyToCheckFor);
        }

        public List<object> GetCachedKeys()
        {
            return cache.Keys.ToList();
        }

    }
}
