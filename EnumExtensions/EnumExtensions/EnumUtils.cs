﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace EnumExtensions
{
    public static class EnumUtils
    {
        /// <summary>
        /// Get value of the DescriptionAttributes
        /// </summary>
        /// <param name="source">Enum Value</param>
        /// <returns>Value Description</returns>
        public static string GetEnumDescription(this Enum source) =>
            source.GetEnumDescriptionExt();

        /// <summary>
        /// From an Enum returns a presentable name separated by Camel Case
        /// </summary>
        /// <param name="source">Enum Value</param>
        /// <returns>Display Name</returns>
        public static string AsUpperCamelCaseName(this Enum source) =>
            source.AsUpperCamelCaseNameExt();

        /// <summary>
        /// Get value of the DisplayNameAttribute
        /// </summary>
        /// <param name="source">Enum Value</param>
        /// <returns>Display Name</returns>
        public static string GetDisplayName(this Enum source) =>
            source.GetDisplayNameExt();

        /// <summary>
        /// Get value of the DisplayAttribute
        /// </summary>
        /// <param name="source">Enum Value</param>
        /// <returns>Display Name</returns>
        public static string GetDisplay(this Enum source) =>
            source.GetDisplayExt();

        /// <summary>
        /// Return a List with values from a Enum
        /// </summary>
        /// <typeparam name="T">Tipo Enum</typeparam>
        /// <returns>List with values from a Enum</returns>
        public static List<T> EnumToList<T>() =>
            ConvertEnumToList.Convert<T>();

        /// <summary>
        /// String to Enum
        /// </summary>
        /// <typeparam name="T">Type of Enum</typeparam>
        /// <param name="inString">String to Convert</param>
        /// <param name="ignoreCase">true ignore case/ false not ignore</param>
        /// <returns>Enum type of T</returns>
        public static T ParseEnum<T>(string inString, bool ignoreCase = true) where T : struct =>
            GenericParseEnum.ParseEnumExt<T>(inString, ignoreCase);

        /// <summary>
        /// String to Enum
        /// </summary>
        /// <typeparam name="T">Type of Enum</typeparam>
        /// <param name="inString">String to Convert</param>
        /// <param name="defaultValue">Default value to return</param>
        /// <param name="ignoreCase">true ignore case/ false not ignore</param>
        /// <returns>Enum type of T</returns>
        public static T ParseEnum<T>(string inString, T defaultValue, bool ignoreCase = true) where T : struct =>
            GenericParseEnum.ParseEnumExt(inString, defaultValue, ignoreCase);

        /// <summary>
        /// Int to Enum
        /// </summary>
        /// <typeparam name="T">Type of Enum</typeparam>
        /// <param name="input">Int to Convert</param>
        /// <returns>Enum type of T</returns>
        public static T ParseEnum<T>(int input) where T : struct =>
            GenericParseEnum.ParseEnumExt<T>(input);

        /// <summary>
        /// Int to Enum
        /// </summary>
        /// <typeparam name="T">Type of Enum</typeparam>
        /// <param name="input">Int to Convert</param>
        /// <param name="defaultValue">Default value to return</param>
        /// <returns>Enum type of T</returns>
        public static T ParseEnum<T>(int input, T defaultValue) where T : struct =>
            GenericParseEnum.ParseEnumExt(input, defaultValue);

        /// <summary>
        /// Convert Enum to Dictionary<int, string>
        /// </summary>
        /// <typeparam name="T">Type Enum</typeparam>
        /// <returns>Return Dictionary<int, string></returns>
        public static Dictionary<int, string> EnumToDictionary<T>() =>
            ConvertEnumToDictionary.EnumToDictionaryExt<T>();

        /// <summary>
        /// Convert enum to selectList
        /// </summary>
        /// <param name="source">Enum</param>
        /// <returns>SelectList with values enum</returns>
        public static SelectList ToSelectList(this Enum source) =>
            source.ToSelectListExt();
    }
}