using System.ComponentModel.DataAnnotations;


namespace SamplePanel.Data
{
    public class Roles
    {
        [Key]
        public int ID { get; set; }
        public string RoleName { get; set; }
        public string RoleTitle { get; set; }

        public ICollection<Users> Users { get; set; }
    }
}
