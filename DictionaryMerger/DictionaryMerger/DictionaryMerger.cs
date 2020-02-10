using System.Collections.Generic;
using System.Linq;

namespace DictionaryMerger
{
    public sealed class DictionaryMerger
    {
        public static Dictionary<TKey, TValue[]> MergeByGrouping<TKey, TValue>(params Dictionary<TKey, TValue>[] dicts)
        {
            return dicts.SelectMany(dict => dict)
                .GroupBy(kvp => kvp.Key, kvp => kvp.Value)
                .ToDictionary(grp => grp.Key, grp => grp.ToArray());
        }

        public static Dictionary<TKey, TValue[]> MergeByAggregating<TKey, TValue>(params Dictionary<TKey, TValue>[] dicts)
        {
            return dicts.SelectMany(dict => dict)
                .Aggregate(new Dictionary<TKey, List<TValue>>(), (dict, elem) =>
                {
                    if (dict.ContainsKey(elem.Key))
                    {
                        dict[elem.Key].Add(elem.Value);
                    }
                    else
                    {
                        dict[elem.Key] = new List<TValue> {elem.Value};
                    }

                    return dict;
                }).ToDictionary(kvp => kvp.Key, kvp => kvp.Value.ToArray());
        }

        public static Dictionary<TKey, TValue[]> MergeByIterating<TKey, TValue>(params Dictionary<TKey, TValue>[] dicts)
        {
            Dictionary<TKey, List<TValue>> result = new Dictionary<TKey, List<TValue>>();

            foreach (var dict in dicts)
            {
                foreach (var kvp in dict)
                {
                    if (result.ContainsKey(kvp.Key))
                    {
                        result[kvp.Key].Add(kvp.Value);
                    }
                    else
                    {
                        result[kvp.Key] = new List<TValue> {kvp.Value};
                    }
                }
            }

            return result.ToDictionary(kvp => kvp.Key, kvp => kvp.Value.ToArray());
        }

        public static Dictionary<TKey, TValue[]> MergeByKartoffelsalat<TKey, TValue>(params Dictionary<TKey, TValue>[] dicts)
        {
            return dicts
                .SelectMany(m => m)
                .GroupBy(p => p.Key)
                .ToDictionary(g => g.Key, g => g.Select(i => i.Value).ToArray());
        }

        public static Dictionary<TKey, TValue[]> MergeByBlune<TKey, TValue>(params Dictionary<TKey, TValue>[] dicts)
        {
            return dicts.SelectMany(d => d)
                .ToLookup(x => x.Key, x => x.Value)
                .ToDictionary(x => x.Key, x => x.ToArray());
        }
    }
}