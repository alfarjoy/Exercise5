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

        [Required(ErrorMessage = "Please enter your complete name.")]
        [StringLength(50)]
        [RegularExpression(@"^(([A-za-z]+[\s]{1}[A-za-z]+)|([A-Za-z]+))$", ErrorMessage = "Invalid input, try again")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your complete address.")]
        [StringLength(50)]
        [RegularExpression("[0-9a-zA-Z #,-]+", ErrorMessage = "Invalid input, try again")]
        public string Address { get; set; }

        [Required]
        [Range(1, 120)]
        public int Age { get; set; }

        [Required, DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public string Bdate { get; set; }

        [Required(ErrorMessage = "Please enter your complete place of birth.")]
        [StringLength(50)]
        [RegularExpression("[0-9a-zA-Z #,-]+", ErrorMessage = "Invalid input, try again")]
        public string Placeofbirth { get; set; }

        [Required(ErrorMessage = "Please enter your Gender.")]
        [RegularExpression("M|m|F|f|Male|male|MALE|Female|female|FEMALE", ErrorMessage = "Invalid input, try again")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Please enter your number.")]
        [StringLength(13)]
        [RegularExpression("((\\+63)|0)\\d{10}", ErrorMessage = "Please input your mobile number.")]
        public string MobileNumber { get; set; }

        [Required (ErrorMessage ="Please enter your Email Address")]
        [RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z",
                            ErrorMessage = "Invalid input, try again")]
        public string EmailAddress { get; set; }

    }
}
