namespace Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200614
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Extensions;

    /// <summary>Identity for the resource.</summary>
    public partial class Identity
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200614.IIdentity.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200614.IIdentity.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200614.IIdentity FromJson(Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Json.JsonObject json ? new Identity(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Json.JsonObject into a new instance of <see cref="Identity" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal Identity(Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_type = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Json.JsonString>("type"), out var __jsonType) ? (string)__jsonType : (string)Type;}
            {_principalId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Json.JsonString>("principalId"), out var __jsonPrincipalId) ? (string)__jsonPrincipalId : (string)PrincipalId;}
            {_tenantId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Json.JsonString>("tenantId"), out var __jsonTenantId) ? (string)__jsonTenantId : (string)TenantId;}
            {_userAssignedIdentity = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Json.JsonObject>("userAssignedIdentities"), out var __jsonUserAssignedIdentities) ? Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20200614.IdentityUserAssignedIdentities.FromJson(__jsonUserAssignedIdentities) : UserAssignedIdentity;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="Identity" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="Identity" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != (((object)this._type)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Json.JsonString(this._type.ToString()) : null, "type" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._principalId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Json.JsonString(this._principalId.ToString()) : null, "principalId" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._tenantId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Json.JsonString(this._tenantId.ToString()) : null, "tenantId" ,container.Add );
            }
            AddIf( null != this._userAssignedIdentity ? (Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Json.JsonNode) this._userAssignedIdentity.ToJson(null,serializationMode) : null, "userAssignedIdentities" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}