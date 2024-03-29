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
    /// Defines values for WebhookSimpleUserDtoType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum WebhookSimpleUserDtoType
    {
        [EnumMember(Value = "User")]
        User,
        [EnumMember(Value = "Robot")]
        Robot,
        [EnumMember(Value = "DirectoryUser")]
        DirectoryUser,
        [EnumMember(Value = "DirectoryGroup")]
        DirectoryGroup
    }
    internal static class WebhookSimpleUserDtoTypeEnumExtension
    {
        internal static string ToSerializedValue(this WebhookSimpleUserDtoType? value)
        {
            return value == null ? null : ((WebhookSimpleUserDtoType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this WebhookSimpleUserDtoType value)
        {
            switch( value )
            {
                case WebhookSimpleUserDtoType.User:
                    return "User";
                case WebhookSimpleUserDtoType.Robot:
                    return "Robot";
                case WebhookSimpleUserDtoType.DirectoryUser:
                    return "DirectoryUser";
                case WebhookSimpleUserDtoType.DirectoryGroup:
                    return "DirectoryGroup";
            }
            return null;
        }

        internal static WebhookSimpleUserDtoType? ParseWebhookSimpleUserDtoType(this string value)
        {
            switch( value )
            {
                case "User":
                    return WebhookSimpleUserDtoType.User;
                case "Robot":
                    return WebhookSimpleUserDtoType.Robot;
                case "DirectoryUser":
                    return WebhookSimpleUserDtoType.DirectoryUser;
                case "DirectoryGroup":
                    return WebhookSimpleUserDtoType.DirectoryGroup;
            }
            return null;
        }
    }
}
