﻿// Copyright (c) Philipp Wagner. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace TinyCsvParser.TypeConverter
{
    public class NullableTimeSpanConverter : NullableNumericConverter<TimeSpan>
    {
        public NullableTimeSpanConverter()
            : base(new TimeSpanConverter())
        {
        }
    }
}