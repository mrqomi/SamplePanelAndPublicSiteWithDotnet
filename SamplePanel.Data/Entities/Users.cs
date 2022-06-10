using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamplePanel.Data
{
    public class Users
    {
        [Key]
        public Guid ID { get; set; }
        [Column("FName", TypeName = "nvarchar")]
        [MaxLength(20)]
        public string FName{ get; set; }
        [Column("LName", TypeName = "nvarchar")]
        [MaxLength(20)]
        public string LName { get; set; }
        [Column("PhoneNumber", TypeName = "nvarchar")]
        [MaxLength(20)]
        public string PhoneNumber { get; set; }
        [Column("Email", TypeName = "nvarchar")]
        [MaxLength(500)]
        public string Email { get; set; }
        public bool Active { get; set; }

        public int RoleID { get; set; }
        public Roles Role { get; set; }
    }
}
