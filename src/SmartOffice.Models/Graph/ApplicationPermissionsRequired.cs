// -----------------------------------------------------------------------
// <copyright file="ApplicationPermissionsRequired.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace Microsoft.Partner.SmartOffice.Models.Graph
{
    public enum ApplicationPermissionsRequired
    {
        Unknown = 0,
        Anonymous = 1,
        Guest = 2,
        User = 3,
        Administrator = 4,
        System = 5,
        UnknownFutureValue = 127
    }
}