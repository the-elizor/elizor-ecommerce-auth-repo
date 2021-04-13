//-------------------------------------------------------------------------------------------------------------------------------------------------------------------
// <copyright file="ClientConfigurationTypes.cs" company="Elizor (Pvt) Limited">
// Copyright (c) Elizor (Pvt) Limited, @2021
//      All Rights Reserved.
//      This unpublished material is proprietary to Elizor. The methods and techniques described herein are considered trade secrets (copyright) and/or confidential.
//      Reproduction or distribution, in whole or in part, is forbidden except by prior express written permission from Elizor.
// </copyright>
//-------------------------------------------------------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;

namespace elizor.ecommerce.auth.shared.Common
{
    public class ClientConfigurationTypes
    {
        public static string ResourceOwner_LocalDB = "ResourceOwnerLocalDBConfigurations";
        public static string ResourceOwner_ADFS = "ResourceOwnerADFSConfigurations";
        public static string ResourceOwner_AD = "ResourceOwnerADConfigurations";
        public static string ResourceOwner_LocalDB_OTP = "ResourceOwnerLocalDBOTPConfigurations";
        public static string ResourceOwner_Adal = "ResourceOwnerADALConfigurations";
    }
}
