// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace WebClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class TenantLicenseDto
    {
        /// <summary>
        /// Initializes a new instance of the TenantLicenseDto class.
        /// </summary>
        public TenantLicenseDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TenantLicenseDto class.
        /// </summary>
        /// <param name="hostLicenseId">The host license Id.</param>
        /// <param name="creationTime">The date it was uploaded.</param>
        /// <param name="code">The license code.</param>
        /// <param name="allowed">Contains the number of allowed licenses for
        /// each type</param>
        public TenantLicenseDto(long? hostLicenseId = default(long?), System.DateTime? creationTime = default(System.DateTime?), string code = default(string), LicenseFields allowed = default(LicenseFields), long? id = default(long?))
        {
            HostLicenseId = hostLicenseId;
            CreationTime = creationTime;
            Code = code;
            Allowed = allowed;
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the host license Id.
        /// </summary>
        [JsonProperty(PropertyName = "HostLicenseId")]
        public long? HostLicenseId { get; set; }

        /// <summary>
        /// Gets or sets the date it was uploaded.
        /// </summary>
        [JsonProperty(PropertyName = "CreationTime")]
        public System.DateTime? CreationTime { get; set; }

        /// <summary>
        /// Gets or sets the license code.
        /// </summary>
        [JsonProperty(PropertyName = "Code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets contains the number of allowed licenses for each type
        /// </summary>
        [JsonProperty(PropertyName = "Allowed")]
        public LicenseFields Allowed { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public long? Id { get; set; }

    }
}
