// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace WebClient.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class MachinesDeleteBulk
    {
        /// <summary>
        /// Initializes a new instance of the MachinesDeleteBulk class.
        /// </summary>
        public MachinesDeleteBulk()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MachinesDeleteBulk class.
        /// </summary>
        public MachinesDeleteBulk(IList<long?> machineIds)
        {
            MachineIds = machineIds;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "machineIds")]
        public IList<long?> MachineIds { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (MachineIds == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "MachineIds");
            }
        }
    }
}
