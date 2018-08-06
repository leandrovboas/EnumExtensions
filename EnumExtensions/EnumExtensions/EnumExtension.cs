using System;

namespace EnumExtensions
{
    public static class EnumExtension
    {
        /// <summary>
        /// Get value of the DescriptionAttributes
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <param name="value">Object Enum</param>
        /// <returns>Value Description</returns>
        public static string GetEnumDescription<T>(Enum value) =>
            GetDescriptionExtension<T>.GetEnumDescription(value);

        /// <summary>
        /// From an Enum returns a presentable name separated by Camel Case
        /// </summary>
        /// <param name="enumObject"></param>
        /// <returns>Display Name</returns>
        public static string AsUpperCamelCaseName(this Enum enumObject) =>
            AsUpperCamelCaseNameExtension.AsUpperCamelCaseName(enumObject);
    }
}