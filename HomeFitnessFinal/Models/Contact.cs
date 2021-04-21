using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HomeFitnessFinal.Models
{
    public class Contact
    {
        [Key]
        public int MessageId { get; set; }

        [Display(Name = "Sender Name")]
        public string SenderName { get; set; }

        [Required(ErrorMessage = "Required.")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Invalid Format.")]
        public string Email { get; set; }

        [Display(Name = "Contact number")]
        public string ContactNo { get; set; }

        [Required(ErrorMessage = "Required.")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "Required.")]
        [DataType(DataType.MultilineText)]
        public string Message { get; set; }
    }
}
