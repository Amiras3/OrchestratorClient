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
    /// Stores information about a comment posted by an Orchestrator user on a
    /// queue item.
    /// </summary>
    public partial class QueueItemCommentDto
    {
        /// <summary>
        /// Initializes a new instance of the QueueItemCommentDto class.
        /// </summary>
        public QueueItemCommentDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the QueueItemCommentDto class.
        /// </summary>
        /// <param name="text">The comment body.</param>
        /// <param name="queueItemId">The Id of a Queue Item that the current
        /// item is connected to.</param>
        /// <param name="creationTime">DEPRECATED. The date and time when the
        /// comment was created.</param>
        /// <param name="userId">The id of the User that authored the
        /// comment.</param>
        /// <param name="userName">The name of the User that authored the
        /// comment.</param>
        public QueueItemCommentDto(string text, long? queueItemId = default(long?), System.DateTime? creationTime = default(System.DateTime?), long? userId = default(long?), string userName = default(string), long? id = default(long?))
        {
            Text = text;
            QueueItemId = queueItemId;
            CreationTime = creationTime;
            UserId = userId;
            UserName = userName;
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the comment body.
        /// </summary>
        [JsonProperty(PropertyName = "Text")]
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets the Id of a Queue Item that the current item is
        /// connected to.
        /// </summary>
        [JsonProperty(PropertyName = "QueueItemId")]
        public long? QueueItemId { get; set; }

        /// <summary>
        /// Gets or sets DEPRECATED. The date and time when the comment was
        /// created.
        /// </summary>
        [JsonProperty(PropertyName = "CreationTime")]
        [System.Obsolete("This property is deprecated. Please do not use it any longer.")]
        public System.DateTime? CreationTime { get; set; }

        /// <summary>
        /// Gets or sets the id of the User that authored the comment.
        /// </summary>
        [JsonProperty(PropertyName = "UserId")]
        public long? UserId { get; set; }

        /// <summary>
        /// Gets or sets the name of the User that authored the comment.
        /// </summary>
        [JsonProperty(PropertyName = "UserName")]
        public string UserName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public long? Id { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Text == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Text");
            }
            if (Text != null)
            {
                if (Text.Length > 512)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Text", 512);
                }
                if (Text.Length < 0)
                {
                    throw new ValidationException(ValidationRules.MinLength, "Text", 0);
                }
            }
        }
    }
}
