// Credits: Gabriel Bertasso - contact@gabrielbertasso.com

using UnityEngine;
using UnityEngine.UI;

namespace Extensions
{
    public static class GraphicExtensions
    {
        public static void SetAlpha(this Graphic graphic, float value)
        {
            Color color = graphic.color;
            color.a = value;
            graphic.color = color;
        }
    }
}