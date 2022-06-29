/* 
 * API Rejestr WL
 *
 * Rejestr Podatników VAT
 *
 * OpenAPI spec version: 1.6.0
 * Contact: WykazPodatnikow@mf.gov.pl
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = MFApiService.Client.SwaggerDateConverter;

namespace MFApiService.Model
{
    /// <summary>
    /// EntityListResponse
    /// </summary>
    [DataContract]
    public partial class EntityListResponse : IEquatable<EntityListResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EntityListResponse" /> class.
        /// </summary>
        /// <param name="result">result.</param>
        public EntityListResponse(EntityList result = default)
        {
            Result = result;
        }

        /// <summary>
        /// Gets or Sets Result
        /// </summary>
        [DataMember(Name = "result", EmitDefaultValue = false)]
        public EntityList Result { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EntityListResponse {\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
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
            return Equals(input as EntityListResponse);
        }

        /// <summary>
        /// Returns true if EntityListResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of EntityListResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EntityListResponse input)
        {
            if (input == null)
                return false;

            return

                    Result == input.Result ||
                    Result != null &&
                    Result.Equals(input.Result)
                ;
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
                if (Result != null)
                    hashCode = hashCode * 59 + Result.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
