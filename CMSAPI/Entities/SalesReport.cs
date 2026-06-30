using System.ComponentModel.DataAnnotations;

namespace HMS
{
    public class SalesReport
    {
        [Key]
       public int SalesReportID { get; set; }
       public string Sales { get; set; }
       public string? CustomerId { get; set; }
       public DateTime CreateDate { get; set; }
       public string? CreateBy { get; set; }
    }
}
