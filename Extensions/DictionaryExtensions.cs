// Credits: Gabriel Bertasso - contact@gabrielbertasso.com

using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Extensions
{
    public static class DictionaryExtensions
    {
        public static void Shuffle<TKey, TValue>(this IDictionary<TKey, TValue> dictionary)
        {
            dictionary.OrderBy(x => UnityEngine.Random.Range(0, Mathf.Infinity))
                .ToDictionary(item => item.Key, item => item.Value);
        }
    }
}