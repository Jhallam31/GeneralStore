using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GeneralStore.MVC.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionID { get; set; }

        [Required]
        [Display(Name = "Purchase amount")]
        public decimal NumberofProducts { get; set; } = 1;

        [Required]
        [Display(Name ="Transaction Date/Time")]
        public DateTimeOffset DateCreated { get; set; }

        // Foreign key 
        [Display(Name = "Customer")]
        public int CustomerID { get; set; }

        [ForeignKey("CustomerID")]
        public virtual Customer Customers { get; set; }

        //Foreign Key
        [Display(Name ="Product")]
        public int ProductID { get; set; }
        [ForeignKey("CustomerID")]
        public virtual Product Products { get; set; }

    }
}