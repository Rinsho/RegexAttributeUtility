﻿using System;

namespace RegularExpression.Utility
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public sealed class RegexDataListAttribute : Attribute
    {
        public char Delimiter { get; }

        public RegexDataListAttribute(char delimiter) =>
            Delimiter = delimiter;
    }
}