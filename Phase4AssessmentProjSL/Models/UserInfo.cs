using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Phase4AssessmentProjSL.Models
{
    public class UsersInfo
    {
        [Required]
        public int UserId { get; set; }
        public string Email { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
    public class CustomerInfo
    {
        [Required]
        public int LogId { get; set; }
        [DataType(DataType.EmailAddress)]
        [Required]
        public string CustEmail { get; set; }
        [Required]
        public string CustName { get; set; }
        [Required]
        public string LogStatus { get; set; }
        [Required]
        public Nullable<int> UserId { get; set; }
        [Required]
        public string Description { get; set; }
    }
}