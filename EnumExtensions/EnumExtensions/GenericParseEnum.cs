using System;

namespace EnumExtensions
{
    internal static class GenericParseEnum
    {
        internal static T ParseEnumExt<T>(string inString, bool ignoreCase = true) where T : struct =>
            ParseEnumExt(inString, default(T), ignoreCase);

        internal static T ParseEnumExt<T>(string inString, T defaultValue, bool ignoreCase = true) where T : struct
        {
            var returnEnum = defaultValue;

            if (!typeof(T).IsEnum) throw new InvalidOperationException($"Invalid Enum Type must be an Enum");
            if (String.IsNullOrEmpty(inString)) throw new InvalidOperationException($"Input String 'inString'");

            try
            {
                var success = Enum.TryParse(inString, ignoreCase, out returnEnum);
                if (!success) throw new InvalidOperationException("Invalid Cast");
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Invalid Cast", ex);
            }

            return returnEnum;
        }

        public static T ParseEnumExt<T>(int input) where T : struct =>
            ParseEnumExt(input, default(T));

        public static T ParseEnumExt<T>(int input, T defaultValue) where T : struct
        {
            if (!typeof(T).IsEnum) throw new InvalidOperationException($"Invalid Enum Type. {typeof(T)}  must be an Enum");

            return Enum.IsDefined(typeof(T), input) ? (T)Enum.ToObject(typeof(T), input) : defaultValue;
        }
    }
}
