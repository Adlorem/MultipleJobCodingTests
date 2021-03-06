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
    /// EntityPerson
    /// </summary>
    [DataContract]
    public partial class EntityPerson : IEquatable<EntityPerson>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EntityPerson" /> class.
        /// </summary>
        /// <param name="companyName">companyName.</param>
        /// <param name="firstName">firstName.</param>
        /// <param name="lastName">lastName.</param>
        /// <param name="pesel">pesel.</param>
        /// <param name="nip">nip.</param>
        public EntityPerson(string companyName = default, string firstName = default, string lastName = default, string pesel = default, string nip = default)
        {
            CompanyName = companyName;
            FirstName = firstName;
            LastName = lastName;
            Pesel = pesel;
            Nip = nip;
        }

        /// <summary>
        /// Gets or Sets CompanyName
        /// </summary>
        [DataMember(Name = "companyName", EmitDefaultValue = false)]
        public string CompanyName { get; set; }

        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [DataMember(Name = "firstName", EmitDefaultValue = false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [DataMember(Name = "lastName", EmitDefaultValue = false)]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or Sets Pesel
        /// </summary>
        [DataMember(Name = "pesel", EmitDefaultValue = false)]
        public string Pesel { get; set; }

        /// <summary>
        /// Gets or Sets Nip
        /// </summary>
        [DataMember(Name = "nip", EmitDefaultValue = false)]
        public string Nip { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EntityPerson {\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Pesel: ").Append(Pesel).Append("\n");
            sb.Append("  Nip: ").Append(Nip).Append("\n");
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
            return Equals(input as EntityPerson);
        }

        /// <summary>
        /// Returns true if EntityPerson instances are equal
        /// </summary>
        /// <param name="input">Instance of EntityPerson to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EntityPerson input)
        {
            if (input == null)
                return false;

            return
                (
                    CompanyName == input.CompanyName ||
                    CompanyName != null &&
                    CompanyName.Equals(input.CompanyName)
                ) &&
                (
                    FirstName == input.FirstName ||
                    FirstName != null &&
                    FirstName.Equals(input.FirstName)
                ) &&
                (
                    LastName == input.LastName ||
                    LastName != null &&
                    LastName.Equals(input.LastName)
                ) &&
                (
                    Pesel == input.Pesel ||
                    Pesel != null &&
                    Pesel.Equals(input.Pesel)
                ) &&
                (
                    Nip == input.Nip ||
                    Nip != null &&
                    Nip.Equals(input.Nip)
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
                if (CompanyName != null)
                    hashCode = hashCode * 59 + CompanyName.GetHashCode();
                if (FirstName != null)
                    hashCode = hashCode * 59 + FirstName.GetHashCode();
                if (LastName != null)
                    hashCode = hashCode * 59 + LastName.GetHashCode();
                if (Pesel != null)
                    hashCode = hashCode * 59 + Pesel.GetHashCode();
                if (Nip != null)
                    hashCode = hashCode * 59 + Nip.GetHashCode();
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
