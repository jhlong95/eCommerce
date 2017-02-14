using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Domain.Entities
{
    public class ShippingDetails
    {
        [Required(ErrorMessage = "Please Enter a Name")]
        [StringLength(160)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Enter the First Address Line")]
        [StringLength(70)]
        [Display(Name = "Line 1")]
        public string Line1 { get; set; }
        [StringLength(70)]
        [Display(Name = "Line 2")]
        public string Line2 { get; set; }
        [StringLength(70)]
        [Display(Name = "Line 3")]
        public string Line3 { get; set; }

        [Required(ErrorMessage = "Please Enter a City Name")]
        [StringLength(40)]
        public string City { get; set; }

        [Required(ErrorMessage = "Please Enter a County Name")]
        [StringLength(40)]
        public string County { get; set; }

        [Required(ErrorMessage = "Please Enter a Postcode")]
        [StringLength(10)]
        public string Postcode { get; set; }

        [Required(ErrorMessage = "Please Enter a Country Name")]
        [StringLength(40)]
        public string Country { get; set; }

        public bool GiftWrap { get; set; }
    }
}
