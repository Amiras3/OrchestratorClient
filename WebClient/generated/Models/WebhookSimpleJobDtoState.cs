// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace WebClient.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for WebhookSimpleJobDtoState.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum WebhookSimpleJobDtoState
    {
        [EnumMember(Value = "Pending")]
        Pending,
        [EnumMember(Value = "Running")]
        Running,
        [EnumMember(Value = "Stopping")]
        Stopping,
        [EnumMember(Value = "Terminating")]
        Terminating,
        [EnumMember(Value = "Faulted")]
        Faulted,
        [EnumMember(Value = "Successful")]
        Successful,
        [EnumMember(Value = "Stopped")]
        Stopped,
        [EnumMember(Value = "Suspended")]
        Suspended,
        [EnumMember(Value = "Resumed")]
        Resumed
    }
    internal static class WebhookSimpleJobDtoStateEnumExtension
    {
        internal static string ToSerializedValue(this WebhookSimpleJobDtoState? value)
        {
            return value == null ? null : ((WebhookSimpleJobDtoState)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this WebhookSimpleJobDtoState value)
        {
            switch( value )
            {
                case WebhookSimpleJobDtoState.Pending:
                    return "Pending";
                case WebhookSimpleJobDtoState.Running:
                    return "Running";
                case WebhookSimpleJobDtoState.Stopping:
                    return "Stopping";
                case WebhookSimpleJobDtoState.Terminating:
                    return "Terminating";
                case WebhookSimpleJobDtoState.Faulted:
                    return "Faulted";
                case WebhookSimpleJobDtoState.Successful:
                    return "Successful";
                case WebhookSimpleJobDtoState.Stopped:
                    return "Stopped";
                case WebhookSimpleJobDtoState.Suspended:
                    return "Suspended";
                case WebhookSimpleJobDtoState.Resumed:
                    return "Resumed";
            }
            return null;
        }

        internal static WebhookSimpleJobDtoState? ParseWebhookSimpleJobDtoState(this string value)
        {
            switch( value )
            {
                case "Pending":
                    return WebhookSimpleJobDtoState.Pending;
                case "Running":
                    return WebhookSimpleJobDtoState.Running;
                case "Stopping":
                    return WebhookSimpleJobDtoState.Stopping;
                case "Terminating":
                    return WebhookSimpleJobDtoState.Terminating;
                case "Faulted":
                    return WebhookSimpleJobDtoState.Faulted;
                case "Successful":
                    return WebhookSimpleJobDtoState.Successful;
                case "Stopped":
                    return WebhookSimpleJobDtoState.Stopped;
                case "Suspended":
                    return WebhookSimpleJobDtoState.Suspended;
                case "Resumed":
                    return WebhookSimpleJobDtoState.Resumed;
            }
            return null;
        }
    }
}
