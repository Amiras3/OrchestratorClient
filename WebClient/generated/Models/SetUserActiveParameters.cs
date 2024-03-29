// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace WebClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class SetUserActiveParameters
    {
        /// <summary>
        /// Initializes a new instance of the SetUserActiveParameters class.
        /// </summary>
        public SetUserActiveParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SetUserActiveParameters class.
        /// </summary>
        public SetUserActiveParameters(bool active)
        {
            Active = active;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "active")]
        public bool Active { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}
