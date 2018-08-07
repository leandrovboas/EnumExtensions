using System;
using System.Text.RegularExpressions;

namespace EnumExtensions
{
    internal static class AsUpperCamelCaseNameExtension
    {
        private static readonly Regex UpperCamelCaseRegex = new Regex(@"(?<!^)((?<!\d)\d|(?(?<=[A-Z])[A-Z](?=[a-z])|[A-Z]))", RegexOptions.Compiled);

        internal static string AsUpperCamelCaseNameExt(this Enum e) =>
            UpperCamelCaseRegex.Replace(e.ToString(), " $1");
    }
}
