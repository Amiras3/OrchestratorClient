// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace WebClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class KeyValuePairStringString
    {
        /// <summary>
        /// Initializes a new instance of the KeyValuePairStringString class.
        /// </summary>
        public KeyValuePairStringString()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the KeyValuePairStringString class.
        /// </summary>
        public KeyValuePairStringString(string key = default(string), string value = default(string))
        {
            Key = key;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Key")]
        public string Key { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Value")]
        public string Value { get; private set; }

    }
}
