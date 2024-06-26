// Credits: Gabriel Bertasso - contact@gabrielbertasso.com

using UnityEngine;

namespace Extensions
{
    public static class RigidbodyExtensions
    {
        public static void Push(this Rigidbody rigidbody, Vector3 direction, float force, Vector3 position)
        {
            rigidbody.AddForceAtPosition(direction * force, position, ForceMode.Impulse);
        }
        
        public static void ResetVelocity(this Rigidbody rigidbody)
        {
            if (!rigidbody.isKinematic)
            {
                rigidbody.velocity = Vector3.zero;
                rigidbody.angularVelocity = Vector3.zero;
            }
        }
    }
}