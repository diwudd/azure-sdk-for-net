// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Billing.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A partner's customer.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Customer : Resource
    {
        /// <summary>
        /// Initializes a new instance of the Customer class.
        /// </summary>
        public Customer()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Customer class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="billingProfileId">The ID of the billing profile for
        /// the invoice section.</param>
        /// <param name="billingProfileDisplayName">The name of the billing
        /// profile for the invoice section.</param>
        /// <param name="displayName">The name of the customer.</param>
        /// <param name="enabledAzurePlans">Azure plans enabled for the
        /// customer.</param>
        /// <param name="resellers">The list of resellers for which an Azure
        /// plan is enabled for the customer.</param>
        public Customer(string id = default(string), string name = default(string), string type = default(string), string billingProfileId = default(string), string billingProfileDisplayName = default(string), string displayName = default(string), IList<AzurePlan> enabledAzurePlans = default(IList<AzurePlan>), IList<Reseller> resellers = default(IList<Reseller>))
            : base(id, name, type)
        {
            BillingProfileId = billingProfileId;
            BillingProfileDisplayName = billingProfileDisplayName;
            DisplayName = displayName;
            EnabledAzurePlans = enabledAzurePlans;
            Resellers = resellers;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the ID of the billing profile for the invoice section.
        /// </summary>
        [JsonProperty(PropertyName = "properties.billingProfileId")]
        public string BillingProfileId { get; private set; }

        /// <summary>
        /// Gets the name of the billing profile for the invoice section.
        /// </summary>
        [JsonProperty(PropertyName = "properties.billingProfileDisplayName")]
        public string BillingProfileDisplayName { get; private set; }

        /// <summary>
        /// Gets or sets the name of the customer.
        /// </summary>
        [JsonProperty(PropertyName = "properties.displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets azure plans enabled for the customer.
        /// </summary>
        [JsonProperty(PropertyName = "properties.enabledAzurePlans")]
        public IList<AzurePlan> EnabledAzurePlans { get; set; }

        /// <summary>
        /// Gets or sets the list of resellers for which an Azure plan is
        /// enabled for the customer.
        /// </summary>
        [JsonProperty(PropertyName = "properties.resellers")]
        public IList<Reseller> Resellers { get; set; }

    }
}
