using System.ComponentModel.DataAnnotations;

namespace HMS.Entities
{
    public class MenuMaster
    {
        [Key]
       public int Menu_masterID { get; set; }
       public int MenuID { get; set; }
       public string MenuName { get; set; }
        public string? MenuUrl { get; set; }
         public int? ParentMenuId { get; set; }
        public string? Menu_MasterFlag { get; set;}
        public string? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
