using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LoginandR.Models
{
    public class Feedback
    {   
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int fID { get; set; }
        [Required]
        [Display(Name = "User ID")]
        public int uID { get; set; }
        [Required]
        [Display(Name = "Feedback Date")]
        public DateTime fDate { get; set; }
        [Required]
        [Display(Name = "Feedback Message")]
        public string fMessage { get; set; }
        [ForeignKey("uID")]
        public virtual User User { get; set; }
    }
}