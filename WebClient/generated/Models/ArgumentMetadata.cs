// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace WebClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ArgumentMetadata
    {
        /// <summary>
        /// Initializes a new instance of the ArgumentMetadata class.
        /// </summary>
        public ArgumentMetadata()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ArgumentMetadata class.
        /// </summary>
        public ArgumentMetadata(string input = default(string), string output = default(string))
        {
            Input = input;
            Output = output;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Input")]
        public string Input { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Output")]
        public string Output { get; set; }

    }
}
