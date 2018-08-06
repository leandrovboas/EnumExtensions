using System.ComponentModel;

namespace ConsoleEnumExtensions
{
    enum DayEnum
    {
        [Description("Sunday")]
        Sun = 1,
        [Description("Monday")]
        Mon = 2,
        [Description("Tuesday")]
        Tue = 3,
        [Description("Wednesday")]
        Wed = 4,
        [Description("Thursday")]
        Thu = 5,
        [Description("Friday")]
        Fri = 6,
        [Description("Saturday")]
        Sat = 7
    };
}
