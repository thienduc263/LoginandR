using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LoginandR.Models
{
    public class Supplier
    {
        [Key, Column(Order = 1)]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int supID { get; set; }
        [Required]
        public string supUsername { get; set; }
        [Required]
        public string supPwd { get; set; }
        [Required]
        public string supName { get; set; }
        [Required]
        public string supPhone { get; set; }
        [Required]
        public string supAddress { get; set; }
        [Required]
        public string supEmail { get; set; }
        [Required]
        public string supDescription { get; set; }
    }
}