


using System.ComponentModel.DataAnnotations;

namespace HMS.Entities
{
    public class Status
    {
        [Key]
        public int StatusID { get; set; }
        public string StatusDes { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
    }
}
