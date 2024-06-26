// Credits: Gabriel Bertasso - contact@gabrielbertasso.com

#if I2_LOCALIZATION
using I2.Loc;
#endif

namespace Extensions
{
    public static class StringExtensions
    {
        public static string ToUpperFirstChar(this string text)
        {
            return text[0].ToString().ToUpper() + text.Substring(1);
        }
        
        public static string ToLowerFirstChar(this string text)
        {
            return text[0].ToString().ToLower() + text.Substring(1);
        }
#if I2_LOCALIZATION
        public static string GetLocalized(this string term, string category = null)
        {
            if (!string.IsNullOrEmpty(category))
            {
                return LocalizationManager.GetTranslation(category + "/" + term);
            }
            
            return LocalizationManager.GetTranslation(term);
        }
#endif
        public static string GetUntil(this string text, string stopAt)
        {
            if (!text.Contains(stopAt))
            {
                return text;
            }    

            int endIndex = text.IndexOf(stopAt);

            return text.Substring(0, endIndex);
        }
    }
}