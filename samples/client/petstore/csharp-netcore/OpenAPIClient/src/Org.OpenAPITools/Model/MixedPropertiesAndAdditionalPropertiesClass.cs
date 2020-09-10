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
using OpenAPIAdditionalPropertiesConverter = Org.OpenAPITools.Client.OpenAPIAdditionalPropertiesConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// MixedPropertiesAndAdditionalPropertiesClass
    /// </summary>
    [DataContract(Name = "MixedPropertiesAndAdditionalPropertiesClass")]
    public partial class MixedPropertiesAndAdditionalPropertiesClass : IEquatable<MixedPropertiesAndAdditionalPropertiesClass>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MixedPropertiesAndAdditionalPropertiesClass" /> class.
        /// </summary>
        /// <param name="uuid">uuid.</param>
        /// <param name="dateTime">dateTime.</param>
        /// <param name="map">map.</param>
        public MixedPropertiesAndAdditionalPropertiesClass(Guid uuid = default(Guid), DateTime dateTime = default(DateTime), Dictionary<string, Animal> map = default(Dictionary<string, Animal>))
        {
            this.Uuid = uuid;
            this.DateTime = dateTime;
            this.Map = map;
        }

        /// <summary>
        /// Gets or Sets Uuid
        /// </summary>
        [DataMember(Name = "uuid", EmitDefaultValue = false)]
        public Guid Uuid { get; set; }

        /// <summary>
        /// Gets or Sets DateTime
        /// </summary>
        [DataMember(Name = "dateTime", EmitDefaultValue = false)]
        public DateTime DateTime { get; set; }

        /// <summary>
        /// Gets or Sets Map
        /// </summary>
        [DataMember(Name = "map", EmitDefaultValue = false)]
        public Dictionary<string, Animal> Map { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalProperties
        /// </summary>
        [JsonConverter(typeof(OpenAPIAdditionalPropertiesConverter))]
        public Dictionary<string, dynamic> AdditionalProperites { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MixedPropertiesAndAdditionalPropertiesClass {\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  DateTime: ").Append(DateTime).Append("\n");
            sb.Append("  Map: ").Append(Map).Append("\n");
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
            return OpenAPIClientUtils.compareLogic.Compare(this, input as MixedPropertiesAndAdditionalPropertiesClass).AreEqual;
        }

        /// <summary>
        /// Returns true if MixedPropertiesAndAdditionalPropertiesClass instances are equal
        /// </summary>
        /// <param name="input">Instance of MixedPropertiesAndAdditionalPropertiesClass to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MixedPropertiesAndAdditionalPropertiesClass input)
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
                if (this.Uuid != null)
                    hashCode = hashCode * 59 + this.Uuid.GetHashCode();
                if (this.DateTime != null)
                    hashCode = hashCode * 59 + this.DateTime.GetHashCode();
                if (this.Map != null)
                    hashCode = hashCode * 59 + this.Map.GetHashCode();
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
