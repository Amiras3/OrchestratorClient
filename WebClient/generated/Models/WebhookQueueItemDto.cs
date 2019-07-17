// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace WebClient.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class WebhookQueueItemDto
    {
        /// <summary>
        /// Initializes a new instance of the WebhookQueueItemDto class.
        /// </summary>
        public WebhookQueueItemDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WebhookQueueItemDto class.
        /// </summary>
        /// <param name="key">The unique identifier of a queue item.</param>
        /// <param name="reference">An optional, user-specified value for queue
        /// item identification.</param>
        /// <param name="queueDefinitionId">The Id of the parent queue.</param>
        /// <param name="status">The processing state of the item. Possible
        /// values include: 'New', 'InProgress', 'Failed', 'Successful',
        /// 'Abandoned', 'Retried', 'Deleted'</param>
        /// <param name="reviewStatus">The review state of the item -
        /// applicable only for failed items. Possible values include: 'None',
        /// 'InReview', 'Verified', 'Retried'</param>
        /// <param name="processingException">Stores the actual processing
        /// exception, if any.</param>
        /// <param name="dueDate">The latest date and time at which the item
        /// should be processed. If empty the item can be processed at any
        /// given time.</param>
        /// <param name="priority">Sets the processing importance for a given
        /// item. Possible values include: 'High', 'Normal', 'Low'</param>
        /// <param name="creationTime">The date and time when the item was
        /// created.</param>
        /// <param name="deferDate">The earliest date and time at which the
        /// item is available for processing. If empty the item can be
        /// processed as soon as possible.</param>
        /// <param name="startProcessing">The date and time at which the item
        /// processing started. This is null if the item was not
        /// processed.</param>
        /// <param name="endProcessing">The date and time at which the item
        /// processing ended. This is null if the item was not
        /// processed.</param>
        /// <param name="secondsInPreviousAttempts">The number of seconds that
        /// the last failed processing lasted.</param>
        /// <param name="ancestorId">The Id of an ancestor item connected to
        /// the current item.</param>
        /// <param name="retryNumber">The number of times this work item has
        /// been processed.
        /// &lt;para /&gt;This can be higher than 0 only if MaxRetried number
        /// is set and the item processing failed at least once with
        /// ApplicationException.</param>
        /// <param name="progress">String field which is used to keep track of
        /// the business flow progress.</param>
        /// <param name="reviewerUserId">The UserId of the Reviewer, if
        /// any.</param>
        /// <param name="robot">The robot that has processed the item, if
        /// any.</param>
        /// <param name="reviewerUser">Stores the actual reviewer user, if
        /// any.</param>
        /// <param name="specificContent">A collection of key value pairs
        /// containing custom data configured in the Add Queue Item activity,
        /// in UiPath Studio.</param>
        /// <param name="output">A collection of key value pairs containing
        /// custom data resulted after successful processing.</param>
        public WebhookQueueItemDto(long? id = default(long?), System.Guid? key = default(System.Guid?), string reference = default(string), long? queueDefinitionId = default(long?), WebhookQueueItemDtoStatus? status = default(WebhookQueueItemDtoStatus?), WebhookQueueItemDtoReviewStatus? reviewStatus = default(WebhookQueueItemDtoReviewStatus?), WebhookProcessingExceptionDto processingException = default(WebhookProcessingExceptionDto), System.DateTime? dueDate = default(System.DateTime?), WebhookQueueItemDtoPriority? priority = default(WebhookQueueItemDtoPriority?), System.DateTime? creationTime = default(System.DateTime?), System.DateTime? deferDate = default(System.DateTime?), System.DateTime? startProcessing = default(System.DateTime?), System.DateTime? endProcessing = default(System.DateTime?), int? secondsInPreviousAttempts = default(int?), long? ancestorId = default(long?), int? retryNumber = default(int?), string progress = default(string), long? reviewerUserId = default(long?), WebhookRobotDto robot = default(WebhookRobotDto), WebhookSimpleUserDto reviewerUser = default(WebhookSimpleUserDto), IDictionary<string, object> specificContent = default(IDictionary<string, object>), IDictionary<string, object> output = default(IDictionary<string, object>))
        {
            Id = id;
            Key = key;
            Reference = reference;
            QueueDefinitionId = queueDefinitionId;
            Status = status;
            ReviewStatus = reviewStatus;
            ProcessingException = processingException;
            DueDate = dueDate;
            Priority = priority;
            CreationTime = creationTime;
            DeferDate = deferDate;
            StartProcessing = startProcessing;
            EndProcessing = endProcessing;
            SecondsInPreviousAttempts = secondsInPreviousAttempts;
            AncestorId = ancestorId;
            RetryNumber = retryNumber;
            Progress = progress;
            ReviewerUserId = reviewerUserId;
            Robot = robot;
            ReviewerUser = reviewerUser;
            SpecificContent = specificContent;
            Output = output;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public long? Id { get; private set; }

        /// <summary>
        /// Gets the unique identifier of a queue item.
        /// </summary>
        [JsonProperty(PropertyName = "Key")]
        public System.Guid? Key { get; private set; }

        /// <summary>
        /// Gets an optional, user-specified value for queue item
        /// identification.
        /// </summary>
        [JsonProperty(PropertyName = "Reference")]
        public string Reference { get; private set; }

        /// <summary>
        /// Gets the Id of the parent queue.
        /// </summary>
        [JsonProperty(PropertyName = "QueueDefinitionId")]
        public long? QueueDefinitionId { get; private set; }

        /// <summary>
        /// Gets the processing state of the item. Possible values include:
        /// 'New', 'InProgress', 'Failed', 'Successful', 'Abandoned',
        /// 'Retried', 'Deleted'
        /// </summary>
        [JsonProperty(PropertyName = "Status")]
        public WebhookQueueItemDtoStatus? Status { get; private set; }

        /// <summary>
        /// Gets the review state of the item - applicable only for failed
        /// items. Possible values include: 'None', 'InReview', 'Verified',
        /// 'Retried'
        /// </summary>
        [JsonProperty(PropertyName = "ReviewStatus")]
        public WebhookQueueItemDtoReviewStatus? ReviewStatus { get; private set; }

        /// <summary>
        /// Gets stores the actual processing exception, if any.
        /// </summary>
        [JsonProperty(PropertyName = "ProcessingException")]
        public WebhookProcessingExceptionDto ProcessingException { get; private set; }

        /// <summary>
        /// Gets the latest date and time at which the item should be
        /// processed. If empty the item can be processed at any given time.
        /// </summary>
        [JsonProperty(PropertyName = "DueDate")]
        public System.DateTime? DueDate { get; private set; }

        /// <summary>
        /// Gets sets the processing importance for a given item. Possible
        /// values include: 'High', 'Normal', 'Low'
        /// </summary>
        [JsonProperty(PropertyName = "Priority")]
        public WebhookQueueItemDtoPriority? Priority { get; private set; }

        /// <summary>
        /// Gets the date and time when the item was created.
        /// </summary>
        [JsonProperty(PropertyName = "CreationTime")]
        public System.DateTime? CreationTime { get; private set; }

        /// <summary>
        /// Gets the earliest date and time at which the item is available for
        /// processing. If empty the item can be processed as soon as possible.
        /// </summary>
        [JsonProperty(PropertyName = "DeferDate")]
        public System.DateTime? DeferDate { get; private set; }

        /// <summary>
        /// Gets the date and time at which the item processing started. This
        /// is null if the item was not processed.
        /// </summary>
        [JsonProperty(PropertyName = "StartProcessing")]
        public System.DateTime? StartProcessing { get; private set; }

        /// <summary>
        /// Gets the date and time at which the item processing ended. This is
        /// null if the item was not processed.
        /// </summary>
        [JsonProperty(PropertyName = "EndProcessing")]
        public System.DateTime? EndProcessing { get; private set; }

        /// <summary>
        /// Gets the number of seconds that the last failed processing lasted.
        /// </summary>
        [JsonProperty(PropertyName = "SecondsInPreviousAttempts")]
        public int? SecondsInPreviousAttempts { get; private set; }

        /// <summary>
        /// Gets the Id of an ancestor item connected to the current item.
        /// </summary>
        [JsonProperty(PropertyName = "AncestorId")]
        public long? AncestorId { get; private set; }

        /// <summary>
        /// Gets the number of times this work item has been processed.
        /// &amp;lt;para /&amp;gt;This can be higher than 0 only if MaxRetried
        /// number is set and the item processing failed at least once with
        /// ApplicationException.
        /// </summary>
        [JsonProperty(PropertyName = "RetryNumber")]
        public int? RetryNumber { get; private set; }

        /// <summary>
        /// Gets string field which is used to keep track of the business flow
        /// progress.
        /// </summary>
        [JsonProperty(PropertyName = "Progress")]
        public string Progress { get; private set; }

        /// <summary>
        /// Gets the UserId of the Reviewer, if any.
        /// </summary>
        [JsonProperty(PropertyName = "ReviewerUserId")]
        public long? ReviewerUserId { get; private set; }

        /// <summary>
        /// Gets the robot that has processed the item, if any.
        /// </summary>
        [JsonProperty(PropertyName = "Robot")]
        public WebhookRobotDto Robot { get; private set; }

        /// <summary>
        /// Gets stores the actual reviewer user, if any.
        /// </summary>
        [JsonProperty(PropertyName = "ReviewerUser")]
        public WebhookSimpleUserDto ReviewerUser { get; private set; }

        /// <summary>
        /// Gets a collection of key value pairs containing custom data
        /// configured in the Add Queue Item activity, in UiPath Studio.
        /// </summary>
        [JsonProperty(PropertyName = "SpecificContent")]
        public IDictionary<string, object> SpecificContent { get; private set; }

        /// <summary>
        /// Gets a collection of key value pairs containing custom data
        /// resulted after successful processing.
        /// </summary>
        [JsonProperty(PropertyName = "Output")]
        public IDictionary<string, object> Output { get; private set; }

    }
}
