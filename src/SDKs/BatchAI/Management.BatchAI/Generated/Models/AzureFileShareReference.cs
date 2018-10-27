// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.BatchAI.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Details of the Azure File Share to mount on the cluster.
    /// </summary>
    public partial class AzureFileShareReference
    {
        /// <summary>
        /// Initializes a new instance of the AzureFileShareReference class.
        /// </summary>
        public AzureFileShareReference()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AzureFileShareReference class.
        /// </summary>
        /// <param name="accountName">Name of the storage account.</param>
        /// <param name="azureFileUrl">URL to access the Azure File.</param>
        /// <param name="credentials">Information of the Azure File
        /// credentials.</param>
        /// <param name="relativeMountPath">Specifies the relative path on the
        /// compute node where the Azure file share will be mounted.</param>
        /// <param name="fileMode">Specifies the file mode.</param>
        /// <param name="directoryMode">Specifies the directory Mode.</param>
        public AzureFileShareReference(string accountName, string azureFileUrl, AzureStorageCredentialsInfo credentials, string relativeMountPath, string fileMode = default(string), string directoryMode = default(string))
        {
            AccountName = accountName;
            AzureFileUrl = azureFileUrl;
            Credentials = credentials;
            RelativeMountPath = relativeMountPath;
            FileMode = fileMode;
            DirectoryMode = directoryMode;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of the storage account.
        /// </summary>
        [JsonProperty(PropertyName = "accountName")]
        public string AccountName { get; set; }

        /// <summary>
        /// Gets or sets URL to access the Azure File.
        /// </summary>
        [JsonProperty(PropertyName = "azureFileUrl")]
        public string AzureFileUrl { get; set; }

        /// <summary>
        /// Gets or sets information of the Azure File credentials.
        /// </summary>
        [JsonProperty(PropertyName = "credentials")]
        public AzureStorageCredentialsInfo Credentials { get; set; }

        /// <summary>
        /// Gets or sets specifies the relative path on the compute node where
        /// the Azure file share will be mounted.
        /// </summary>
        /// <remarks>
        /// Note that all cluster level file shares will be mounted under
        /// $AZ_BATCHAI_MOUNT_ROOT location and all job level file shares will
        /// be mounted under $AZ_BATCHAI_JOB_MOUNT_ROOT.
        /// </remarks>
        [JsonProperty(PropertyName = "relativeMountPath")]
        public string RelativeMountPath { get; set; }

        /// <summary>
        /// Gets or sets specifies the file mode.
        /// </summary>
        /// <remarks>
        /// Default value is 0777. Valid only if OS is linux.
        /// </remarks>
        [JsonProperty(PropertyName = "fileMode")]
        public string FileMode { get; set; }

        /// <summary>
        /// Gets or sets specifies the directory Mode.
        /// </summary>
        /// <remarks>
        /// Default value is 0777. Valid only if OS is linux.
        /// </remarks>
        [JsonProperty(PropertyName = "directoryMode")]
        public string DirectoryMode { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (AccountName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AccountName");
            }
            if (AzureFileUrl == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AzureFileUrl");
            }
            if (Credentials == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Credentials");
            }
            if (RelativeMountPath == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RelativeMountPath");
            }
            if (Credentials != null)
            {
                Credentials.Validate();
            }
        }
    }
}