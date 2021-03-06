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
    /// EntryList
    /// </summary>
    [DataContract]
    public partial class EntryList : IEquatable<EntryList>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EntryList" /> class.
        /// </summary>
        /// <param name="entries">Lista odpowiedzi (required).</param>
        /// <param name="requestDateTime">requestDateTime.</param>
        /// <param name="requestId">requestId.</param>
        public EntryList(List<OneOfEntryListEntriesItems> entries = default, string requestDateTime = default, string requestId = default)
        {
            // to ensure "entries" is required (not null)
            if (entries == null)
            {
                throw new InvalidDataException("entries is a required property for EntryList and cannot be null");
            }
            else
            {
                Entries = entries;
            }
            RequestDateTime = requestDateTime;
            RequestId = requestId;
        }

        /// <summary>
        /// Lista odpowiedzi
        /// </summary>
        /// <value>Lista odpowiedzi</value>
        [DataMember(Name = "entries", EmitDefaultValue = false)]
        public List<OneOfEntryListEntriesItems> Entries { get; set; }

        /// <summary>
        /// Gets or Sets RequestDateTime
        /// </summary>
        [DataMember(Name = "requestDateTime", EmitDefaultValue = false)]
        public string RequestDateTime { get; set; }

        /// <summary>
        /// Gets or Sets RequestId
        /// </summary>
        [DataMember(Name = "requestId", EmitDefaultValue = false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EntryList {\n");
            sb.Append("  Entries: ").Append(Entries).Append("\n");
            sb.Append("  RequestDateTime: ").Append(RequestDateTime).Append("\n");
            sb.Append("  RequestId: ").Append(RequestId).Append("\n");
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
            return Equals(input as EntryList);
        }

        /// <summary>
        /// Returns true if EntryList instances are equal
        /// </summary>
        /// <param name="input">Instance of EntryList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EntryList input)
        {
            if (input == null)
                return false;

            return
                (
                    Entries == input.Entries ||
                    Entries != null &&
                    input.Entries != null &&
                    Entries.SequenceEqual(input.Entries)
                ) &&
                (
                    RequestDateTime == input.RequestDateTime ||
                    RequestDateTime != null &&
                    RequestDateTime.Equals(input.RequestDateTime)
                ) &&
                (
                    RequestId == input.RequestId ||
                    RequestId != null &&
                    RequestId.Equals(input.RequestId)
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
                if (Entries != null)
                    hashCode = hashCode * 59 + Entries.GetHashCode();
                if (RequestDateTime != null)
                    hashCode = hashCode * 59 + RequestDateTime.GetHashCode();
                if (RequestId != null)
                    hashCode = hashCode * 59 + RequestId.GetHashCode();
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
