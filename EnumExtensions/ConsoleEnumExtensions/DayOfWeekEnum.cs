using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ConsoleEnumExtensions
{
    enum DayOfWeek
    {
        [Description("Description : Sunday")]
        [DisplayName("DisplayName : Sunday")]
        [Display(Name ="Display : Sunday")]
        Sun = 1,
        [Description("Description : Monday")]
        [DisplayName("DisplayName : Monday")]
        [Display(Name = "Display : Monday")]
        Mon = 2,
        [Description("Description : Tuesday")]
        [DisplayName("DisplayName : Tuesday")]
        [Display(Name = "Display : Tuesday")]
        Tue = 3,
        [Description("Description : Wednesday")]
        [DisplayName("DisplayName : Wednesday")]
        [Display(Name = "Display : Wednesday")]

        Wed = 4,
        [Description("Description : Thursday")]
        [DisplayName("DisplayName : Thursday")]
        [Display(Name = "Display : Thursday")]
        Thu = 5,
        [Description("Description : Friday")]
        [DisplayName("DisplayName : Friday")]
        [Display(Name = "Display : Friday")]
        Fri = 6,
        [Description("Description : Saturday")]
        [DisplayName("DisplayName : Saturday")]
        [Display(Name = "Display : Saturday")]
        Sat = 7
    };
}
