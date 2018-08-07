using System;
using System.Collections.Generic;

namespace EnumExtensions
{
    public static class EnumExtension
    {
        /// <summary>
        /// Get value of the DescriptionAttributes
        /// </summary>
        /// <param name="enumValue">Enum Value</param>
        /// <returns>Value Description</returns>
        public static string GetEnumDescription(this Enum enumValue) =>
            enumValue.GetEnumDescriptionExt();
        //GetDescriptionExtension.GetEnumDescription(value);

        /// <summary>
        /// From an Enum returns a presentable name separated by Camel Case
        /// </summary>
        /// <param name="enumValue">Enum Value</param>
        /// <returns>Display Name</returns>
        public static string AsUpperCamelCaseName(this Enum enumValue) =>
            enumValue.AsUpperCamelCaseNameExt();

        /// <summary>
        /// Get value of the DisplayNameAttribute
        /// </summary>
        /// <param name="enumValue">Enum Value</param>
        /// <returns>Display Name</returns>
        public static string GetDisplayName(this Enum enumValue) =>
            enumValue.GetDisplayNameExt();

        /// <summary>
        /// Get value of the DisplayAttribute
        /// </summary>
        /// <param name="enumValue">Enum Value</param>
        /// <returns>Display Name</returns>
        public static string GetDisplay(this Enum enumValue) =>
            enumValue.GetDisplayExt();

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="enumValue"></param>
        /// <returns></returns>
        public static List<T> EnumToList<T>(this Enum enumValue) =>
            enumValue.EnumToListExt<T>();
    }
}