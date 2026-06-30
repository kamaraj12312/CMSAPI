using System.ComponentModel.DataAnnotations;

namespace HMS.Entities
{
    public class UserRole
    {
        [Key]
        public int UserID { get; set; }
        public int RoleID { get; set; }
        public string ModuleLinks { get; set; }
        public string Moduleiron { get; set; }
     }
}
