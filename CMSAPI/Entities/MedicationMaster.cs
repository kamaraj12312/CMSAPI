using System.ComponentModel.DataAnnotations;

namespace HMS.Entities
{
    public class MedicationMaster
    {
        [Key]
        public int MedicationID { get; set; }
         public string? MedicationCode { get; set; }
        public string? MedicationName { get; set; }
        public string? Strength { get; set; }
        public string? MedicationType { get; set; }
        public string? GenericName { get; set; }
        public int? CostPrice { get; set; }
        public int? SellingPrice { get; set; }
        public int Stock {  get; set; }       
        public int? GST { get; set; }
        public DateTime  ExpiryDate { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? ManufacturingDate { get; set; }
        public string? Category { get; set; }          
        public string? Composition { get; set; }    
        public string? ShelfLocation { get; set; }  
        public string? Barcode { get; set; }        
        public string? BatchNumber { get; set; }   
        public string? Supplier { get; set; }       
        public string? Status { get; set; }

    }
}
