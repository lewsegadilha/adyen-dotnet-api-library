﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using System.Linq;
using Newtonsoft.Json;

namespace Adyen.EcommLibrary.Model.CheckoutUtility
{
   /// <summary>
    /// OriginKeysResponse
    /// </summary>
    [DataContract]
    public class OriginKeysResponse : IEquatable<OriginKeysResponse>, IValidatableObject
    {
        [DataMember(Name = "originKeys", EmitDefaultValue = false)]
        public Dictionary<string,string> OriginKeys { get;set;}
        
        public bool Equals(OriginKeysResponse input)
        {
            if (input == null)
                return false;

            return (
             this.OriginKeys == input.OriginKeys ||
                    this.OriginKeys != null &&
                    this.OriginKeys.SequenceEqual(input.OriginKeys));
        } 

        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OriginKeysResponse {\n");
            sb.Append("  OriginKeys: ").Append(OriginKeys).Append("\n");
         
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return this.Equals(input as OriginKeysResponse);
        }
        
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
              yield break;
        }
    }
}
