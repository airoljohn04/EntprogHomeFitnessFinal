using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HomeFitnessFinal.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [Required(ErrorMessage = "Required.")]
        public string CustomerName { get; set; }

        [Required(ErrorMessage = "Required.")]
        [DataType(DataType.MultilineText)]
        public string Address { get; set; }

        [Required(ErrorMessage = "Required.")]
        [DataType(DataType.MultilineText)]
        public string EquipmentOrder { get; set; }

        [Required(ErrorMessage = "Required.")]
        public decimal Quantity { get; set; }

        [Required(ErrorMessage = "Required.")]
        public string ContactNumber { get; set; }

        [Display(Name = "Date Added")]
        public DateTime DateAdded { get; set; }

        [Display(Name = "Payment Method")]
        [Required(ErrorMessage = "Required.")]
        public PaymentMethod PaymentMethod { get; set; }
    }
    public enum PaymentMethod
    {
        CashOnDelivery = 1,
        OnlinePayment = 2
    }

}
