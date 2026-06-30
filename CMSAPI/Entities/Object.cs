using System.ComponentModel.DataAnnotations;

namespace HMS.Entities
{
    public class Object
    {
        [Key]
       public int  ObjectUserID { get; set; }
      public int ObjectID { get; set; }
       public  string  MenuName { get; set; }
     public string  ObjectFlag { get; set; }
     public string  CreateBy { get; set; }
     public DateTime CreateDate { get; set; }
     public DateTime  ModifiedDate { get; set; }
      public string   ModifiedBy { get; set; }  
    }
}
