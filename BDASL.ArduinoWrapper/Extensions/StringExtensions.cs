﻿using System;

namespace BDASL.ArduinoWrapper.Extensions
{
    public static class StringExtensions
    {
        public static string FormatWith(this string s, params object[] args)
        {
            return String.Format(s, args);
        }

        public static bool HasValue(this string s)
        {
            return !HasNoValue(s);
        }

        public static bool HasNoValue(this string s)
        {
            return String.IsNullOrWhiteSpace(s);
        }
    }
}