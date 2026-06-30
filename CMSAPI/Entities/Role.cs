using System.ComponentModel.DataAnnotations;

namespace HMS.Entities
{
    public class Role
    {
        [Key]
        public int RoleID { get; set; }
        public string RoleName { get; set; }
    }
}
