// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace WebClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class RemoveRobotParameters
    {
        /// <summary>
        /// Initializes a new instance of the RemoveRobotParameters class.
        /// </summary>
        public RemoveRobotParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RemoveRobotParameters class.
        /// </summary>
        public RemoveRobotParameters(string robotId = default(string))
        {
            RobotId = robotId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "robotId")]
        public string RobotId { get; set; }

    }
}
