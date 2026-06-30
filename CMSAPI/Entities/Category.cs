using System.ComponentModel.DataAnnotations;

namespace HMS.Entities
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }         
        public string CategoryName { get; set; }     
        public DateTime CreateDate { get; set; }     
        public string CreateBy { get; set; }
    }
}
