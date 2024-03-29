// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace WebClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Encapsulates information needed to change user password
    /// </summary>
    public partial class ChangePasswordDto
    {
        /// <summary>
        /// Initializes a new instance of the ChangePasswordDto class.
        /// </summary>
        public ChangePasswordDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ChangePasswordDto class.
        /// </summary>
        /// <param name="currentPassword">Existing user password</param>
        /// <param name="newPassword">The new user password</param>
        public ChangePasswordDto(string currentPassword = default(string), string newPassword = default(string))
        {
            CurrentPassword = currentPassword;
            NewPassword = newPassword;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets existing user password
        /// </summary>
        [JsonProperty(PropertyName = "CurrentPassword")]
        public string CurrentPassword { get; set; }

        /// <summary>
        /// Gets or sets the new user password
        /// </summary>
        [JsonProperty(PropertyName = "NewPassword")]
        public string NewPassword { get; set; }

    }
}
