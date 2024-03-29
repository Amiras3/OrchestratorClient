// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace WebClient.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A robot asset stores the information of a per robot asset for a
    /// specific robot, without specifying the robot.
    /// </summary>
    public partial class RobotAssetDto
    {
        /// <summary>
        /// Initializes a new instance of the RobotAssetDto class.
        /// </summary>
        public RobotAssetDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RobotAssetDto class.
        /// </summary>
        /// <param name="name">The asset name.</param>
        /// <param name="valueType">Defines the type of value stored by the
        /// asset. Possible values include: 'DBConnectionString',
        /// 'HttpConnectionString', 'Text', 'Bool', 'Integer', 'Credential',
        /// 'WindowsCredential', 'KeyValueList'</param>
        /// <param name="stringValue">The value of the asset when the value
        /// type is Text. Empty when the value type is not Text.</param>
        /// <param name="boolValue">The value of the asset when the value type
        /// is Bool. False when the value type is not Bool.</param>
        /// <param name="intValue">The value of the asset when the value type
        /// is Integer. 0 when the value type is not Integer.</param>
        /// <param name="credentialUsername">The user name when the value type
        /// is Credential. Empty when the value type is not Credential.</param>
        /// <param name="credentialPassword">The password when the value type
        /// is Credential. Empty when the value type is not Credential.</param>
        public RobotAssetDto(string name, RobotAssetDtoValueType? valueType = default(RobotAssetDtoValueType?), string stringValue = default(string), bool? boolValue = default(bool?), int? intValue = default(int?), string credentialUsername = default(string), string credentialPassword = default(string))
        {
            Name = name;
            ValueType = valueType;
            StringValue = stringValue;
            BoolValue = boolValue;
            IntValue = intValue;
            CredentialUsername = credentialUsername;
            CredentialPassword = credentialPassword;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the asset name.
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets defines the type of value stored by the asset.
        /// Possible values include: 'DBConnectionString',
        /// 'HttpConnectionString', 'Text', 'Bool', 'Integer', 'Credential',
        /// 'WindowsCredential', 'KeyValueList'
        /// </summary>
        [JsonProperty(PropertyName = "ValueType")]
        public RobotAssetDtoValueType? ValueType { get; set; }

        /// <summary>
        /// Gets or sets the value of the asset when the value type is Text.
        /// Empty when the value type is not Text.
        /// </summary>
        [JsonProperty(PropertyName = "StringValue")]
        public string StringValue { get; set; }

        /// <summary>
        /// Gets or sets the value of the asset when the value type is Bool.
        /// False when the value type is not Bool.
        /// </summary>
        [JsonProperty(PropertyName = "BoolValue")]
        public bool? BoolValue { get; set; }

        /// <summary>
        /// Gets or sets the value of the asset when the value type is Integer.
        /// 0 when the value type is not Integer.
        /// </summary>
        [JsonProperty(PropertyName = "IntValue")]
        public int? IntValue { get; set; }

        /// <summary>
        /// Gets or sets the user name when the value type is Credential. Empty
        /// when the value type is not Credential.
        /// </summary>
        [JsonProperty(PropertyName = "CredentialUsername")]
        public string CredentialUsername { get; set; }

        /// <summary>
        /// Gets or sets the password when the value type is Credential. Empty
        /// when the value type is not Credential.
        /// </summary>
        [JsonProperty(PropertyName = "CredentialPassword")]
        public string CredentialPassword { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
        }
    }
}
