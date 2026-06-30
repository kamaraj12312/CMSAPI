using System.ComponentModel.DataAnnotations;

namespace HMS.Entities
{
    public class UserMaster
    {
        [Key]
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string PasswordHash {  get; set; }
         public string DisplayName { get; set; }
         public bool IsActive { get; set; }
         public int RoleID { get; set; }
    }
}
