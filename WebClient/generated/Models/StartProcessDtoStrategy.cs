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
    /// Defines values for StartProcessDtoStrategy.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StartProcessDtoStrategy
    {
        [EnumMember(Value = "All")]
        All,
        [EnumMember(Value = "Specific")]
        Specific,
        [EnumMember(Value = "RobotCount")]
        RobotCount,
        [EnumMember(Value = "JobsCount")]
        JobsCount
    }
    internal static class StartProcessDtoStrategyEnumExtension
    {
        internal static string ToSerializedValue(this StartProcessDtoStrategy? value)
        {
            return value == null ? null : ((StartProcessDtoStrategy)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this StartProcessDtoStrategy value)
        {
            switch( value )
            {
                case StartProcessDtoStrategy.All:
                    return "All";
                case StartProcessDtoStrategy.Specific:
                    return "Specific";
                case StartProcessDtoStrategy.RobotCount:
                    return "RobotCount";
                case StartProcessDtoStrategy.JobsCount:
                    return "JobsCount";
            }
            return null;
        }

        internal static StartProcessDtoStrategy? ParseStartProcessDtoStrategy(this string value)
        {
            switch( value )
            {
                case "All":
                    return StartProcessDtoStrategy.All;
                case "Specific":
                    return StartProcessDtoStrategy.Specific;
                case "RobotCount":
                    return StartProcessDtoStrategy.RobotCount;
                case "JobsCount":
                    return StartProcessDtoStrategy.JobsCount;
            }
            return null;
        }
    }
}
