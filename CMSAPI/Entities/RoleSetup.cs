using System.ComponentModel.DataAnnotations;

namespace HMS.Entities
{
    public class RoleSetup
    {
        [Key]
        public int RoleActionID { get; set; }

        public string? RoleSetupID { get; set; }

        public int MenuID { get; set; }

        public int? ModuleSetupID { get; set; }

        public bool Deleted { get; set; }

        public DateTime CreatedDate { get; set; }

        public string CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public string? ModifiedBy { get; set; }
    }
}
