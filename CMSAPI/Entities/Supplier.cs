using System.ComponentModel.DataAnnotations;

namespace HMS.Entities
{
    public class Supplier
    {
        [Key]
        public int SupplierID { get; set; }
        public string SupplierName { get; set; }
        public string SupplierAddress { get; set; }
        public string SupplierPhone { get; set; }
        public Boolean SupplierDelete { get; set; }
        public  DateTime CreateDate { get; set; }
        public string? CreateBy { get; set; }
        public string? GSTIN { get; set;}
        public string? PaymentTerms { get; set; }
        public string? Email { get; set; }
        public string? ContactPerson { get; set; }
    }
}
