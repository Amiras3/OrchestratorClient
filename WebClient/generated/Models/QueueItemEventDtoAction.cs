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
    /// Defines values for QueueItemEventDtoAction.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum QueueItemEventDtoAction
    {
        [EnumMember(Value = "Create")]
        Create,
        [EnumMember(Value = "Edit")]
        Edit,
        [EnumMember(Value = "Delete")]
        Delete,
        [EnumMember(Value = "Status")]
        Status,
        [EnumMember(Value = "Retry")]
        Retry
    }
    internal static class QueueItemEventDtoActionEnumExtension
    {
        internal static string ToSerializedValue(this QueueItemEventDtoAction? value)
        {
            return value == null ? null : ((QueueItemEventDtoAction)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this QueueItemEventDtoAction value)
        {
            switch( value )
            {
                case QueueItemEventDtoAction.Create:
                    return "Create";
                case QueueItemEventDtoAction.Edit:
                    return "Edit";
                case QueueItemEventDtoAction.Delete:
                    return "Delete";
                case QueueItemEventDtoAction.Status:
                    return "Status";
                case QueueItemEventDtoAction.Retry:
                    return "Retry";
            }
            return null;
        }

        internal static QueueItemEventDtoAction? ParseQueueItemEventDtoAction(this string value)
        {
            switch( value )
            {
                case "Create":
                    return QueueItemEventDtoAction.Create;
                case "Edit":
                    return QueueItemEventDtoAction.Edit;
                case "Delete":
                    return QueueItemEventDtoAction.Delete;
                case "Status":
                    return QueueItemEventDtoAction.Status;
                case "Retry":
                    return QueueItemEventDtoAction.Retry;
            }
            return null;
        }
    }
}
