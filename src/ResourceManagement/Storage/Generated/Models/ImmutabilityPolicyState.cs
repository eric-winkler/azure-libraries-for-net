// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Storage.Fluent.Models
{
    using Management.ResourceManager;
    using Management.ResourceManager.Fluent;
    using Management.ResourceManager.Fluent.Core;

    using Newtonsoft.Json;
    /// <summary>
    /// Defines values for ImmutabilityPolicyState.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(Management.ResourceManager.Fluent.Core.ExpandableStringEnumConverter<ImmutabilityPolicyState>))]
    public class ImmutabilityPolicyState : Management.ResourceManager.Fluent.Core.ExpandableStringEnum<ImmutabilityPolicyState>
    {
        public static readonly ImmutabilityPolicyState Locked = Parse("Locked");
        public static readonly ImmutabilityPolicyState Unlocked = Parse("Unlocked");
    }
}