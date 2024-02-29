﻿using System.ComponentModel.DataAnnotations;

namespace ADEK.Core.Enums
{
    public enum RoleTypes
    {
        [Display(Name = "مساعد مدير نظام")]
        Admin = 0,
        [Display(Name = "مدير نظام")]
        SuperAdmin = 1,
        [Display(Name = "مستخدم")]
        User = 2,
    }
}