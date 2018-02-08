// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Commands.Kubernetes.Generated.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Profile for Windows VMs in the container service cluster.
    /// </summary>
    public partial class ContainerServiceWindowsProfile
    {
        /// <summary>
        /// Initializes a new instance of the ContainerServiceWindowsProfile
        /// class.
        /// </summary>
        public ContainerServiceWindowsProfile()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ContainerServiceWindowsProfile
        /// class.
        /// </summary>
        /// <param name="adminUsername">The administrator username to use for
        /// Windows VMs.</param>
        /// <param name="adminPassword">The administrator password to use for
        /// Windows VMs.</param>
        public ContainerServiceWindowsProfile(string adminUsername, string adminPassword)
        {
            AdminUsername = adminUsername;
            AdminPassword = adminPassword;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the administrator username to use for Windows VMs.
        /// </summary>
        [JsonProperty(PropertyName = "adminUsername")]
        public string AdminUsername { get; set; }

        /// <summary>
        /// Gets or sets the administrator password to use for Windows VMs.
        /// </summary>
        [JsonProperty(PropertyName = "adminPassword")]
        public string AdminPassword { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (AdminUsername == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AdminUsername");
            }
            if (AdminPassword == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AdminPassword");
            }
            if (AdminUsername != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(AdminUsername, "^[a-zA-Z0-9]+([._]?[a-zA-Z0-9]+)*$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "AdminUsername", "^[a-zA-Z0-9]+([._]?[a-zA-Z0-9]+)*$");
                }
            }
            if (AdminPassword != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(AdminPassword, "^(?=.*[a-z])(?=.*[A-Z])(?=.*[!@#$%\\^&\\*\\(\\)])[a-zA-Z\\d!@#$%\\^&\\*\\(\\)]{12,123}$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "AdminPassword", "^(?=.*[a-z])(?=.*[A-Z])(?=.*[!@#$%\\^&\\*\\(\\)])[a-zA-Z\\d!@#$%\\^&\\*\\(\\)]{12,123}$");
                }
            }
        }
    }
}
