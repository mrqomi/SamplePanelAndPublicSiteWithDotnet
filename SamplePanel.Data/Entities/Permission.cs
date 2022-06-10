using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamplePanel.Data
{
    public class Permission:BaseEntities
    {
        [Key]
        public int ID { get; set; }
        [Column("PermissionName", TypeName = "nvarchar")]
        [MaxLength(50)]        
        public string PermissionName { get; set; }
        [Column("PermissionURL", TypeName = "nvarchar")]
        [MaxLength(500)]
        public string PermissionURL { get; set; }

        public ICollection<Role_Permission> Role_Permissions { get; set; }
    }
}
