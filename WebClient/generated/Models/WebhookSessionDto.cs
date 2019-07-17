// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace WebClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class WebhookSessionDto
    {
        /// <summary>
        /// Initializes a new instance of the WebhookSessionDto class.
        /// </summary>
        public WebhookSessionDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WebhookSessionDto class.
        /// </summary>
        /// <param name="state">Possible values include: 'Available', 'Busy',
        /// 'Disconnected', 'Unknown'</param>
        /// <param name="licenseErrorCode">Possible values include:
        /// 'NoLicense', 'LicenseExpired', 'LicenseUnregistered',
        /// 'NoAvailableLicenses', 'NotEnoughAvailableSlots',
        /// 'NotEnoughRuntimeLicenses', 'LicenseIsAlreadyInUse',
        /// 'InvalidRequest', 'SlotsExceedLicenseLimit',
        /// 'RuntimeDisabled'</param>
        public WebhookSessionDto(long? sessionId = default(long?), long? robotId = default(long?), string hostMachineName = default(string), WebhookSessionDtoState? state = default(WebhookSessionDtoState?), System.DateTime? reportingTime = default(System.DateTime?), bool? isUnresponsive = default(bool?), WebhookSessionDtoLicenseErrorCode? licenseErrorCode = default(WebhookSessionDtoLicenseErrorCode?))
        {
            SessionId = sessionId;
            RobotId = robotId;
            HostMachineName = hostMachineName;
            State = state;
            ReportingTime = reportingTime;
            IsUnresponsive = isUnresponsive;
            LicenseErrorCode = licenseErrorCode;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SessionId")]
        public long? SessionId { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "RobotId")]
        public long? RobotId { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "HostMachineName")]
        public string HostMachineName { get; private set; }

        /// <summary>
        /// Gets possible values include: 'Available', 'Busy', 'Disconnected',
        /// 'Unknown'
        /// </summary>
        [JsonProperty(PropertyName = "State")]
        public WebhookSessionDtoState? State { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ReportingTime")]
        public System.DateTime? ReportingTime { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsUnresponsive")]
        public bool? IsUnresponsive { get; private set; }

        /// <summary>
        /// Gets possible values include: 'NoLicense', 'LicenseExpired',
        /// 'LicenseUnregistered', 'NoAvailableLicenses',
        /// 'NotEnoughAvailableSlots', 'NotEnoughRuntimeLicenses',
        /// 'LicenseIsAlreadyInUse', 'InvalidRequest',
        /// 'SlotsExceedLicenseLimit', 'RuntimeDisabled'
        /// </summary>
        [JsonProperty(PropertyName = "LicenseErrorCode")]
        public WebhookSessionDtoLicenseErrorCode? LicenseErrorCode { get; private set; }

    }
}
