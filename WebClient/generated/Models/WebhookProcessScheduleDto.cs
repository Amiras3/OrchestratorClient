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

    public partial class WebhookProcessScheduleDto
    {
        /// <summary>
        /// Initializes a new instance of the WebhookProcessScheduleDto class.
        /// </summary>
        public WebhookProcessScheduleDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WebhookProcessScheduleDto class.
        /// </summary>
        /// <param name="name">The name of the schedule.</param>
        /// <param name="enabled">Specifies if the schedule is active or
        /// not.</param>
        /// <param name="environmentId">The Id of the environment associated
        /// with the schedule.</param>
        /// <param name="environmentName">The name of the environment
        /// associated with the schedule.</param>
        /// <param name="startProcessCron">The start cron expression of the
        /// schedule.</param>
        /// <param name="startStrategy">States which robots from the
        /// environment are being run by the schedule. Possible values include:
        /// 'All', 'Specific', 'RobotCount', 'JobsCount'</param>
        /// <param name="stopStrategy">The way a running process is stopped.
        /// Possible values include: 'SoftStop', 'Kill'</param>
        /// <param name="externalJobKey">The unique identifier of the external
        /// job associated with the jobs generated by this schedule. A key is
        /// generated for each group of jobs triggered by this
        /// schedule.</param>
        /// <param name="timeZoneId">The timezone under which the schedule will
        /// run.</param>
        /// <param name="timeZoneIana">The timezone under which the schedule
        /// will run in Iana Standard.</param>
        /// <param name="useCalendar">Specify whether the schedule uses the
        /// bank holiday calendar</param>
        /// <param name="release">Process details associated with the
        /// schedule</param>
        /// <param name="executorRobots">The collection of specific robots
        /// selected to be targeted by the current schedule. This collection
        /// must be empty if the start strategy is not 0 (specific
        /// robots).</param>
        /// <param name="inputArguments">Input parameters that will be passed
        /// to each job created by this schedule.</param>
        public WebhookProcessScheduleDto(long? id = default(long?), string name = default(string), bool? enabled = default(bool?), string environmentId = default(string), string environmentName = default(string), string startProcessCron = default(string), WebhookProcessScheduleDtoStartStrategy? startStrategy = default(WebhookProcessScheduleDtoStartStrategy?), WebhookProcessScheduleDtoStopStrategy? stopStrategy = default(WebhookProcessScheduleDtoStopStrategy?), string externalJobKey = default(string), string timeZoneId = default(string), string timeZoneIana = default(string), bool? useCalendar = default(bool?), WebhookSimpleReleaseDto release = default(WebhookSimpleReleaseDto), IList<WebhookSimpleRobotDto> executorRobots = default(IList<WebhookSimpleRobotDto>), object inputArguments = default(object))
        {
            Id = id;
            Name = name;
            Enabled = enabled;
            EnvironmentId = environmentId;
            EnvironmentName = environmentName;
            StartProcessCron = startProcessCron;
            StartStrategy = startStrategy;
            StopStrategy = stopStrategy;
            ExternalJobKey = externalJobKey;
            TimeZoneId = timeZoneId;
            TimeZoneIana = timeZoneIana;
            UseCalendar = useCalendar;
            Release = release;
            ExecutorRobots = executorRobots;
            InputArguments = inputArguments;
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
        /// Gets the name of the schedule.
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets specifies if the schedule is active or not.
        /// </summary>
        [JsonProperty(PropertyName = "Enabled")]
        public bool? Enabled { get; private set; }

        /// <summary>
        /// Gets the Id of the environment associated with the schedule.
        /// </summary>
        [JsonProperty(PropertyName = "EnvironmentId")]
        public string EnvironmentId { get; private set; }

        /// <summary>
        /// Gets the name of the environment associated with the schedule.
        /// </summary>
        [JsonProperty(PropertyName = "EnvironmentName")]
        public string EnvironmentName { get; private set; }

        /// <summary>
        /// Gets the start cron expression of the schedule.
        /// </summary>
        [JsonProperty(PropertyName = "StartProcessCron")]
        public string StartProcessCron { get; private set; }

        /// <summary>
        /// Gets states which robots from the environment are being run by the
        /// schedule. Possible values include: 'All', 'Specific', 'RobotCount',
        /// 'JobsCount'
        /// </summary>
        [JsonProperty(PropertyName = "StartStrategy")]
        public WebhookProcessScheduleDtoStartStrategy? StartStrategy { get; private set; }

        /// <summary>
        /// Gets the way a running process is stopped. Possible values include:
        /// 'SoftStop', 'Kill'
        /// </summary>
        [JsonProperty(PropertyName = "StopStrategy")]
        public WebhookProcessScheduleDtoStopStrategy? StopStrategy { get; private set; }

        /// <summary>
        /// Gets the unique identifier of the external job associated with the
        /// jobs generated by this schedule. A key is generated for each group
        /// of jobs triggered by this schedule.
        /// </summary>
        [JsonProperty(PropertyName = "ExternalJobKey")]
        public string ExternalJobKey { get; private set; }

        /// <summary>
        /// Gets the timezone under which the schedule will run.
        /// </summary>
        [JsonProperty(PropertyName = "TimeZoneId")]
        public string TimeZoneId { get; private set; }

        /// <summary>
        /// Gets the timezone under which the schedule will run in Iana
        /// Standard.
        /// </summary>
        [JsonProperty(PropertyName = "TimeZoneIana")]
        public string TimeZoneIana { get; private set; }

        /// <summary>
        /// Gets specify whether the schedule uses the bank holiday calendar
        /// </summary>
        [JsonProperty(PropertyName = "UseCalendar")]
        public bool? UseCalendar { get; private set; }

        /// <summary>
        /// Gets process details associated with the schedule
        /// </summary>
        [JsonProperty(PropertyName = "Release")]
        public WebhookSimpleReleaseDto Release { get; private set; }

        /// <summary>
        /// Gets the collection of specific robots selected to be targeted by
        /// the current schedule. This collection must be empty if the start
        /// strategy is not 0 (specific robots).
        /// </summary>
        [JsonProperty(PropertyName = "ExecutorRobots")]
        public IList<WebhookSimpleRobotDto> ExecutorRobots { get; private set; }

        /// <summary>
        /// Gets input parameters that will be passed to each job created by
        /// this schedule.
        /// </summary>
        [JsonProperty(PropertyName = "InputArguments")]
        public object InputArguments { get; private set; }

    }
}
