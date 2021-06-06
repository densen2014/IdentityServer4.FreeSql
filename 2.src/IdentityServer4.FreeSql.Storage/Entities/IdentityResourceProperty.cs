﻿// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


#pragma warning disable 1591

using FreeSql.DataAnnotations;

namespace IdentityServer4.FreeSql.Storage.Entities
{
    public class IdentityResourceProperty : Property
    {
        public long IdentityResourceId { get; set; }

        [Navigate(nameof(Entities.IdentityResource.Id))]
        public IdentityResource IdentityResource { get; set; }
    }
}