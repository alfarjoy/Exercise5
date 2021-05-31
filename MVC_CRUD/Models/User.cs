using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_CRUD.Models
{
    public class User
    {


        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Name is required. Please input your complete name. (Example: Juan Abad)")]
        [StringLength(50)]
        [RegularExpression(@"^(([A-za-z]+[\s]{1}[A-za-z]+)|([A-Za-z]+))$", ErrorMessage = "Please input your complete name. (Example: Juan Abad)")]
        public string Name { get; set; }

        [Required(ErrorMessage = " Address is required. (Example: 123 Main Street, Colon, Cebu City")]
        [StringLength(50)]
        [RegularExpression("[0-9a-zA-Z #,-]+", ErrorMessage = "Please input your address correctly.(Example: 123 Main Street, Colon, Cebu City)")]
        public string Address { get; set; }

        [Required]
        [Range(1, 120)]
        public int Age { get; set; }

        [Required(ErrorMessage = "Please provide your gender. Must be either 'm','M'or'f','F'.")]
        [RegularExpression("M|m|F|f", ErrorMessage = "The Gender must be either 'm','M'or'f','F'.")]
        public string Gender { get; set; }

        [Required, DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy HH:mm:ss}")]
        public string Date_TimeIn { get; set; }

        [Required(ErrorMessage = "Please input your temperature from 33.0 to 40.0.")]
        [Range(33.0, 40.0)]
        public double Temperature { get; set; }

        [Required(ErrorMessage = "Please input your number.")]
        [StringLength(13)]
        [RegularExpression("((\\+63)|0)\\d{10}", ErrorMessage = "Please input your mobile number.")]
        public string MobileNumber { get; set; }

        [Required (ErrorMessage ="Please provide your Email Address")]
        [RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z",
                            ErrorMessage = "Please enter a valid email address. (Example: example@gmail.com)")]
        public string EmailAddress { get; set; }

    }
}
