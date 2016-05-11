using System;
using System.Collections.Generic;

public class CacheMachine<TKey, TValue> where TValue : class 
{
    public long ExpireTimeSeconds = 60;

    private Dictionary<TKey,Cache<TValue>> _cache = new Dictionary<TKey, Cache<TValue>>();

    public TValue Get(TKey key)
    {
        if (_cache.ContainsKey(key))
        {
            var cache = _cache[key];
            if ((DateTime.Now - cache.SaveTime).TotalSeconds > ExpireTimeSeconds)
            {
                _cache.Remove(key);
                return null;
            }
            return cache.Data;
        }
        return null;
    }

    public void Set(TKey key, TValue value)
    {
        if (_cache.ContainsKey(key))
            _cache.Remove(key);
        _cache.Add(key, new Cache<TValue>() {Data = value, SaveTime = DateTime.Now});
    }
}