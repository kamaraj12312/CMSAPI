using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace HMS.Entities
{
    public class Menu
    {
       [Key]
        public int MenuID { get; set; }
        public int ObjectID { get; set; }
        public string MenuName { get; set; }
        public string? MenuUrl { get; set; }
        public int? ParentMenuId { get; set; }
        public string? MenuFlag { get; set; }    
        public string? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
