using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamplePanel.Data
{
    public class Role_Permission
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }
        public int RoleID { get; set; }
        public int PermissionID { get; set; }

        public Permission permission { get; set; }
        public Roles Role { get; set; }
    }
}
