/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;
using OpenAPIClientUtils = Org.OpenAPITools.Client.ClientUtils;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// HasOnlyReadOnly
    /// </summary>
    [DataContract(Name = "hasOnlyReadOnly")]
    public partial class HasOnlyReadOnly : IEquatable<HasOnlyReadOnly>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HasOnlyReadOnly" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public HasOnlyReadOnly()
        {
            this.AdditionalProperites = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets Bar
        /// </summary>
        [DataMember(Name = "bar", EmitDefaultValue = false)]
        public string Bar { get; private set; }

        /// <summary>
        /// Gets or Sets Foo
        /// </summary>
        [DataMember(Name = "foo", EmitDefaultValue = false)]
        public string Foo { get; private set; }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperites { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HasOnlyReadOnly {\n");
            sb.Append("  Bar: ").Append(Bar).Append("\n");
            sb.Append("  Foo: ").Append(Foo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return OpenAPIClientUtils.compareLogic.Compare(this, input as HasOnlyReadOnly).AreEqual;
        }

        /// <summary>
        /// Returns true if HasOnlyReadOnly instances are equal
        /// </summary>
        /// <param name="input">Instance of HasOnlyReadOnly to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HasOnlyReadOnly input)
        {
            return OpenAPIClientUtils.compareLogic.Compare(this, input).AreEqual;
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Bar != null)
                    hashCode = hashCode * 59 + this.Bar.GetHashCode();
                if (this.Foo != null)
                    hashCode = hashCode * 59 + this.Foo.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
