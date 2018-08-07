﻿namespace Microsoft.ApplicationInsights.Extensibility.Implementation.External
{
    using System.Diagnostics;
    using Microsoft.ApplicationInsights;
    using Microsoft.ApplicationInsights.DataContracts;

    /// <summary>
    /// Partial class to implement IExtension
    /// </summary>
    internal partial class RequestData : IExtension
    {
        public void Serialize(ISerializationWriter serializationWriter)
        {
            serializationWriter.WriteProperty("ver", this.ver);
            serializationWriter.WriteProperty("id", this.id);
            serializationWriter.WriteProperty("source", this.source);
            serializationWriter.WriteProperty("name", this.name);
            serializationWriter.WriteProperty("duration", Utils.ValidateDuration(this.duration));
            serializationWriter.WriteProperty("success", this.success);
            serializationWriter.WriteProperty("responseCode", this.responseCode);
            serializationWriter.WriteProperty("url", this.url);
            serializationWriter.WriteProperty("properties", this.properties);
            serializationWriter.WriteProperty("measurements", this.measurements);
        }

        IExtension IExtension.DeepClone()
        {
            return this.DeepClone();
        }
    }
}