﻿namespace Bizy.WinBizApi.Extensions
{
    using System;
    using System.ComponentModel;

    public static class EnumExtensions
    {
        public static string ToDescriptionString(this Enum val)
        {
            var attributes = (DescriptionAttribute[])val.GetType().GetField(val.ToString()).GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes.Length > 0 ? attributes[0].Description : string.Empty;
        }
    }
}