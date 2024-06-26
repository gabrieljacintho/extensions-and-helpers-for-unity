// Credits: Gabriel Bertasso - contact@gabrielbertasso.com

using UnityEngine;

namespace Helpers
{
    public static class QuaternionHelper
    {
        public static Quaternion Random(Vector3 range)
        {
            Vector3 value = VectorHelper.Random(range);
            
            return Quaternion.Euler(value);
        }
    }
}