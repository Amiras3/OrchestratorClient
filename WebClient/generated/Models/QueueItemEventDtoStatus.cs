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
    /// Defines values for QueueItemEventDtoStatus.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum QueueItemEventDtoStatus
    {
        [EnumMember(Value = "New")]
        New,
        [EnumMember(Value = "InProgress")]
        InProgress,
        [EnumMember(Value = "Failed")]
        Failed,
        [EnumMember(Value = "Successful")]
        Successful,
        [EnumMember(Value = "Abandoned")]
        Abandoned,
        [EnumMember(Value = "Retried")]
        Retried,
        [EnumMember(Value = "Deleted")]
        Deleted
    }
    internal static class QueueItemEventDtoStatusEnumExtension
    {
        internal static string ToSerializedValue(this QueueItemEventDtoStatus? value)
        {
            return value == null ? null : ((QueueItemEventDtoStatus)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this QueueItemEventDtoStatus value)
        {
            switch( value )
            {
                case QueueItemEventDtoStatus.New:
                    return "New";
                case QueueItemEventDtoStatus.InProgress:
                    return "InProgress";
                case QueueItemEventDtoStatus.Failed:
                    return "Failed";
                case QueueItemEventDtoStatus.Successful:
                    return "Successful";
                case QueueItemEventDtoStatus.Abandoned:
                    return "Abandoned";
                case QueueItemEventDtoStatus.Retried:
                    return "Retried";
                case QueueItemEventDtoStatus.Deleted:
                    return "Deleted";
            }
            return null;
        }

        internal static QueueItemEventDtoStatus? ParseQueueItemEventDtoStatus(this string value)
        {
            switch( value )
            {
                case "New":
                    return QueueItemEventDtoStatus.New;
                case "InProgress":
                    return QueueItemEventDtoStatus.InProgress;
                case "Failed":
                    return QueueItemEventDtoStatus.Failed;
                case "Successful":
                    return QueueItemEventDtoStatus.Successful;
                case "Abandoned":
                    return QueueItemEventDtoStatus.Abandoned;
                case "Retried":
                    return QueueItemEventDtoStatus.Retried;
                case "Deleted":
                    return QueueItemEventDtoStatus.Deleted;
            }
            return null;
        }
    }
}
