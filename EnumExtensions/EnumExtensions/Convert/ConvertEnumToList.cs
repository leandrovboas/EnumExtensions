using System;
using System.Collections.Generic;
using System.Linq;

namespace EnumExtensions
{
    internal static class ConvertEnumToList
    {
        internal static List<T> Convert<T>() =>
            typeof(T).BaseType != typeof(Enum)
                ? throw new ArgumentException("T must be of type System.Enum")
                : Enum.GetValues(typeof(T))
                    .Cast<T>()
                    .ToList();
    }
}




