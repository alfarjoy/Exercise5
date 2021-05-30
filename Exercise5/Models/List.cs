using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise5.Models
{
    public class List
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Last Name is required.")]
        [StringLength(50)]
        [RegularExpression(@"^(([A-za-z]+[\s]{1}[A-za-z]+)|([A-Za-z]+))$", ErrorMessage = "Please enter your Last Name.")]
        public string Lname { get; set; }

        [Required(ErrorMessage = "First Name is required.")]
        [StringLength(50)]
        [RegularExpression(@"^(([A-za-z]+[\s]{1}[A-za-z]+)|([A-Za-z]+))$", ErrorMessage = "Please enter your First Name.")]
        public string Fname { get; set; }

        [StringLength(50)]
        public string Mname { get; set; }

        [Required(ErrorMessage = " Address is required.")]
        [StringLength(50)]
        [RegularExpression("[0-9a-zA-Z #,-]+", ErrorMessage = "Please enter your address correctly.")]
        public string Address { get; set; }

        [Required]
        [Range(1, 120)]
        public int Age { get; set; }

        [Required(ErrorMessage = "Gender is required.")]
        [RegularExpression("M|m|F|f", ErrorMessage = "Please enter your address correctly.( 'm','M'or'f','F').")]
        public string Gender { get; set; }

        [Required, DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy HH:mm:ss}")]
        public string Bday { get; set; }

        [Required(ErrorMessage = "Please input your number.")]
        [StringLength(13)]
        [RegularExpression("((\\+63)|0)\\d{10}", ErrorMessage = "Please input your mobile number.")]
        public string MobileNumber { get; set; }

        [Required(ErrorMessage = "Email Address is required")]
        [RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z",
                            ErrorMessage = "Please enter a valid email address.")]
        public string EmailAddress { get; set; }
    }
}
