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

    /// <summary>
    /// Entity derived from UserDto. Is shares all the properties of the base
    /// entity except the navigation properties.
    /// </summary>
    public partial class SimpleUserDto
    {
        /// <summary>
        /// Initializes a new instance of the SimpleUserDto class.
        /// </summary>
        public SimpleUserDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SimpleUserDto class.
        /// </summary>
        /// <param name="name">The name of the person for which the user is
        /// created.</param>
        /// <param name="surname">The surname of the person for which the user
        /// is created.</param>
        /// <param name="userName">The name used to login to
        /// Orchestrator.</param>
        /// <param name="domain">The domain from which the user is
        /// imported</param>
        /// <param name="fullName">The full name of the person constructed with
        /// the format Name Surname.</param>
        /// <param name="emailAddress">The e-mail address associated with the
        /// user.</param>
        /// <param name="isEmailConfirmed">States if the email address is valid
        /// or not.</param>
        /// <param name="lastLoginTime">The date and time when the user last
        /// logged in, or null if the user never logged in.</param>
        /// <param name="isActive">States if the user is active or not. An
        /// inactive user cannot login to Orchestrator.</param>
        /// <param name="creationTime">The date and time when the user was
        /// created.</param>
        /// <param name="authenticationSource">The source which authenticated
        /// this user.</param>
        /// <param name="password">The password used during application
        /// login.</param>
        /// <param name="userRoles">The collection of roles associated with the
        /// user.</param>
        /// <param name="rolesList">The collection of role names associated
        /// with the user.</param>
        /// <param name="loginProviders">The collection of entities that can
        /// authenticate the user.</param>
        /// <param name="organizationUnits">The collection of organization
        /// units associated with the user.</param>
        /// <param name="tenantId">The id of the tenant owning the
        /// user.</param>
        /// <param name="tenancyName">The name of the tenant owning the
        /// user.</param>
        /// <param name="tenantDisplayName">The display name of the tenant
        /// owning the user.</param>
        /// <param name="type">The user type. Possible values include: 'User',
        /// 'Robot', 'DirectoryUser', 'DirectoryGroup'</param>
        /// <param name="notificationSubscription">User can choose which
        /// notifications does he want to receive</param>
        public SimpleUserDto(string name = default(string), string surname = default(string), string userName = default(string), string domain = default(string), string fullName = default(string), string emailAddress = default(string), bool? isEmailConfirmed = default(bool?), System.DateTime? lastLoginTime = default(System.DateTime?), bool? isActive = default(bool?), System.DateTime? creationTime = default(System.DateTime?), string authenticationSource = default(string), string password = default(string), IList<UserRoleDto> userRoles = default(IList<UserRoleDto>), IList<string> rolesList = default(IList<string>), IList<string> loginProviders = default(IList<string>), IList<OrganizationUnitDto> organizationUnits = default(IList<OrganizationUnitDto>), int? tenantId = default(int?), string tenancyName = default(string), string tenantDisplayName = default(string), SimpleUserDtoType? type = default(SimpleUserDtoType?), UserNotificationSubscription notificationSubscription = default(UserNotificationSubscription), long? id = default(long?))
        {
            Name = name;
            Surname = surname;
            UserName = userName;
            Domain = domain;
            FullName = fullName;
            EmailAddress = emailAddress;
            IsEmailConfirmed = isEmailConfirmed;
            LastLoginTime = lastLoginTime;
            IsActive = isActive;
            CreationTime = creationTime;
            AuthenticationSource = authenticationSource;
            Password = password;
            UserRoles = userRoles;
            RolesList = rolesList;
            LoginProviders = loginProviders;
            OrganizationUnits = organizationUnits;
            TenantId = tenantId;
            TenancyName = tenancyName;
            TenantDisplayName = tenantDisplayName;
            Type = type;
            NotificationSubscription = notificationSubscription;
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the person for which the user is created.
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the surname of the person for which the user is
        /// created.
        /// </summary>
        [JsonProperty(PropertyName = "Surname")]
        public string Surname { get; set; }

        /// <summary>
        /// Gets or sets the name used to login to Orchestrator.
        /// </summary>
        [JsonProperty(PropertyName = "UserName")]
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the domain from which the user is imported
        /// </summary>
        [JsonProperty(PropertyName = "Domain")]
        public string Domain { get; set; }

        /// <summary>
        /// Gets or sets the full name of the person constructed with the
        /// format Name Surname.
        /// </summary>
        [JsonProperty(PropertyName = "FullName")]
        public string FullName { get; set; }

        /// <summary>
        /// Gets or sets the e-mail address associated with the user.
        /// </summary>
        [JsonProperty(PropertyName = "EmailAddress")]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Gets or sets states if the email address is valid or not.
        /// </summary>
        [JsonProperty(PropertyName = "IsEmailConfirmed")]
        public bool? IsEmailConfirmed { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the user last logged in, or
        /// null if the user never logged in.
        /// </summary>
        [JsonProperty(PropertyName = "LastLoginTime")]
        public System.DateTime? LastLoginTime { get; set; }

        /// <summary>
        /// Gets or sets states if the user is active or not. An inactive user
        /// cannot login to Orchestrator.
        /// </summary>
        [JsonProperty(PropertyName = "IsActive")]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the user was created.
        /// </summary>
        [JsonProperty(PropertyName = "CreationTime")]
        public System.DateTime? CreationTime { get; set; }

        /// <summary>
        /// Gets or sets the source which authenticated this user.
        /// </summary>
        [JsonProperty(PropertyName = "AuthenticationSource")]
        public string AuthenticationSource { get; set; }

        /// <summary>
        /// Gets or sets the password used during application login.
        /// </summary>
        [JsonProperty(PropertyName = "Password")]
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets the collection of roles associated with the user.
        /// </summary>
        [JsonProperty(PropertyName = "UserRoles")]
        public IList<UserRoleDto> UserRoles { get; set; }

        /// <summary>
        /// Gets or sets the collection of role names associated with the user.
        /// </summary>
        [JsonProperty(PropertyName = "RolesList")]
        public IList<string> RolesList { get; set; }

        /// <summary>
        /// Gets or sets the collection of entities that can authenticate the
        /// user.
        /// </summary>
        [JsonProperty(PropertyName = "LoginProviders")]
        public IList<string> LoginProviders { get; set; }

        /// <summary>
        /// Gets or sets the collection of organization units associated with
        /// the user.
        /// </summary>
        [JsonProperty(PropertyName = "OrganizationUnits")]
        public IList<OrganizationUnitDto> OrganizationUnits { get; set; }

        /// <summary>
        /// Gets or sets the id of the tenant owning the user.
        /// </summary>
        [JsonProperty(PropertyName = "TenantId")]
        public int? TenantId { get; set; }

        /// <summary>
        /// Gets or sets the name of the tenant owning the user.
        /// </summary>
        [JsonProperty(PropertyName = "TenancyName")]
        public string TenancyName { get; set; }

        /// <summary>
        /// Gets or sets the display name of the tenant owning the user.
        /// </summary>
        [JsonProperty(PropertyName = "TenantDisplayName")]
        public string TenantDisplayName { get; set; }

        /// <summary>
        /// Gets or sets the user type. Possible values include: 'User',
        /// 'Robot', 'DirectoryUser', 'DirectoryGroup'
        /// </summary>
        [JsonProperty(PropertyName = "Type")]
        public SimpleUserDtoType? Type { get; set; }

        /// <summary>
        /// Gets or sets user can choose which notifications does he want to
        /// receive
        /// </summary>
        [JsonProperty(PropertyName = "NotificationSubscription")]
        public UserNotificationSubscription NotificationSubscription { get; set; }

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
            if (Name != null)
            {
                if (Name.Length > 64)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Name", 64);
                }
                if (Name.Length < 0)
                {
                    throw new ValidationException(ValidationRules.MinLength, "Name", 0);
                }
            }
            if (Surname != null)
            {
                if (Surname.Length > 64)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Surname", 64);
                }
                if (Surname.Length < 0)
                {
                    throw new ValidationException(ValidationRules.MinLength, "Surname", 0);
                }
            }
            if (EmailAddress != null)
            {
                if (EmailAddress.Length > 256)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "EmailAddress", 256);
                }
                if (EmailAddress.Length < 0)
                {
                    throw new ValidationException(ValidationRules.MinLength, "EmailAddress", 0);
                }
            }
            if (OrganizationUnits != null)
            {
                foreach (var element in OrganizationUnits)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
