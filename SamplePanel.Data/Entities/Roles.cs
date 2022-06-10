using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SamplePanel.Data
{
    public class Roles:BaseEntities
    {
        [Key]       
        public int ID { get; set; }
        [Column("RoleName", TypeName = "nvarchar")]
        [MaxLength(20)]
        public string RoleName { get; set; }
        [Column("RoleTitle", TypeName = "nvarchar")]
        [MaxLength(20)]
        public string RoleTitle { get; set; }

        public ICollection<Users> Users { get; set; }
        public ICollection<Role_Permission> Role_Permissions { get; set; }
    }
}
