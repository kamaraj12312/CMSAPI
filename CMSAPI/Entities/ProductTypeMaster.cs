using System.ComponentModel.DataAnnotations;

namespace HMS.Entities
{
    public class ProductTypeMaster
    {
        [Key]
       public int ProductTypeID { get; set; }
        public string ProductTypeName { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }

    }
}
