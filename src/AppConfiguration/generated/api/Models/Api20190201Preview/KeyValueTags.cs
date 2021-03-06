namespace Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20190201Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Extensions;

    /// <summary>
    /// A dictionary of tags that can help identify what a key-value may be applicable for.
    /// </summary>
    public partial class KeyValueTags :
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20190201Preview.IKeyValueTags,
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20190201Preview.IKeyValueTagsInternal
    {

        /// <summary>Creates an new <see cref="KeyValueTags" /> instance.</summary>
        public KeyValueTags()
        {

        }
    }
    /// A dictionary of tags that can help identify what a key-value may be applicable for.
    public partial interface IKeyValueTags :
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IAssociativeArray<string>
    {

    }
    /// A dictionary of tags that can help identify what a key-value may be applicable for.
    internal partial interface IKeyValueTagsInternal

    {

    }
}