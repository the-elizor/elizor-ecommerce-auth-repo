//-------------------------------------------------------------------------------------------------------------------------------------------------------------------
// <copyright file="ISConfiguration.cs" company="Elizor (Pvt) Limited">
// Copyright (c) Elizor (Pvt) Limited, @2021
//      All Rights Reserved.
//      This unpublished material is proprietary to Elizor. The methods and techniques described herein are considered trade secrets (copyright) and/or confidential.
//      Reproduction or distribution, in whole or in part, is forbidden except by prior express written permission from Elizor.
// </copyright>
//-------------------------------------------------------------------------------------------------------------------------------------------------------------------

using elizor.ecommerce.auth.shared.Common;
using IdentityServer4;
using IdentityServer4.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;

namespace elizor.ecommerce.auth.entityserver.Configurations
{
    public class ISConfiguration
    {
        public IConfiguration _iconfiguration;

        public ISConfiguration(IConfiguration iconfiguration)
        {
            _iconfiguration = iconfiguration;
        }

        public static IEnumerable<IdentityResource> GetIdentityResources()
        {
            return new List<IdentityResource>
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Email(),
                new IdentityResources.Profile(),
            };
        }

        public static IEnumerable<ApiResource> GetApiResources(IConfiguration iconfiguration)
        {
            return new List<ApiResource>
            {
                new ApiResource(ClientAPIs.ResourceOwner_LocalDB_OTP, ClientAPIs.ResourceOwner_LocalDB_OTP)
                {
                    ApiSecrets = new List<Secret>
                    {
                        new Secret(iconfiguration.GetSection(ClientConfigurationTypes.ResourceOwner_LocalDB_OTP)["APISecret"].ToString().Sha256())
                    },
                    Scopes= { ClientResoureScopes.ResourceOwner_LocalDB_OTP}
                },
            };
        }

        public static IEnumerable<IClient> GetClients(IConfiguration iconfiguration)
        {
            return new List<IClient> 
            {
                new IClient
                {
                    ClientId = ClientIdentifications.ResourceOwner_LocalDB_OTP,
                    ClientName = iconfiguration.GetSection(ClientConfigurationTypes.ResourceOwner_LocalDB_OTP)["ClientName"].ToString(),
                    AllowedGrantTypes = GrantTypes.ResourceOwnerPassword,
                    AllowAccessTokensViaBrowser = false,
                    AllowedCorsOrigins = iconfiguration.GetSection(ClientConfigurationTypes.ResourceOwner_LocalDB_OTP)["AllowedScopes"].ToString().Split(',').ToList(),
                    ClientSecrets =
                    {
                        new Secret(iconfiguration.GetSection(ClientConfigurationTypes.ResourceOwner_LocalDB_OTP)["ClientSecrets"].ToString().Sha256())
                    },
                    AllowedScopes =
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        ClientResoureScopes.ResourceOwner_LocalDB_OTP
                    },
                    AccessTokenLifetime = Convert.ToInt32(iconfiguration.GetSection(ClientConfigurationTypes.ResourceOwner_LocalDB_OTP)["AccessTokenLifetime"].ToString()),
                    AllowOfflineAccess = Convert.ToBoolean(iconfiguration.GetSection(ClientConfigurationTypes.ResourceOwner_LocalDB_OTP)["AllowOfflineAccess"].ToString()),
                    UpdateAccessTokenClaimsOnRefresh = Convert.ToBoolean(iconfiguration.GetSection(ClientConfigurationTypes.ResourceOwner_LocalDB_OTP)["UpdateAccessTokenClaimsOnRefresh"].ToString())
                }
            };
        }
    }
}
