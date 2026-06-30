using System.ComponentModel.DataAnnotations;

namespace HMS.Entities
{
    public class GSTmaster
    {
        [Key]
       public int GSTID { get; set; }
       public int GSTPercent { get; set; }
       public  string? HSNCode { get; set; }
        public string Description { get; set; }
        public DateTime EffectiveFrom { get; set; }
        public bool IsActive { get; set; }


    }
}
