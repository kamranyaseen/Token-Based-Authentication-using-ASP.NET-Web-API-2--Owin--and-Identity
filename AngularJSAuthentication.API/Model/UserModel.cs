using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AngularJSAuthentication.API.Model
{
    public class UserModel
    {
        [Required]
        [Display(Name = "User name")]
        public string UserName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }


        //[Required]
        //[StringLength(100, ErrorMessage = "The Email Address is not valid.")]
        //[DataType(DataType.EmailAddress)]
        //[Display(Name = "Email")]
        //public string Email { get; set; }

        //[Required]
        //[StringLength(100, ErrorMessage = "The Confirm Email Address is not valid.")]
        //[DataType(DataType.EmailAddress)]
        //[Display(Name = "EmailConfirmed")]
        //public string EmailConfirmed { get; set; }

        //[Required]
        //[StringLength(100, ErrorMessage = "The phone number is not valid.")]
        //[DataType(DataType.PhoneNumber)]
        //[Display(Name = "PhoneNumber")]
        //public string PhoneNumber { get; set; }

        //[Required]
        //[StringLength(100, ErrorMessage = "The confirm phone number is not valid.")]
        //[DataType(DataType.PhoneNumber)]
        //[Display(Name = "PhoneNumberConfirmed")]
        //public string PhoneNumberConfirmed { get; set; }
    }
}