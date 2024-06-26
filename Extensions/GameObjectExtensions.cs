// Credits: Gabriel Bertasso - contact@gabrielbertasso.com

using System.Linq;
using UnityEngine;

namespace Extensions
{
    public static class GameObjectExtensions
    {
        public static void SetLayerRecursively(this GameObject gameObject, int layer)
        {
            gameObject.layer = layer;
   
            foreach (Transform child in gameObject.transform)
            {
                SetLayerRecursively(child.gameObject, layer);
            }
        }
        
        public static void SetActiveChildren(this GameObject gameObject, bool value)
        {
            foreach (Transform child in gameObject.transform)
            {
                child.gameObject.SetActive(value);
            }
        }
        
        public static GameObject FindChildWithName(this GameObject gameObject, string name)
        {
            if (gameObject.name == name)
                return gameObject;
            
            foreach (Transform child in gameObject.transform)
            {
                GameObject result = child.gameObject.FindChildWithName(name);
                if (result != null)
                    return result;
            }

            return null;
        }
        
        public static T GetOrAddComponent<T>(this GameObject gameObject) where T : Component
        {
            if (!gameObject.TryGetComponent(out T t))
            {
                t = gameObject.AddComponent<T>();
            }
            
            return t;
        }

        public static Component GetOrAddComponent(this GameObject gameObject, System.Type type)
        {
            if (!gameObject.TryGetComponent(type, out Component component))
            {
                component = gameObject.AddComponent(type);
            }

            return component;
        }

        public static T[] GetInterfacesInChildren<T>(this GameObject gameObject, bool includeInactive = false)
        {
            return gameObject.GetComponentsInChildren<MonoBehaviour>(includeInactive).OfType<T>().ToArray();
        }
    }
}