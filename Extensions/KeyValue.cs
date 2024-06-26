// Credits: Gabriel Bertasso - contact@gabrielbertasso.com

using System;

namespace Extensions
{
    [Serializable]
    public struct KeyValue<TKey, TValue>
    {
        public TKey Key;
        public TValue Value;
    }
}