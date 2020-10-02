// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Commands.Synapse.Models
{
    using global::Azure.Analytics.Synapse.Artifacts.Models;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Amazon Marketplace Web Service linked service.
    /// </summary>
    [Newtonsoft.Json.JsonObject("AmazonMWS")]
    [Rest.Serialization.JsonTransformation]
    public partial class PSAmazonMWSLinkedService : PSLinkedService
    {
        /// <summary>
        /// Initializes a new instance of the PSAmazonMWSLinkedService class.
        /// </summary>
        public PSAmazonMWSLinkedService()
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the endpoint of the Amazon MWS server, (i.e.
        /// mws.amazonservices.com)
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.endpoint")]
        public object Endpoint { get; set; }

        /// <summary>
        /// Gets or sets the Amazon Marketplace ID you want to retrieve data
        /// from. To retrieve data from multiple Marketplace IDs, separate them
        /// with a comma (,). (i.e. A2EUQ1WTGCTBG2)
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.marketplaceID")]
        public object MarketplaceID { get; set; }

        /// <summary>
        /// Gets or sets the Amazon seller ID.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.sellerID")]
        public object SellerID { get; set; }

        /// <summary>
        /// Gets or sets the Amazon MWS authentication token.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.mwsAuthToken")]
        public SecretBase MwsAuthToken { get; set; }

        /// <summary>
        /// Gets or sets the access key id used to access data.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.accessKeyId")]
        public object AccessKeyId { get; set; }

        /// <summary>
        /// Gets or sets the secret key used to access data.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.secretKey")]
        public SecretBase SecretKey { get; set; }

        /// <summary>
        /// Gets or sets specifies whether the data source endpoints are
        /// encrypted using HTTPS. The default value is true.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.useEncryptedEndpoints")]
        public object UseEncryptedEndpoints { get; set; }

        /// <summary>
        /// Gets or sets specifies whether to require the host name in the
        /// server's certificate to match the host name of the server when
        /// connecting over SSL. The default value is true.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.useHostVerification")]
        public object UseHostVerification { get; set; }

        /// <summary>
        /// Gets or sets specifies whether to verify the identity of the server
        /// when connecting over SSL. The default value is true.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.usePeerVerification")]
        public object UsePeerVerification { get; set; }

        /// <summary>
        /// Gets or sets the encrypted credential used for authentication.
        /// Credentials are encrypted using the integration runtime credential
        /// manager. Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.encryptedCredential")]
        public object EncryptedCredential { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Endpoint == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Endpoint");
            }
            if (MarketplaceID == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "MarketplaceID");
            }
            if (SellerID == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SellerID");
            }
            if (AccessKeyId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AccessKeyId");
            }
        }

        public override LinkedService ToSdkObject()
        {
            var linkedService = new AmazonMWSLinkedService(this.Endpoint, this.MarketplaceID, this.SellerID, this.AccessKeyId);
            linkedService.MwsAuthToken = this.MwsAuthToken;
            linkedService.SecretKey = this.SecretKey;
            linkedService.UseEncryptedEndpoints = this.UseEncryptedEndpoints;
            linkedService.UseHostVerification = this.UseHostVerification;
            linkedService.UsePeerVerification = this.UsePeerVerification;
            linkedService.EncryptedCredential = this.EncryptedCredential;
            SetProperties(linkedService);
            return linkedService;
        }
    }
}

