using System.ComponentModel.DataAnnotations;

namespace HMS
{
    public class MedicationReport
    {
        [Key]
         public int MedicationReportID { get; set; }
         public string customerID { get; set; }
         public string MedicationCode { get; set; }
         public string MedicationName { get; set; }
         public DateTime CreateDate { get; set; }
         public string CreateBy { get; set; }
    }
}
