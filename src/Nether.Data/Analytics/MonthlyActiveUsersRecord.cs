﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace Nether.Data.Analytics
{
    public class MonthlyActiveUsersRecord
    {
        public DateTime EventDate { get; set; }
        public int ActiveUsers { get; set; }
    }
}

