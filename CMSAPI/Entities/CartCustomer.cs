using System.ComponentModel.DataAnnotations;

namespace HMS
{
    public class CartCustomer
    {
        [Key]
        public int CartID { get; set; }
        public string CustomerNumber { get; set; }
         public string medicationName { get; set; }
        public int medicationtotal { get; set; }
        public int SubtotalCast { get; set; }
        public string totalCast { get; set; }
         public DateTime CreateDate { get; set; }
         public string Createby { get; set; }

    }
}
