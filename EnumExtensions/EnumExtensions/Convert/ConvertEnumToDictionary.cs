using System;
using System.Collections.Generic;
using System.Linq;

namespace EnumExtensions
{
    internal static class ConvertEnumToDictionary
    {
        internal static Dictionary<int, string> EnumToDictionaryExt<T>() =>
            Enum.GetValues(typeof(T))
                .Cast<T>()
                .ToDictionary(t => (int)(object)t, t => t.ToString());
    }
}
