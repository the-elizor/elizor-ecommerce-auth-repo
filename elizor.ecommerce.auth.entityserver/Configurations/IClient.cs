//-------------------------------------------------------------------------------------------------------------------------------------------------------------------
// <copyright file="IClient.cs" company="Elizor (Pvt) Limited">
// Copyright (c) Elizor (Pvt) Limited, @2021
//      All Rights Reserved.
//      This unpublished material is proprietary to Elizor. The methods and techniques described herein are considered trade secrets (copyright) and/or confidential.
//      Reproduction or distribution, in whole or in part, is forbidden except by prior express written permission from Elizor.
// </copyright>
//-------------------------------------------------------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityServer4.Models;

namespace elizor.ecommerce.auth.entityserver.Configurations
{
    public class IClient : Client
    {
        public bool ResetEnabled { get; set; }
        public string CssUri { get; set; }
        public string LoginProvider { get; set; }
        public string ClientAuthenticationType { get; set; }
    }

    public static class IDServerClientUtils
    {
        public enum ClientAuthenticationMethods { LocalDB, ExternalLogin };
    }
}
