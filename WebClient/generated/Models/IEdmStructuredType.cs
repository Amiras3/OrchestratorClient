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

    public partial class IEdmStructuredType
    {
        /// <summary>
        /// Initializes a new instance of the IEdmStructuredType class.
        /// </summary>
        public IEdmStructuredType()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IEdmStructuredType class.
        /// </summary>
        /// <param name="typeKind">Possible values include: 'None',
        /// 'Primitive', 'Entity', 'Complex', 'Collection', 'EntityReference',
        /// 'Enum', 'TypeDefinition', 'Untyped', 'Path'</param>
        public IEdmStructuredType(bool? isAbstract = default(bool?), bool? isOpen = default(bool?), IEdmStructuredType baseType = default(IEdmStructuredType), IList<IEdmProperty> declaredProperties = default(IList<IEdmProperty>), IEdmStructuredTypeTypeKind? typeKind = default(IEdmStructuredTypeTypeKind?))
        {
            IsAbstract = isAbstract;
            IsOpen = isOpen;
            BaseType = baseType;
            DeclaredProperties = declaredProperties;
            TypeKind = typeKind;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsAbstract")]
        public bool? IsAbstract { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsOpen")]
        public bool? IsOpen { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "BaseType")]
        public IEdmStructuredType BaseType { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DeclaredProperties")]
        public IList<IEdmProperty> DeclaredProperties { get; private set; }

        /// <summary>
        /// Gets possible values include: 'None', 'Primitive', 'Entity',
        /// 'Complex', 'Collection', 'EntityReference', 'Enum',
        /// 'TypeDefinition', 'Untyped', 'Path'
        /// </summary>
        [JsonProperty(PropertyName = "TypeKind")]
        public IEdmStructuredTypeTypeKind? TypeKind { get; private set; }

    }
}
