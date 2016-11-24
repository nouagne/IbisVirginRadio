using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace MRM.UMS.Core.BO
{
    /// <summary>
    /// Représente un role
    /// </summary>
    [Table("Roles")]
    [DataContract]
    public class Role
    {
        /// <summary>
        /// Initialise une nouvelle instance de la classe Role
        /// </summary>
        public Role()
        {
            Id = 0;
            Name = String.Empty;
        }

        /// <summary>
        /// Obtient ou définit l'identifiant unique
        /// </summary>
        [Key]
        [Column("id")]
        [DataMember]
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        /// <summary>
        /// Obtient ou définit l'intitulé du rôle
        /// </summary>
        [Column("name")]
        [DataMember]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        // Navigation property 
        public virtual List<UserRole> UserRoles { get; set; }
    }
}
