using System;

namespace GenomicsOrders.Utils
{
    public static class CustomExtensions
    {
        /// <summary>
        ///     If null return empty string else value
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
            return (T) Enum.Parse(typeof(T), value, true);
        }

        public static int? SafeInt(this string value)
        {
            int tempInt;

           if( int.TryParse(value, out tempInt))
            {
                return tempInt;
            }

            return null;
        }

        public static string FixSexValue(this string value)
        {
            if (string.IsNullOrEmpty(value))
                return "";

            value = value.ToLower();
            return value.StartsWith("m") ? "Male" : value.StartsWith("f") ? "Female" : "";
        }
    }
}