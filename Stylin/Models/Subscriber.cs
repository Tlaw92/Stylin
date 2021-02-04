using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Stylin.Models
{
    public class Subscriber
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters.")]
        [Column("FirstName")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Last name cannot be longer than 50 characters.")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        //What is this? 
        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        [DataType(DataType.PostalCode)]
        [Display(Name = "Zip Code")]
        public int ZipCode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Picture { get; set; }

        [NotMapped]
        public IFormFile PictureFile { get; set; }

        public int Token { get; set; }

        [Display(Name = "Style Name")]
        public string StyleName { get; set; }

        [Display(Name = "Package Price")]
        public int PackagePrice { get; set; }

        [Display(Name = "Delivery Frequency")]
        public string DeliveryFreq { get; set; }

        //[ForeignKey("Style")]
        //public int StyleId { get; set; }
        //public Style Style { get; set; }

        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }
    }



}

