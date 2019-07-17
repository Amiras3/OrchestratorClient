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
    /// Defines values for EnvironmentDtoType.
    /// </summary>
    [System.Obsolete("This type is deprecated. Please do not use it any longer.")]
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EnvironmentDtoType
    {
        [EnumMember(Value = "Dev")]
        Dev,
        [EnumMember(Value = "Test")]
        Test,
        [EnumMember(Value = "Prod")]
        Prod
    }
    internal static class EnvironmentDtoTypeEnumExtension
    {
        internal static string ToSerializedValue(this EnvironmentDtoType? value)
        {
            return value == null ? null : ((EnvironmentDtoType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this EnvironmentDtoType value)
        {
            switch( value )
            {
                case EnvironmentDtoType.Dev:
                    return "Dev";
                case EnvironmentDtoType.Test:
                    return "Test";
                case EnvironmentDtoType.Prod:
                    return "Prod";
            }
            return null;
        }

        internal static EnvironmentDtoType? ParseEnvironmentDtoType(this string value)
        {
            switch( value )
            {
                case "Dev":
                    return EnvironmentDtoType.Dev;
                case "Test":
                    return EnvironmentDtoType.Test;
                case "Prod":
                    return EnvironmentDtoType.Prod;
            }
            return null;
        }
    }
}
