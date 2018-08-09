using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Linq;

namespace EnumExtensions
{
    internal static class ConvertToSelectList
    {
        internal static SelectList ToSelectListExt(this Enum source)
        {
            var list = (from Enum d in Enum.GetValues(source.GetType())
                        select new SelectListItem { Value = d.ToString(("d")), Text = Enum.GetName(source.GetType(), d) }).ToList();

            var selectedValue = (int)Enum.Parse(source.GetType(), Enum.GetName(source.GetType(), source));

            return new SelectList(list, "Value", "Text", selectedValue);
        }
    }
}
