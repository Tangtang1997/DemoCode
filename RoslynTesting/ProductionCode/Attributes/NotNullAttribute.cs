﻿// Copyright 2014 Jon Skeet. All rights reserved. Use of this source code is governed by the Apache License 2.0, as found in the LICENSE.txt file.
using System;

namespace ProductionCode.Attributes
{
    [AttributeUsage(AttributeTargets.Parameter)]
    public sealed class NotNullAttribute : Attribute
    {
    }
}