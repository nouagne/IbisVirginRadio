using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace MRM.UMS.Core.BO
{
    /// <summary>
    /// Représente un rôle d'un utilisateur
    /// </summary>
    [Table("UserRoles")]
    [DataContract]
    public class UserRole
    {
        public UserRole()
        { }

        /// <summary>
        /// Obtient ou définit l'identifiant unique
        /// </summary>
        [Key]
        [Column("id")]
        [DataMember]
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        /// <summary>
        /// Obtient ou définit l'identifiant de l'utilisateur
        /// </summary>
        [Column("user_id")]
        [DataMember]
        [JsonProperty(PropertyName = "user_id")]
        public int UserId { get; set; }

        /// <summary>
        /// Obtient ou définit l'identifiant du rôle
        /// </summary>
        [Column("role_id")]
        [DataMember]
        [JsonProperty(PropertyName = "role_id")]
        public int RoleId { get; set; }

        // Navigation property 
        public virtual User User { get; set; }

        // Navigation property
        public virtual Role Role { get; set; }
    }
}
