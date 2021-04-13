//-------------------------------------------------------------------------------------------------------------------------------------------------------------------
// <copyright file="ClientIdentifications.cs" company="Elizor (Pvt) Limited">
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
    public class ClientIdentifications
    {
        public static string ResourceOwner_LocalDB = "ResourceOwner_LocalDB";
        public static string ResourceOwner_LocalDB_OTP = "ResourceOwner_LocalDB_OTP";
        public static string ResourceOwner_ADFS = "ResourceOwner_ADFS";
        public static string ResourceOwner_AD = "ResourceOwner_AD";
        public static string ResourceOwner_Adal = "ResourceOwner_ADAL";
    }
}
