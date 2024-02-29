using System.ComponentModel.DataAnnotations;

namespace ADEK.Core.Enums
{
    public enum ActiveType
    {
        [Display(Name = "نعم")]
        True = 0,
        [Display(Name = "لا")]
        False = 1,

    }
}
