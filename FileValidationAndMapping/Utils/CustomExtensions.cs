using System;

namespace FileValidationAndMapping.Utils
{
    public static class CustomExtensions
    {
        /// <summary>
        /// If null return empty string else value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string SafeToString(this object value)
        {
            if (value == null) return "";
            return value.ToString();
        }

        public static T ParseEnum<T>(this string value)
        {
            return (T)Enum.Parse(typeof(T), value, true);
        }
    }
}