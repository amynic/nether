﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.ComponentModel.DataAnnotations;

namespace Nether.Web.Features.Identity.Models.UserLogin
{
    public class UserLoginRequestModel
    {
        [Required]
        public string Password{ get; set; }
    }
}
