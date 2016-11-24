using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace MRM.UMS.Core.BO
{
    /// <summary>
    /// Représente un utilisateur
    /// </summary>
    [Table("Users")]
    [DataContract]
    public class User
    {
        /// <summary>
        /// Initialise une nouvelle instance de la classe User
        /// </summary>
        public User()
        {
            Id = 0;
            UUID = Guid.NewGuid();
            Username = string.Empty;
            Email = string.Empty;
            Password = string.Empty;
        }

        /// <summary>
        /// Obtient ou définit l'identifiant unique de l'utilisateur
        /// </summary>
        [Key]
        [Column("id")]
        [DataMember]
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        /// <summary>
        /// Obtient ou définit l'UUID (unique) de l'utilisateur
        /// </summary>
        [Column("uuid")]
        [DataMember]
        [JsonProperty(PropertyName = "uuid")]
        public Guid UUID { get; set; }

        /// <summary>
        /// Obtient ou définit le nom de l'utilisateur
        /// </summary>
        [Column("username")]
        [DataMember]
        [JsonProperty(PropertyName = "username")]
        [MaxLength(50)]
        public string Username { get; set; }

        /// <summary>
        /// Obtient ou définit l'email de l'utilisateur
        /// </summary>
        [Column("email")]
        [DataMember]
        [JsonProperty(PropertyName = "email")]
        [MaxLength(250)]
        public string Email { get; set; }

        /// <summary>
        /// Obtient ou définit le mot de passe de l'utilisateur
        /// </summary>
        [Column("password")]
        [JsonIgnore]
        [MaxLength(50)]
        public string Password { get; set; }

        // Navigation property  
        public List<UserRole> UserRoles { get; set; }
    }
}
