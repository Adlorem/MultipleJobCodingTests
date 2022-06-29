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
    /// Exception
    /// </summary>
    [DataContract]
    public partial class Exception : IEquatable<Exception>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Exception" /> class.
        /// </summary>
        /// <param name="message">message (required).</param>
        /// <param name="code">code (required).</param>
        public Exception(string message = default, string code = default)
        {
            // to ensure "message" is required (not null)
            if (message == null)
            {
                throw new InvalidDataException("message is a required property for Exception and cannot be null");
            }
            else
            {
                Message = message;
            }
            // to ensure "code" is required (not null)
            if (code == null)
            {
                throw new InvalidDataException("code is a required property for Exception and cannot be null");
            }
            else
            {
                Code = code;
            }
        }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public string Code { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Exception {\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
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
            return Equals(input as Exception);
        }

        /// <summary>
        /// Returns true if Exception instances are equal
        /// </summary>
        /// <param name="input">Instance of Exception to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Exception input)
        {
            if (input == null)
                return false;

            return
                (
                    Message == input.Message ||
                    Message != null &&
                    Message.Equals(input.Message)
                ) &&
                (
                    Code == input.Code ||
                    Code != null &&
                    Code.Equals(input.Code)
                );
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
                if (Message != null)
                    hashCode = hashCode * 59 + Message.GetHashCode();
                if (Code != null)
                    hashCode = hashCode * 59 + Code.GetHashCode();
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