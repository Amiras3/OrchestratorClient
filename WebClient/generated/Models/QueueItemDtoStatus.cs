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
    /// Defines values for QueueItemDtoStatus.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum QueueItemDtoStatus
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
    internal static class QueueItemDtoStatusEnumExtension
    {
        internal static string ToSerializedValue(this QueueItemDtoStatus? value)
        {
            return value == null ? null : ((QueueItemDtoStatus)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this QueueItemDtoStatus value)
        {
            switch( value )
            {
                case QueueItemDtoStatus.New:
                    return "New";
                case QueueItemDtoStatus.InProgress:
                    return "InProgress";
                case QueueItemDtoStatus.Failed:
                    return "Failed";
                case QueueItemDtoStatus.Successful:
                    return "Successful";
                case QueueItemDtoStatus.Abandoned:
                    return "Abandoned";
                case QueueItemDtoStatus.Retried:
                    return "Retried";
                case QueueItemDtoStatus.Deleted:
                    return "Deleted";
            }
            return null;
        }

        internal static QueueItemDtoStatus? ParseQueueItemDtoStatus(this string value)
        {
            switch( value )
            {
                case "New":
                    return QueueItemDtoStatus.New;
                case "InProgress":
                    return QueueItemDtoStatus.InProgress;
                case "Failed":
                    return QueueItemDtoStatus.Failed;
                case "Successful":
                    return QueueItemDtoStatus.Successful;
                case "Abandoned":
                    return QueueItemDtoStatus.Abandoned;
                case "Retried":
                    return QueueItemDtoStatus.Retried;
                case "Deleted":
                    return QueueItemDtoStatus.Deleted;
            }
            return null;
        }
    }
}
