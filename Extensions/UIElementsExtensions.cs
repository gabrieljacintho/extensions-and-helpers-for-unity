// Credits: Gabriel Bertasso - contact@gabrielbertasso.com

using System;
using System.Collections.Generic;
using UnityEngine.UI;

namespace Extensions
{
    public static class UIElementsExtensions
    {
        public static void SetOnClickListener(this List<Button> buttons, Action<Button> action, bool add)
        {
            foreach (Button button in buttons)
            {
                button.SetOnClickListener(action, add);
            }
        }
        
        public static void SetOnClickListener(this Button button, Action<Button> action, bool add)
        {
            void OnClick()
            {
                action?.Invoke(button);
            }

            if (add)
            {
                button.onClick.AddListener(OnClick);
            }
            else
            {
                button.onClick.RemoveListener(OnClick);
            }
        }
    }
}