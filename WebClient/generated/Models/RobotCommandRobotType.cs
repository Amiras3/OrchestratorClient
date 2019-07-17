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
    /// Defines values for RobotCommandRobotType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RobotCommandRobotType
    {
        [EnumMember(Value = "NonProduction")]
        NonProduction,
        [EnumMember(Value = "Attended")]
        Attended,
        [EnumMember(Value = "Unattended")]
        Unattended,
        [EnumMember(Value = "Development")]
        Development
    }
    internal static class RobotCommandRobotTypeEnumExtension
    {
        internal static string ToSerializedValue(this RobotCommandRobotType? value)
        {
            return value == null ? null : ((RobotCommandRobotType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this RobotCommandRobotType value)
        {
            switch( value )
            {
                case RobotCommandRobotType.NonProduction:
                    return "NonProduction";
                case RobotCommandRobotType.Attended:
                    return "Attended";
                case RobotCommandRobotType.Unattended:
                    return "Unattended";
                case RobotCommandRobotType.Development:
                    return "Development";
            }
            return null;
        }

        internal static RobotCommandRobotType? ParseRobotCommandRobotType(this string value)
        {
            switch( value )
            {
                case "NonProduction":
                    return RobotCommandRobotType.NonProduction;
                case "Attended":
                    return RobotCommandRobotType.Attended;
                case "Unattended":
                    return RobotCommandRobotType.Unattended;
                case "Development":
                    return RobotCommandRobotType.Development;
            }
            return null;
        }
    }
}
