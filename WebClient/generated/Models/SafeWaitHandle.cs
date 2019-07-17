// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace WebClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class SafeWaitHandle
    {
        /// <summary>
        /// Initializes a new instance of the SafeWaitHandle class.
        /// </summary>
        public SafeWaitHandle()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SafeWaitHandle class.
        /// </summary>
        public SafeWaitHandle(bool? isInvalid = default(bool?), bool? isClosed = default(bool?))
        {
            IsInvalid = isInvalid;
            IsClosed = isClosed;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isInvalid")]
        public bool? IsInvalid { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isClosed")]
        public bool? IsClosed { get; private set; }

    }
}
