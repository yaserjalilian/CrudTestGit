using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestCrud.Models
{
    public class Customer
    {
        [Key]
        public long Id { get; set; }
        [MaxLength(50, ErrorMessage = "Please Juset Insert 50 Charachter For First Name")]
        [DisplayName("First Name")]
        [Required(ErrorMessage = "Please Insert First Name")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        [Required(ErrorMessage = "Please Insert Last Name")]
        [MaxLength(50, ErrorMessage = "Please Juset Insert 50 Charachter For First Name")]
      
        public string lastName { get; set; }
        [DisplayName("Date Of Birth")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Please Date Of Birth")]
       
        public string DateOfBirth { get; set; }
        [MaxLength(20, ErrorMessage = "Please Juset Insert 11 Charachter For Phone")]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Please Phone Number")]
        [DisplayName("Phone Number")]
        public string PhoneNumber { get; set; }

        [Remote("RepeatUser", "Customers")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Please Insert Email Address")]
        [DisplayName("Email Address")]
        public string Email { get; set; }
      
        [Required(ErrorMessage = "Please Insert Bank Account Number")]
        [DisplayName("Bank Account Number")]
        public string BankAccountNumber { get; set; }

    }
}
